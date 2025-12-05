namespace Bai06
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox_copy = new System.Windows.Forms.GroupBox();
            this.button_Copy = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_dest = new System.Windows.Forms.Button();
            this.label_dest = new System.Windows.Forms.Label();
            this.textBox_dest = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_dlgFile = new System.Windows.Forms.Button();
            this.label_src = new System.Windows.Forms.Label();
            this.textBox_src = new System.Windows.Forms.TextBox();
            this.groupBox_ProgressBar = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker_Copy = new System.ComponentModel.BackgroundWorker();
            this.toolTip_Status = new System.Windows.Forms.ToolTip(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.toolStrip_Status = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel_Status = new System.Windows.Forms.ToolStripLabel();
            this.groupBox_copy.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox_ProgressBar.SuspendLayout();
            this.toolStrip_Status.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_copy
            // 
            this.groupBox_copy.Controls.Add(this.button_Copy);
            this.groupBox_copy.Controls.Add(this.panel2);
            this.groupBox_copy.Controls.Add(this.panel1);
            this.groupBox_copy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_copy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox_copy.Location = new System.Drawing.Point(12, 33);
            this.groupBox_copy.Name = "groupBox_copy";
            this.groupBox_copy.Size = new System.Drawing.Size(744, 206);
            this.groupBox_copy.TabIndex = 0;
            this.groupBox_copy.TabStop = false;
            this.groupBox_copy.Text = "Sao chép tập tin";
            // 
            // button_Copy
            // 
            this.button_Copy.BackColor = System.Drawing.SystemColors.Control;
            this.button_Copy.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_Copy.ForeColor = System.Drawing.Color.Black;
            this.button_Copy.Location = new System.Drawing.Point(229, 162);
            this.button_Copy.Name = "button_Copy";
            this.button_Copy.Size = new System.Drawing.Size(151, 28);
            this.button_Copy.TabIndex = 3;
            this.button_Copy.Text = "Sao chép";
            this.button_Copy.UseVisualStyleBackColor = false;
            this.button_Copy.Click += new System.EventHandler(this.button_Copy_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button_dest);
            this.panel2.Controls.Add(this.label_dest);
            this.panel2.Controls.Add(this.textBox_dest);
            this.panel2.Location = new System.Drawing.Point(22, 99);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(716, 41);
            this.panel2.TabIndex = 2;
            // 
            // button_dest
            // 
            this.button_dest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_dest.ForeColor = System.Drawing.Color.Black;
            this.button_dest.Location = new System.Drawing.Point(670, 4);
            this.button_dest.Name = "button_dest";
            this.button_dest.Size = new System.Drawing.Size(32, 27);
            this.button_dest.TabIndex = 1;
            this.button_dest.Text = "...";
            this.button_dest.UseVisualStyleBackColor = true;
            this.button_dest.Click += new System.EventHandler(this.button_dest_Click);
            // 
            // label_dest
            // 
            this.label_dest.AutoSize = true;
            this.label_dest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_dest.ForeColor = System.Drawing.Color.Black;
            this.label_dest.Location = new System.Drawing.Point(3, 6);
            this.label_dest.Name = "label_dest";
            this.label_dest.Size = new System.Drawing.Size(182, 20);
            this.label_dest.TabIndex = 0;
            this.label_dest.Text = "Đường dẫn thư mục đích";
            // 
            // textBox_dest
            // 
            this.textBox_dest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_dest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_dest.Location = new System.Drawing.Point(207, 4);
            this.textBox_dest.Name = "textBox_dest";
            this.textBox_dest.ReadOnly = true;
            this.textBox_dest.Size = new System.Drawing.Size(457, 26);
            this.textBox_dest.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_dlgFile);
            this.panel1.Controls.Add(this.label_src);
            this.panel1.Controls.Add(this.textBox_src);
            this.panel1.Location = new System.Drawing.Point(22, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(716, 41);
            this.panel1.TabIndex = 1;
            // 
            // button_dlgFile
            // 
            this.button_dlgFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_dlgFile.ForeColor = System.Drawing.Color.Black;
            this.button_dlgFile.Location = new System.Drawing.Point(670, 4);
            this.button_dlgFile.Name = "button_dlgFile";
            this.button_dlgFile.Size = new System.Drawing.Size(32, 27);
            this.button_dlgFile.TabIndex = 1;
            this.button_dlgFile.Text = "...";
            this.button_dlgFile.UseVisualStyleBackColor = true;
            this.button_dlgFile.Click += new System.EventHandler(this.button_src_Click);
            // 
            // label_src
            // 
            this.label_src.AutoSize = true;
            this.label_src.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_src.ForeColor = System.Drawing.Color.Black;
            this.label_src.Location = new System.Drawing.Point(3, 6);
            this.label_src.Name = "label_src";
            this.label_src.Size = new System.Drawing.Size(198, 20);
            this.label_src.TabIndex = 0;
            this.label_src.Text = "Đường dẫn thư mục nguồn";
            // 
            // textBox_src
            // 
            this.textBox_src.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_src.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_src.Location = new System.Drawing.Point(207, 4);
            this.textBox_src.Name = "textBox_src";
            this.textBox_src.ReadOnly = true;
            this.textBox_src.Size = new System.Drawing.Size(457, 26);
            this.textBox_src.TabIndex = 0;
            // 
            // groupBox_ProgressBar
            // 
            this.groupBox_ProgressBar.Controls.Add(this.progressBar1);
            this.groupBox_ProgressBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_ProgressBar.ForeColor = System.Drawing.Color.Blue;
            this.groupBox_ProgressBar.Location = new System.Drawing.Point(12, 261);
            this.groupBox_ProgressBar.Name = "groupBox_ProgressBar";
            this.groupBox_ProgressBar.Size = new System.Drawing.Size(744, 70);
            this.groupBox_ProgressBar.TabIndex = 1;
            this.groupBox_ProgressBar.TabStop = false;
            this.groupBox_ProgressBar.Text = "Tiến trình sao chép";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(29, 22);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(695, 26);
            this.progressBar1.TabIndex = 0;
            // 
            // backgroundWorker_Copy
            // 
            this.backgroundWorker_Copy.WorkerReportsProgress = true;
            this.backgroundWorker_Copy.WorkerSupportsCancellation = true;
            this.backgroundWorker_Copy.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_Copy_DoWork);
            this.backgroundWorker_Copy.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_Copy_ProgressChanged);
            this.backgroundWorker_Copy.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_Copy_RunWorkerCompleted);
            // 
            // toolStrip_Status
            // 
            this.toolStrip_Status.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip_Status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel_Status});
            this.toolStrip_Status.Location = new System.Drawing.Point(0, 346);
            this.toolStrip_Status.Name = "toolStrip_Status";
            this.toolStrip_Status.Size = new System.Drawing.Size(762, 25);
            this.toolStrip_Status.TabIndex = 2;
            this.toolStrip_Status.Text = "dasdsadsa";
            // 
            // toolStripLabel_Status
            // 
            this.toolStripLabel_Status.Name = "toolStripLabel_Status";
            this.toolStripLabel_Status.Size = new System.Drawing.Size(91, 22);
            this.toolStripLabel_Status.Text = "Đang sao chép: ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 371);
            this.Controls.Add(this.toolStrip_Status);
            this.Controls.Add(this.groupBox_ProgressBar);
            this.Controls.Add(this.groupBox_copy);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Copy";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.groupBox_copy.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox_ProgressBar.ResumeLayout(false);
            this.toolStrip_Status.ResumeLayout(false);
            this.toolStrip_Status.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_copy;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_dlgFile;
        private System.Windows.Forms.Label label_src;
        private System.Windows.Forms.TextBox textBox_src;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_dest;
        private System.Windows.Forms.Label label_dest;
        private System.Windows.Forms.TextBox textBox_dest;
        private System.Windows.Forms.Button button_Copy;
        private System.Windows.Forms.GroupBox groupBox_ProgressBar;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.ComponentModel.BackgroundWorker backgroundWorker_Copy;
        private System.Windows.Forms.ToolTip toolTip_Status;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStrip toolStrip_Status;
        private System.Windows.Forms.ToolStripLabel toolStripLabel_Status;
    }
}

