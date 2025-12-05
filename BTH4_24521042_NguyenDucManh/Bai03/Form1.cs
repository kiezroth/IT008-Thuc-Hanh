using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Timelabel.Text = "Hôm nay là ngày " + DateTime.Now.ToString("dd/MM/yyyy") + " - Bây giờ là " + DateTime.Now.ToString("hh:mm:ss tt");
            this.Invalidate();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Media Files (*.avi;*.mpeg;*.wav;*.midi;*.mp4;*.mp3)|*.avi;*.mpeg;*.wav;*.midi;*.mp4;*.mp3|All Files (*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                axWindowsMediaPlayer1.URL = ofd.FileName;
                axWindowsMediaPlayer1.stretchToFit = true;
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
        }
    }
}
