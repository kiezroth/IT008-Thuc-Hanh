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
        Label textPaint = new Label();
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
            textPaint.Text = "Paint Event";
            this.Controls.Add(textPaint);

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            int x = random.Next(this.ClientSize.Width - textPaint.Width);
            int y = random.Next(this.ClientSize.Height - textPaint.Height);
            textPaint.Location = new Point(x, y);
        }
    }
}
