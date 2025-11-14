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
    public partial class Form1 : Form
    {
        Regex numReg = new Regex("^[+-]?\\d+(\\.\\d+)?$");
        ToolTip noNumber1 = new ToolTip();
        ToolTip noNumber2 = new ToolTip();

        public Form1()
        {
            InitializeComponent();
            noNumber1.ToolTipTitle = "Lỗi";
            noNumber1.ToolTipIcon = ToolTipIcon.Error;
            noNumber2.ToolTipTitle = "Lỗi";
            noNumber2.ToolTipIcon = ToolTipIcon.Error;
           

        }
        private bool button_CheckValid()
        {
            string n1 = textBox_Number1.Text;
            string n2 = textBox_Number2.Text;
            Match match1 = numReg.Match(n1);
            Match match2 = numReg.Match(n2);
            bool isValid = true;
            if (!match1.Success || !(match1.Value.Length == n1.Length))
            {
                noNumber1.Show("Dữ liệu không hợp lệ", textBox_Number1, textBox_Number2.Width, 0, 2000);
                isValid = false;
            }
            if (!match2.Success || !(match2.Value.Length == n2.Length))
            {
                noNumber2.Show("Dữ liệu không hợp lệ", textBox_Number2, textBox_Number2.Width, 0, 2000);
                isValid = false;
            }
            return isValid;
        }
        private void button_Plus_Click(object sender, EventArgs e)
        {
            if (button_CheckValid())
            {
                double n1 = double.Parse(textBox_Number1.Text);
                double n2 = double.Parse(textBox_Number2.Text);
                string ans = (n1 + n2).ToString();
                textBox_Answer.Text = ans;
            }
        }

        private void button_Sub_Click(object sender, EventArgs e)
        {
            if (button_CheckValid())
            {
                double n1 = double.Parse(textBox_Number1.Text);
                double n2 = double.Parse(textBox_Number2.Text);
                string ans = (n1 - n2).ToString();
                textBox_Answer.Text = ans;
            }
        }

        private void button_Mult_Click(object sender, EventArgs e)
        {
            if (button_CheckValid())
            {
                double n1 = double.Parse(textBox_Number1.Text);
                double n2 = double.Parse(textBox_Number2.Text);
                string ans = (n1 * n2).ToString();
                textBox_Answer.Text = ans;
            }
        }

        private void button_Div_Click(object sender, EventArgs e)
        {
            if (button_CheckValid())
            {
                double n1 = double.Parse(textBox_Number1.Text);
                double n2 = double.Parse(textBox_Number2.Text);
                if (n2 == 0)
                {
                    noNumber2.Show("Không thể chia cho 0", textBox_Number2, textBox_Number2.Width, 0, 2000);
                    return;
                }
                string ans = (n1 / n2).ToString();
                textBox_Answer.Text = ans;
            }
        }
    }
}
