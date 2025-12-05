using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Tọa độ chuột:" +
                "\nX = " + e.X.ToString() +
                "\nY = " + e.Y.ToString());
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            string keyString = e.KeyCode.ToString();
            int keyvalue = e.KeyValue;
            MessageBox.Show("Phím " + keyString + "\n(ASCII: " + keyvalue.ToString() + ")");
        }
    }
}
