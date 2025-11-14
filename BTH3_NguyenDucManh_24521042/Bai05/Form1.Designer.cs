namespace Bai05
{
    partial class Form1
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox_Number2 = new System.Windows.Forms.TextBox();
            this.label_Number2 = new System.Windows.Forms.Label();
            this.button_Plus = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button_Sub = new System.Windows.Forms.Button();
            this.button_Mult = new System.Windows.Forms.Button();
            this.button_Div = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox_Answer = new System.Windows.Forms.TextBox();
            this.label_Answer = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_Number1 = new System.Windows.Forms.TextBox();
            this.label_Number1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox_Number2);
            this.panel2.Controls.Add(this.label_Number2);
            this.panel2.Location = new System.Drawing.Point(3, 83);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(511, 50);
            this.panel2.TabIndex = 2;
            // 
            // textBox_Number2
            // 
            this.textBox_Number2.Dock = System.Windows.Forms.DockStyle.Right;
            this.textBox_Number2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Number2.Location = new System.Drawing.Point(115, 0);
            this.textBox_Number2.Name = "textBox_Number2";
            this.textBox_Number2.Size = new System.Drawing.Size(396, 26);
            this.textBox_Number2.TabIndex = 1;
            // 
            // label_Number2
            // 
            this.label_Number2.AutoSize = true;
            this.label_Number2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label_Number2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Number2.Location = new System.Drawing.Point(0, 0);
            this.label_Number2.Name = "label_Number2";
            this.label_Number2.Size = new System.Drawing.Size(94, 24);
            this.label_Number2.TabIndex = 0;
            this.label_Number2.Text = "Number 2";
            // 
            // button_Plus
            // 
            this.button_Plus.AutoSize = true;
            this.button_Plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Plus.Location = new System.Drawing.Point(3, 3);
            this.button_Plus.Name = "button_Plus";
            this.button_Plus.Size = new System.Drawing.Size(60, 50);
            this.button_Plus.TabIndex = 3;
            this.button_Plus.Text = "+";
            this.button_Plus.UseVisualStyleBackColor = true;
            this.button_Plus.Click += new System.EventHandler(this.button_Plus_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.button_Plus);
            this.flowLayoutPanel1.Controls.Add(this.button_Sub);
            this.flowLayoutPanel1.Controls.Add(this.button_Mult);
            this.flowLayoutPanel1.Controls.Add(this.button_Div);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 151);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(511, 62);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // button_Sub
            // 
            this.button_Sub.AutoSize = true;
            this.button_Sub.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Sub.Location = new System.Drawing.Point(69, 3);
            this.button_Sub.Name = "button_Sub";
            this.button_Sub.Size = new System.Drawing.Size(60, 50);
            this.button_Sub.TabIndex = 4;
            this.button_Sub.Text = "-";
            this.button_Sub.UseVisualStyleBackColor = true;
            this.button_Sub.Click += new System.EventHandler(this.button_Sub_Click);
            // 
            // button_Mult
            // 
            this.button_Mult.AutoSize = true;
            this.button_Mult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Mult.Location = new System.Drawing.Point(135, 3);
            this.button_Mult.Name = "button_Mult";
            this.button_Mult.Size = new System.Drawing.Size(60, 50);
            this.button_Mult.TabIndex = 5;
            this.button_Mult.Text = "X";
            this.button_Mult.UseVisualStyleBackColor = true;
            this.button_Mult.Click += new System.EventHandler(this.button_Mult_Click);
            // 
            // button_Div
            // 
            this.button_Div.AutoSize = true;
            this.button_Div.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Div.Location = new System.Drawing.Point(201, 3);
            this.button_Div.Name = "button_Div";
            this.button_Div.Size = new System.Drawing.Size(60, 50);
            this.button_Div.TabIndex = 6;
            this.button_Div.Text = "/";
            this.button_Div.UseVisualStyleBackColor = true;
            this.button_Div.Click += new System.EventHandler(this.button_Div_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.textBox_Answer);
            this.panel3.Controls.Add(this.label_Answer);
            this.panel3.Location = new System.Drawing.Point(3, 231);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(511, 50);
            this.panel3.TabIndex = 5;
            // 
            // textBox_Answer
            // 
            this.textBox_Answer.BackColor = System.Drawing.Color.White;
            this.textBox_Answer.Dock = System.Windows.Forms.DockStyle.Right;
            this.textBox_Answer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Answer.Location = new System.Drawing.Point(115, 0);
            this.textBox_Answer.Name = "textBox_Answer";
            this.textBox_Answer.ReadOnly = true;
            this.textBox_Answer.Size = new System.Drawing.Size(396, 26);
            this.textBox_Answer.TabIndex = 1;
            // 
            // label_Answer
            // 
            this.label_Answer.AutoSize = true;
            this.label_Answer.Dock = System.Windows.Forms.DockStyle.Left;
            this.label_Answer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Answer.Location = new System.Drawing.Point(0, 0);
            this.label_Answer.Name = "label_Answer";
            this.label_Answer.Size = new System.Drawing.Size(74, 24);
            this.label_Answer.TabIndex = 0;
            this.label_Answer.Text = "Answer";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.panel1);
            this.flowLayoutPanel2.Controls.Add(this.panel2);
            this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanel1);
            this.flowLayoutPanel2.Controls.Add(this.panel3);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(65, 51);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(517, 303);
            this.flowLayoutPanel2.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox_Number1);
            this.panel1.Controls.Add(this.label_Number1);
            this.panel1.Location = new System.Drawing.Point(3, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(511, 50);
            this.panel1.TabIndex = 3;
            // 
            // textBox_Number1
            // 
            this.textBox_Number1.Dock = System.Windows.Forms.DockStyle.Right;
            this.textBox_Number1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Number1.Location = new System.Drawing.Point(115, 0);
            this.textBox_Number1.Name = "textBox_Number1";
            this.textBox_Number1.Size = new System.Drawing.Size(396, 26);
            this.textBox_Number1.TabIndex = 1;
            // 
            // label_Number1
            // 
            this.label_Number1.AutoSize = true;
            this.label_Number1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label_Number1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Number1.Location = new System.Drawing.Point(0, 0);
            this.label_Number1.Name = "label_Number1";
            this.label_Number1.Size = new System.Drawing.Size(94, 24);
            this.label_Number1.TabIndex = 0;
            this.label_Number1.Text = "Number 1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox_Number2;
        private System.Windows.Forms.Label label_Number2;
        private System.Windows.Forms.Button button_Plus;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button_Sub;
        private System.Windows.Forms.Button button_Mult;
        private System.Windows.Forms.Button button_Div;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox_Answer;
        private System.Windows.Forms.Label label_Answer;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox_Number1;
        private System.Windows.Forms.Label label_Number1;
    }
}

