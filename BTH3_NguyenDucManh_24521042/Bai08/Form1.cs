using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai08
{
    public partial class Form1 : Form
    {
        Regex ID_User = new Regex(@"^\d{8,10}$"),
              Name_User = new Regex(@"^[\p{L}\s]+$"),
              Money_User = new Regex(@"^\d+$");

        public Form1()
        {
            InitializeComponent();
        }



        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_AddUpdate_Click(object sender, EventArgs e)
        {
            if (textBox_STK.Text == "" || textBox_TenKH.Text == "" || textBox_DiaChi.Text == "" || textBox_SoTien.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string InvalidInput = "";
            if (!ID_User.IsMatch(textBox_STK.Text))
            {
                InvalidInput += "Số tài khoản không hợp lệ";
            }
            if (!Name_User.IsMatch(textBox_TenKH.Text))
            {
                if (InvalidInput.Length > 0) InvalidInput += "\n";
                InvalidInput += "Tên khách hàng không hợp lệ";
            }
            if (!Money_User.IsMatch(textBox_SoTien.Text))
            {
                if (InvalidInput.Length > 0) InvalidInput += "\n";
                InvalidInput += "Số tiền không hợp lệ";
            }
            if (InvalidInput.Length > 0)
            {
                MessageBox.Show(InvalidInput, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            bool isExist = false;

            //Cập nhật
            foreach (ListViewItem item in listView_TaiKhoan.Items)
            {
                if (item.SubItems[1].Text == textBox_STK.Text)
                {
                    item.SubItems[2].Text = textBox_TenKH.Text;
                    item.SubItems[3].Text = textBox_DiaChi.Text;
                    item.SubItems[4].Text = double.Parse(textBox_SoTien.Text).ToString("N0");
                    isExist = true;
                    MessageBox.Show("Cập nhật dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                }
            }
            //Thêm
            if (!isExist)
            {
                ListViewItem item = new ListViewItem((listView_TaiKhoan.Items.Count + 1).ToString());
                item.SubItems.Add(textBox_STK.Text);
                item.SubItems.Add(textBox_TenKH.Text);
                item.SubItems.Add(textBox_DiaChi.Text);
                item.SubItems.Add(double.Parse(textBox_SoTien.Text).ToString("N0"));
                listView_TaiKhoan.Items.Add(item);
            }
            TinhTongTien();
        }
        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (!ID_User.IsMatch(textBox_STK.Text))
            {
                MessageBox.Show("Không tìm thấy số tài khoản cần xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            bool found = false;
            foreach (ListViewItem item in listView_TaiKhoan.Items)
            {
                if (item.SubItems[1].Text == textBox_STK.Text)
                {
                    found = true;
                    DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa tài khoản này?", "Xác nhận",
                                                          MessageBoxButtons.YesNo,
                                                          MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        listView_TaiKhoan.Items.Remove(item);
                        MessageBox.Show("Xóa tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
                }
            }
            TinhTongTien();
            if (!found)
            {
                MessageBox.Show("Không tìm thấy số tài khoản cần xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void listView_TaiKhoan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView_TaiKhoan.SelectedItems.Count > 0)
            {
                ListViewItem item = listView_TaiKhoan.SelectedItems[0];
                textBox_STK.Text = item.SubItems[1].Text;
                textBox_TenKH.Text = item.SubItems[2].Text;
                textBox_DiaChi.Text = item.SubItems[3].Text;
                textBox_SoTien.Text = double.Parse(item.SubItems[4].Text).ToString();
            }
        }
        private void TinhTongTien()
        {
            double tong = 0;
            foreach (ListViewItem item in listView_TaiKhoan.Items)
            {
                tong += Double.Parse(item.SubItems[4].Text);
            }
            textBox_TongTien.Text = tong.ToString("N0");
        }
    }
}
