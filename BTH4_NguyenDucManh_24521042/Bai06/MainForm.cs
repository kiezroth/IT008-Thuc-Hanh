using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai06
{
    public partial class MainForm : Form
    {
        // Biến đồng bộ hóa để tạm dừng/tiếp tục tiến trình
        private ManualResetEvent resetEvent = new ManualResetEvent(true);

        // Mảng lưu danh sách các file cần sao chép
        string[] Files;

        // Biến đếm tổng số file
        int cntFiles = 0;
        public MainForm()
        {
            InitializeComponent();
        }

        private void button_src_Click(object sender, EventArgs e)         //Chọn đường dẫn nguồn chứa các tệp tin

        {
            using (FolderBrowserDialog dlg = new FolderBrowserDialog())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                    textBox_src.Text = dlg.SelectedPath;
            }
        }
        private void button_dest_Click(object sender, EventArgs e)        //Chọn đường dẫn đích chứa các tệp tin
        {
            using (FolderBrowserDialog dlg = new FolderBrowserDialog())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                    textBox_dest.Text = dlg.SelectedPath;
            }
        }

        private void button_Copy_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(textBox_src.Text))
            {
                MessageBox.Show("Đường dẫn không tồn tại", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Directory.Exists(textBox_dest.Text))  // Nếu thư mục đích không tồn tại, tạo mới
                Directory.CreateDirectory(textBox_dest.Text);

            progressBar1.Value = 0;
            label_Status.Text = "";

            // Khởi chạy BackgroundWorker để sao chép file trong nền
            backgroundWorker_Copy.RunWorkerAsync();

            overwriteAll = false;
            groupBox_copy.Enabled = false;
        }

        // Biến cờ để xử lý overwrite tất cả file
        private bool overwriteAll = false;

        // Biến cờ để xử lý skip tất cả file
        private bool skipAll = false;


        /// Phương thức thực thi trong background thread
        /// Xử lý sao chép tất cả file từ thư mục nguồn đến thư mục đích
        private void backgroundWorker_Copy_DoWork(object sender, DoWorkEventArgs e)
        {
            Files = Directory.GetFiles(textBox_src.Text, "*.*", SearchOption.AllDirectories);
            cntFiles = Files.Length;

            int cnt = 0;

            foreach (var f in Files)
            {
                resetEvent.WaitOne();  // Kiểm tra tín hiệu pause/resume
                if (backgroundWorker_Copy.CancellationPending)   // Kiểm tra xem người dùng có yêu cầu hủy không
                {
                    e.Cancel = true;
                    return;
                }
                string dest = f.Replace(textBox_src.Text, textBox_dest.Text);
                Directory.CreateDirectory(Path.GetDirectoryName(dest));

                bool needCopy = skipAll ? false : true;
                string finalDest = dest;
                cnt++;
                int percent = (int)((double)cnt / cntFiles * 100);

                // Báo cáo tiến độ lên UI thread
                backgroundWorker_Copy.ReportProgress(percent, f);
                if (File.Exists(dest)) //Trùng file ?
                {
                    if (!overwriteAll && !skipAll) // Nếu chưa chọn overwrite/skip ALL, Hỏi
                    { 
                        myMessageBox.DlgRes result = myMessageBox.DlgRes.None;
                        this.Invoke(new Action(() =>
                        {
                            var box = new myMessageBox(Path.GetFileName(f));
                            box.ShowDialog();
                            result = box.choice;
                        }));

                        /// Xử lý kết quả lựa chọn
                        if (result == myMessageBox.DlgRes.OverwriteALL)
                            overwriteAll = true;
                        else if (result == myMessageBox.DlgRes.Skip)
                            continue;
                        else if (result == myMessageBox.DlgRes.SkipAll)
                        {
                            skipAll = true;
                            continue;
                        }
                    }
                }
                if (needCopy) 
                    File.Copy(f, finalDest, true);

            }
        }

        /// Xử lý sự kiện thay đổi tiến độ
        private void backgroundWorker_Copy_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            string fname = e.UserState.ToString();
            label_Status.Text = "Đang sao chép: " + Path.GetFileName(fname);
            toolTip1.SetToolTip(label_Status, fname);
            toolTip1.SetToolTip(panel3, fname);

        }

        /// Xử lý sự kiện hoàn thành sao chép
        private void backgroundWorker_Copy_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            label_Status.Text = "Hoàn tất sao chép";
            MessageBox.Show("Sao chép hoàn tất","Information",MessageBoxButtons.OK, MessageBoxIcon.Information);
            groupBox_copy.Enabled = true;
        }


        /// Kiểm tra và xử lý khi người dùng cố đóng form trong khi đang sao chép
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (backgroundWorker_Copy.IsBusy) // Kiểm tra nếu BackgroundWorker đang chạy
            {
                resetEvent.Reset(); // Tạm dừng tiến trình sao chép
                var res = MessageBox.Show("Tiến trình đang hoạt động\n" +
                    "Bạn có muốn dừng sao chép không ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.Yes)
                {
                    backgroundWorker_Copy.CancelAsync(); // Hủy tiến trình sao chép
                    e.Cancel = false;
                }
                else e.Cancel = true;
                // Tiếp tục tiến trình sao chép (nếu không hủy)
                resetEvent.Set();
            }
        }
    }
}
