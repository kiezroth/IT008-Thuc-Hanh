using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai06
{
    public partial class myMessageBox : Form
    {
        public enum DlgRes
        {
            None,
            Overwrite,
            OverwriteALL,
            Skip,
            SkipAll
        }
        public DlgRes choice = DlgRes.None;
        public myMessageBox(string filename)
        {
            InitializeComponent();
            label2.Text = filename;
            button1.DialogResult = DialogResult.OK;
            button2.DialogResult = DialogResult.OK;
            button3.DialogResult = DialogResult.OK;
            button4.DialogResult = DialogResult.OK;

            button1.Click += (s, e) => { choice = DlgRes.Overwrite; Close(); };
            button2.Click += (s, e) => { choice = DlgRes.OverwriteALL; Close(); };
            button3.Click += (s, e) => { choice = DlgRes.Skip; Close(); };
            button4.Click += (s, e) => { choice = DlgRes.SkipAll ; Close(); };
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (choice == DlgRes.None) 
            {
                e.Cancel = true;        
                return;
            }
            base.OnFormClosing(e);
        }
    }
}
