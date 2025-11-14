using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        enum Status
        {
            Empty,
            Selected,
            Sold
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var p in flowLayoutPanel_Seat.Controls)
            {
                if (p is Button button)
                {
                    button.BackColor = Color.White;
                    button.Tag = Status.Empty;
                    button.Click += Seat_Click;
                }
            }
        }
        private void Seat_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            Status status = (Status)btn.Tag;

            switch (status)
            {
                case Status.Empty:
                    btn.BackColor = Color.Blue;
                    btn.Tag = Status.Selected;
                    break;

                case Status.Selected:
                    btn.BackColor = Color.White;
                    btn.Tag = Status.Empty;
                    break;

                case Status.Sold:
                    MessageBox.Show("Ghế này đã được bán!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
        }

        private void button_Select_Click(object sender, EventArgs e)
        {
            int total = 0;

            foreach (var p in flowLayoutPanel_Seat.Controls)
            {
                if (p is Button button && (Status)button.Tag == Status.Selected)
                {
                    button.BackColor = Color.Yellow;
                    button.Tag = Status.Sold;

                    int seatNumber = int.Parse(button.Text);
                    if (seatNumber <= 5)
                        total += 5000;
                    else if (seatNumber <= 10)
                        total += 6500;
                    else
                        total += 8000;
                }
            }
            textBox_ThanhTien.Text = total.ToString();
        }

        private void button_deselect_Click(object sender, EventArgs e)
        {
            foreach (var p in flowLayoutPanel_Seat.Controls)
            {
                if (p is Button btn && (Status)btn.Tag == Status.Selected)
                {
                    btn.BackColor = Color.White;
                    btn.Tag = Status.Empty;
                }
            }

            textBox_ThanhTien.Text = "0";
        }

        private void button_Done_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
