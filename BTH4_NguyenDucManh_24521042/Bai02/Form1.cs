using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai02
{
    public partial class Form1 : Form
    {
        DateTime nowTime = DateTime.Now;
        StringFormat myFormat = new StringFormat();
        Font myFont = new Font("Times new roman", 14, FontStyle.Regular);
        public Form1()
        {
            this.DoubleBuffered = true;
            InitializeComponent();
            //Căn lề ở giữa
            myFormat.Alignment = StringAlignment.Center;
            myFormat.LineAlignment = StringAlignment.Center;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            nowTime = DateTime.Now;
            this.Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawString(nowTime.ToString("dddd, MMMM dd, yyyy hh:mm:ss tt"), myFont
                , Brushes.Black, this.ClientRectangle, myFormat);
        }
    }
}
