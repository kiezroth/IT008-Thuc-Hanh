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

namespace Bai05
{
    public partial class AddSV : Form
    {
        public string mssv, ten, khoa;
        public float dtb;
        Regex reg1 = new Regex(@"^\d{1,8}$");
        Regex reg2 = new Regex(@"^[a-zA-Z\s\u00C0-\u1EF9]+$");
        Regex reg3 = new Regex(@"^(10(\.0+)?|(\d(\.\d+)?))$");
        public AddSV()
        {
            InitializeComponent();
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            if (!reg1.Match(textBox1.Text).Success || !reg2.Match(textBox2.Text).Success || !reg3.Match(textBox3.Text).Success)
            {
                MessageBox.Show("Thông tin nhập không hợp lệ"
                    + "\n(Mã số sinh viên gồm 8 chữ số)" +
                    "\n(Tên chỉ bao gôm chữ cái)" +
                    "\n(Điểm nằm trong khoảng (0,10)", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            mssv = textBox1.Text;
            ten = textBox2.Text;
            khoa = comboBox1.Text;
            dtb = float.Parse(textBox3.Text);
            DialogResult = DialogResult.OK;
        }
        private void button_Exit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
