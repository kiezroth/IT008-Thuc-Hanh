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
    public partial class myForm : Form
    {
        private int countLoad = 0;
        private int countActivated = 0;
        private int countDeactivated = 0;
        private int countResize = 0;
        private int countMove = 0;
        private int countShow = 0;
        private int countPaint = 0;
        private List<Label> myStatus = new List<Label>(7);

        public myForm()
        {
            InitializeComponent();
            Load += myForm_Load;
            Activated += myForm_Activated;
            Deactivate += MyForm_Deactivate;
            Resize += myForm_Resize;
            Move += myForm_Move;
            Shown += myForm_Shown;
            Paint += MyForm_Paint;
            FormClosing += myForm_Closing;
            FormClosed += myForm_Closed;
            VisibleChanged += myForm_changeVisible;

            Button visibleChange = new Button();
            LabelFlowPanel.Controls.Add(visibleChange);
            visibleChange.Text = "Ẩn form";
            visibleChange.Click += new EventHandler(myForm_button);


            //Label status
            Label cLoad = new Label(),
                  cActivated = new Label(),
                  cDeactivated = new Label(),
                  cResize = new Label(),
                  cMove = new Label(),
                  cShow = new Label(),
                  cPaint = new Label();
            for (int i = 0; i < 7; i++)
            {
                myStatus.Add(new Label());
                myStatus[i].AutoSize = true;
            }


            LabelFlowPanel.AutoSize = true;
            LabelFlowPanel.FlowDirection = FlowDirection.TopDown;
            foreach(var item in myStatus)
                LabelFlowPanel.Controls.Add(item);


            //View status
            Timer updateLabel = new Timer();
            updateLabel.Interval = 500;
            updateLabel.Tick += myUpdateLabel;
            updateLabel.Start();
            
        }
        private void myUpdateLabel(object sender, EventArgs e)
        {
            myStatus[0].Text = $"Số lần form load: {countLoad}";
            myStatus[1].Text = $"Số lần form activate: {countActivated}";
            myStatus[2].Text = $"Số lần form deactivate: {countDeactivated}";
            myStatus[3].Text = $"Số lần form resize: {countResize}";
            myStatus[4].Text = $"Số lần form move: {countMove}";
            myStatus[5].Text = $"Số lần form show: {countShow}";
            myStatus[6].Text = $"Số lần form paint: {countPaint}";
            this.Update();
        }
        private void myForm_Load(object sender, EventArgs e)
        {
            countLoad++;
            MessageBox.Show("This form Load");
        }

        private void myForm_Activated(object sender, EventArgs e)
        {
            countActivated++;
        }
        private void MyForm_Deactivate(object sender, EventArgs e)
        {
            countDeactivated++;
        }
        private void myForm_Resize(object sender, EventArgs e)
        {
            countResize++;
        }
        private void myForm_Move(object sender, EventArgs e)
        {
            countMove++;
        }
        private void myForm_Shown(object sender, EventArgs e)
        {
            MessageBox.Show("This form Show");
            countShow++;
        }
        private void myForm_button(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn có chắc muốn ẩn form trong 3 giây không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                this.Visible = false;
                Timer t = new Timer();
                t.Interval = 3000;
                t.Tick += myTimer_toChangeVisible;
                t.Start();

            }
        }

        private void myTimer_toChangeVisible(object sender, EventArgs e)
        {
            this.Visible = true;
            (sender as Timer).Stop();
        }
        private void myForm_changeVisible(object sender, EventArgs e)
        {
            MessageBox.Show("Form này sẽ được ẩn/hiện");
        }

        private void MyForm_Paint(object sender, PaintEventArgs e)
        {
            countPaint++;
        }
        private void myForm_Closing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("This form is closing");
        }

        private void myForm_Closed(object sender, EventArgs e)
        {
            MessageBox.Show("This form closed");
        }
        
    }
}
