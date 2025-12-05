using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai05
{
    public partial class QLSV : Form
    {
        public QLSV()
        {
            InitializeComponent();
        }
        /// Xử lý sự kiện vẽ lại, đảm bảo image toolstripbutton dễ nhìn
        private void toolStripButton1_Paint(object sender, PaintEventArgs e)
        {
            ToolStripButton button = sender as ToolStripButton;
            if (button != null && button.Image != null)
            {
                Rectangle bounds = button.ContentRectangle;
                e.Graphics.DrawImage(button.Image, bounds);
            }
        }

        /// Chức năng thêm sinh viên mới
        private void NewSVFunct()
        {
            // Tạo và hiển thị form thêm sinh viên
            AddSV formAdd = new AddSV(); 
            var result = formAdd.ShowDialog();

            if (result == DialogResult.OK)
            {
                if (!IsPrimaryKeyUnique(formAdd.mssv))   // Kiểm tra tính duy nhất của MSSV  
                {
                    MessageBox.Show("MSSV đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // Thêm dòng mới vào DataGridView
                // Thứ tự cột: STT, MSSV, Tên, Khoa, Điểm TB
                dataGridView1.Rows.Add(dataGridView1.RowCount, formAdd.mssv, formAdd.ten, formAdd.khoa, formAdd.dtb);
                MessageBox.Show("Thêm mới thành công","Thông tin",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// Kiểm tra tính duy nhất của MSSV
        /// Đảm bảo mỗi sinh viên có MSSV không trùng lặp
        private bool IsPrimaryKeyUnique(string mssv)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue; 
                string existingMSSV = row.Cells["MaSV"].Value.ToString();
                if (existingMSSV == mssv) 
                {
                    return false;
                }
            }
            return true; 
        }

        /// Lọc danh sách sinh viên theo tên (họ hoặc tên)
        /// Chỉ hiển thị những sinh viên có tên khớp với từ khóa tìm kiếm
        private void FilterNames(string HoTen)
        {
            HoTen = HoTen.ToLower();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;
                string fullName = row.Cells["TenSV"].Value.ToString();
                string[] nameParts = fullName.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string lastName = nameParts[nameParts.Length - 1].ToLower();

                if (lastName.StartsWith(HoTen)) // Kiểm tra nếu tên bắt đầu bằng từ khóa tìm kiếm
                    row.Visible = true;
                else 
                    row.Visible = false;
                
            }
        }
        /// Tự động lọc danh sách khi người dùng nhập
        private void toolStripTextBox_Search_TextChanged(object sender, EventArgs e)
        {
            if (toolStripTextBox_Search.Text == "")
            {
                // Nếu ô tìm kiếm trống, hiển thị tất cả sinh viên
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.IsNewRow) continue;
                    row.Visible = true;
                }
            }
            else
            {
                // Nếu có từ khóa, thực hiện lọc theo tên
                FilterNames(toolStripTextBox_Search.Text);
            }
        }
        private void toolStripButton_New_Click(object sender, EventArgs e)
        {
            NewSVFunct();
        }
        private void ToolStripMenuItem_Add_Click(object sender, EventArgs e)
        {
            NewSVFunct();
        }
        private void ToolStripMenuItem_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
