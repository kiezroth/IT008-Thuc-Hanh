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

namespace Bai09
{

    public partial class Form1 : Form
    {
        List<string> MonHoc_Chung = new List<string>
        {
            "Giải tích",
            "Nhập môn lập trình",
            "Lập trình hướng đối tượng",
            "Cấu trúc dữ liệu & Giải thuật"
        };
        List<string> MonHoc_KTMT = new List<string>
        {
            "Xử lý tín hiệu số",
            "Vi xử lý-vi điều khiển"
        };
        List<string> MonHoc_MMTTT = new List<string>
        {
            "Internet of Things",
            "Quản lý an toàn thông tin"
        };
        List<string> MonHoc_KHMT = new List<string>
        {
            "Máy học",
            "Phân tích và thiết kế thuật toán"
        };
        List<string> MonHoc_HTTT = new List<string>
        {
            "Hệ thống y tế",
            "Quản trị tài chính và bảo hiểm y tế"
        };
        List<string> MonHoc_CNTT = new List<string>
        {
            "Xử lý dữ liệu thống kê",
            "Quản lý thông tin"
        };
        List<string> MonHoc_TTNT = new List<string>
        {
            "Hệ thống đa tác tử",
            "Các hệ giải bài toán thông minh"
        };
        List<string> MonHoc_KTPM = new List<string>
        {
            "Phát triển phần mềm mã nguồn mở",
            "Phương pháp mô hình hóa"
        };
        List<string> MonHoc_TKVM = new List<string>
        {
            "Thiết kế vi mạch tương tự",
            "Thiết kế vi mạch hỗn hợp"
        };
        List<string> MonHoc_ATTT = new List<string>
        {
            "Phát triển ứng dụng trên thiết bị di động",
            "Phương pháp học máy trong an toàn thông tin"
        };
        List<string> MonHoc_TMDT = new List<string>
        {
            "Thiết kế hệ thống TMĐT",
            "Quản trị tài chính doanh nghiệp"
        };
        List<string> MonHoc_KHDL = new List<string>
        {
            "Khai phá dữ liệu trong doanh nghiệp",
            "Các mô hình nền tảng"
        };
        Regex ID_User = new Regex(@"^\d{8}$"),
            Name_User = new Regex(@"^[\p{L}\s]+$");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_MSSV.Text) || string.IsNullOrWhiteSpace(textBox_TenSV.Text) || (!radioButton_Nam.Checked && !radioButton_Nu.Checked) 
                || comboBox_CN.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string InvalidInput = "";
            if (!ID_User.IsMatch(textBox_MSSV.Text))
            {
                InvalidInput += "Mã số sinh viên không hợp lệ";
            }
            if (!Name_User.IsMatch(textBox_TenSV.Text))
            {
                if (InvalidInput.Length > 0) InvalidInput += "\n";
                InvalidInput += "Tên sinh viên không hợp lệ";
            }
            if (InvalidInput.Length > 0)
            {
                MessageBox.Show(InvalidInput, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            bool isExist = false;

            
            foreach (ListViewItem item in listView_DS.Items)
            {
                if (item.SubItems[1].Text == textBox_MSSV.Text)
                {
                    item.SubItems[2].Text = textBox_TenSV.Text;
                    item.SubItems[3].Text = comboBox_CN.Text;
                    item.SubItems[4].Text = (radioButton_Nam.Checked ? "Nam" : "Nữ");
                    item.SubItems[5].Text = listBox_selected.Items.Count.ToString();
                    MessageBox.Show("Cập nhật dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    isExist = true;
                    break;
                }
            }
            if (!isExist) 
            {
                ListViewItem item = new ListViewItem((listView_DS.Items.Count + 1).ToString());
                {
                    item.SubItems.Add(textBox_MSSV.Text);
                    item.SubItems.Add(textBox_TenSV.Text);
                    item.SubItems.Add(comboBox_CN.Text);
                    item.SubItems.Add(radioButton_Nam.Checked ? "Nam" : "Nữ");
                    item.SubItems.Add(listBox_selected.Items.Count.ToString());

                };
                listView_DS.Items.Add(item);
            }

        }

        private void button_add_Click(object sender, EventArgs e)
        {
            if (listBox_unselect.SelectedItem != null)
            {
                var item = listBox_unselect.SelectedItem;
                listBox_selected.Items.Add(item);
                listBox_unselect.Items.Remove(item);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một mục để chuyển!");
            }
        }

        private void button_remove_Click(object sender, EventArgs e)
        {
            if (listBox_selected.SelectedItem != null)
            {
                var item = listBox_selected.SelectedItem;
                listBox_unselect.Items.Add(item);
                listBox_selected.Items.Remove(item);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một mục để chuyển!");
            }
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (listView_DS.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView_DS.SelectedItems[0];
                listView_DS.Items.Remove(selectedItem);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một mục để xóa!");
            }
        }

        private void comboBox_CN_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox_unselect.Items.Clear();
            listBox_selected.Items.Clear();
            listBox_unselect.Items.AddRange(MonHoc_Chung.ToArray());
            switch (comboBox_CN.SelectedItem.ToString())
                {
                    case "Công nghệ Thông tin":
                        listBox_unselect.Items.AddRange(MonHoc_CNTT.ToArray());
                        break;
                    case "Hệ thống Thông tin":
                        listBox_unselect.Items.AddRange(MonHoc_HTTT.ToArray());
                        break;
                    case "Khoa học Máy tính":
                        listBox_unselect.Items.AddRange(MonHoc_KHMT.ToArray());
                        break;
                    case "Kỹ thuật Phần mềm":
                        listBox_unselect.Items.AddRange(MonHoc_KTPM.ToArray());
                        break;
                    case "Kỹ thuật Máy tính":
                        listBox_unselect.Items.AddRange(MonHoc_KTMT.ToArray());
                        break;
                    case "Mạng máy tính & Truyền thông Dữ liệu":
                        listBox_unselect.Items.AddRange(MonHoc_MMTTT.ToArray());
                        break;
                    case "An toàn Thông tin":
                        listBox_unselect.Items.AddRange(MonHoc_ATTT.ToArray());
                        break;
                    case "Thương mại Điện tử":
                        listBox_unselect.Items.AddRange(MonHoc_TMDT.ToArray());
                        break;
                    case "Khoa học Dữ liệu":
                        listBox_unselect.Items.AddRange(MonHoc_KHDL.ToArray());
                        break;
                    case "Trí tuệ Nhân tạo":
                        listBox_unselect.Items.AddRange(MonHoc_TTNT.ToArray());
                        break;
                    case "Thiết kế Vi mạch":
                        listBox_unselect.Items.AddRange(MonHoc_TKVM.ToArray());
                        break;
                default:
                        break;
            
            }
        }

    }
}
