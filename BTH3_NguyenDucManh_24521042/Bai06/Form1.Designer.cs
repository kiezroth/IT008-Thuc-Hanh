namespace Bai06
{
    partial class Calculator
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
            this.Result_TextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.button_backSpace = new System.Windows.Forms.Button();
            this.button_ClearEntry = new System.Windows.Forms.Button();
            this.button_Clear = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.button_7 = new System.Windows.Forms.Button();
            this.button_8 = new System.Windows.Forms.Button();
            this.button_9 = new System.Windows.Forms.Button();
            this.button_Div = new System.Windows.Forms.Button();
            this.button_Sqrt = new System.Windows.Forms.Button();
            this.button_4 = new System.Windows.Forms.Button();
            this.button_5 = new System.Windows.Forms.Button();
            this.button_6 = new System.Windows.Forms.Button();
            this.button_Mult = new System.Windows.Forms.Button();
            this.button_div100 = new System.Windows.Forms.Button();
            this.button_1 = new System.Windows.Forms.Button();
            this.button_2 = new System.Windows.Forms.Button();
            this.button_3 = new System.Windows.Forms.Button();
            this.button_sub = new System.Windows.Forms.Button();
            this.button_Reversion = new System.Windows.Forms.Button();
            this.button_0 = new System.Windows.Forms.Button();
            this.button_PosNeg = new System.Windows.Forms.Button();
            this.button_dot = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            this.button_Equal = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button_memoryClear = new System.Windows.Forms.Button();
            this.button_memoryRecall = new System.Windows.Forms.Button();
            this.button_memoryStore = new System.Windows.Forms.Button();
            this.button_memoryAdd = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Result_TextBox
            // 
            this.Result_TextBox.BackColor = System.Drawing.Color.White;
            this.Result_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Result_TextBox.Location = new System.Drawing.Point(12, 13);
            this.Result_TextBox.Name = "Result_TextBox";
            this.Result_TextBox.ReadOnly = true;
            this.Result_TextBox.Size = new System.Drawing.Size(358, 26);
            this.Result_TextBox.TabIndex = 1;
            this.Result_TextBox.Text = "0";
            this.Result_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flowLayoutPanel3);
            this.panel1.Controls.Add(this.flowLayoutPanel2);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(13, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(357, 280);
            this.panel1.TabIndex = 2;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.button_backSpace);
            this.flowLayoutPanel3.Controls.Add(this.button_ClearEntry);
            this.flowLayoutPanel3.Controls.Add(this.button_Clear);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(67, 4);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(285, 40);
            this.flowLayoutPanel3.TabIndex = 2;
            // 
            // button_backSpace
            // 
            this.button_backSpace.Location = new System.Drawing.Point(5, 3);
            this.button_backSpace.Margin = new System.Windows.Forms.Padding(5, 3, 0, 0);
            this.button_backSpace.Name = "button_backSpace";
            this.button_backSpace.Size = new System.Drawing.Size(90, 32);
            this.button_backSpace.TabIndex = 1;
            this.button_backSpace.Text = "Backspace";
            this.button_backSpace.UseVisualStyleBackColor = true;
            this.button_backSpace.Click += new System.EventHandler(this.button_Backspace_Click);
            // 
            // button_ClearEntry
            // 
            this.button_ClearEntry.Location = new System.Drawing.Point(100, 5);
            this.button_ClearEntry.Margin = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.button_ClearEntry.Name = "button_ClearEntry";
            this.button_ClearEntry.Size = new System.Drawing.Size(90, 32);
            this.button_ClearEntry.TabIndex = 2;
            this.button_ClearEntry.Text = "CE";
            this.button_ClearEntry.UseVisualStyleBackColor = true;
            this.button_ClearEntry.Click += new System.EventHandler(this.button_ClearEntry_Click);
            // 
            // button_Clear
            // 
            this.button_Clear.Location = new System.Drawing.Point(195, 5);
            this.button_Clear.Margin = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(90, 32);
            this.button_Clear.TabIndex = 3;
            this.button_Clear.Text = "C";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.button_7);
            this.flowLayoutPanel2.Controls.Add(this.button_8);
            this.flowLayoutPanel2.Controls.Add(this.button_9);
            this.flowLayoutPanel2.Controls.Add(this.button_Div);
            this.flowLayoutPanel2.Controls.Add(this.button_Sqrt);
            this.flowLayoutPanel2.Controls.Add(this.button_4);
            this.flowLayoutPanel2.Controls.Add(this.button_5);
            this.flowLayoutPanel2.Controls.Add(this.button_6);
            this.flowLayoutPanel2.Controls.Add(this.button_Mult);
            this.flowLayoutPanel2.Controls.Add(this.button_div100);
            this.flowLayoutPanel2.Controls.Add(this.button_1);
            this.flowLayoutPanel2.Controls.Add(this.button_2);
            this.flowLayoutPanel2.Controls.Add(this.button_3);
            this.flowLayoutPanel2.Controls.Add(this.button_sub);
            this.flowLayoutPanel2.Controls.Add(this.button_Reversion);
            this.flowLayoutPanel2.Controls.Add(this.button_0);
            this.flowLayoutPanel2.Controls.Add(this.button_PosNeg);
            this.flowLayoutPanel2.Controls.Add(this.button_dot);
            this.flowLayoutPanel2.Controls.Add(this.button_Add);
            this.flowLayoutPanel2.Controls.Add(this.button_Equal);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(67, 47);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(285, 230);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // button_7
            // 
            this.button_7.Location = new System.Drawing.Point(5, 5);
            this.button_7.Margin = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.button_7.Name = "button_7";
            this.button_7.Size = new System.Drawing.Size(50, 50);
            this.button_7.TabIndex = 0;
            this.button_7.Text = "7";
            this.button_7.UseVisualStyleBackColor = true;
            this.button_7.Click += new System.EventHandler(this.button_7_Click);
            // 
            // button_8
            // 
            this.button_8.Location = new System.Drawing.Point(60, 5);
            this.button_8.Margin = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.button_8.Name = "button_8";
            this.button_8.Size = new System.Drawing.Size(50, 50);
            this.button_8.TabIndex = 1;
            this.button_8.Text = "8";
            this.button_8.UseVisualStyleBackColor = true;
            this.button_8.Click += new System.EventHandler(this.button_8_Click);
            // 
            // button_9
            // 
            this.button_9.Location = new System.Drawing.Point(115, 5);
            this.button_9.Margin = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.button_9.Name = "button_9";
            this.button_9.Size = new System.Drawing.Size(50, 50);
            this.button_9.TabIndex = 2;
            this.button_9.Text = "9";
            this.button_9.UseVisualStyleBackColor = true;
            this.button_9.Click += new System.EventHandler(this.button_9_Click);
            // 
            // button_Div
            // 
            this.button_Div.Location = new System.Drawing.Point(170, 5);
            this.button_Div.Margin = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.button_Div.Name = "button_Div";
            this.button_Div.Size = new System.Drawing.Size(50, 50);
            this.button_Div.TabIndex = 3;
            this.button_Div.Text = "/";
            this.button_Div.UseVisualStyleBackColor = true;
            this.button_Div.Click += new System.EventHandler(this.button_Div_Click);
            // 
            // button_Sqrt
            // 
            this.button_Sqrt.Location = new System.Drawing.Point(225, 5);
            this.button_Sqrt.Margin = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.button_Sqrt.Name = "button_Sqrt";
            this.button_Sqrt.Size = new System.Drawing.Size(50, 50);
            this.button_Sqrt.TabIndex = 4;
            this.button_Sqrt.Text = "sqrt";
            this.button_Sqrt.UseVisualStyleBackColor = true;
            this.button_Sqrt.Click += new System.EventHandler(this.button_Sqrt_Click);
            // 
            // button_4
            // 
            this.button_4.Location = new System.Drawing.Point(5, 60);
            this.button_4.Margin = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.button_4.Name = "button_4";
            this.button_4.Size = new System.Drawing.Size(50, 50);
            this.button_4.TabIndex = 5;
            this.button_4.Text = "4";
            this.button_4.UseVisualStyleBackColor = true;
            this.button_4.Click += new System.EventHandler(this.button_4_Click);
            // 
            // button_5
            // 
            this.button_5.Location = new System.Drawing.Point(60, 60);
            this.button_5.Margin = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.button_5.Name = "button_5";
            this.button_5.Size = new System.Drawing.Size(50, 50);
            this.button_5.TabIndex = 6;
            this.button_5.Text = "5";
            this.button_5.UseVisualStyleBackColor = true;
            this.button_5.Click += new System.EventHandler(this.button_5_Click);
            // 
            // button_6
            // 
            this.button_6.Location = new System.Drawing.Point(115, 60);
            this.button_6.Margin = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.button_6.Name = "button_6";
            this.button_6.Size = new System.Drawing.Size(50, 50);
            this.button_6.TabIndex = 7;
            this.button_6.Text = "6";
            this.button_6.UseVisualStyleBackColor = true;
            this.button_6.Click += new System.EventHandler(this.button_6_Click);
            // 
            // button_Mult
            // 
            this.button_Mult.Location = new System.Drawing.Point(170, 60);
            this.button_Mult.Margin = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.button_Mult.Name = "button_Mult";
            this.button_Mult.Size = new System.Drawing.Size(50, 50);
            this.button_Mult.TabIndex = 8;
            this.button_Mult.Text = "*";
            this.button_Mult.UseVisualStyleBackColor = true;
            this.button_Mult.Click += new System.EventHandler(this.button_Mult_Click);
            // 
            // button_div100
            // 
            this.button_div100.Location = new System.Drawing.Point(225, 60);
            this.button_div100.Margin = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.button_div100.Name = "button_div100";
            this.button_div100.Size = new System.Drawing.Size(50, 50);
            this.button_div100.TabIndex = 9;
            this.button_div100.Text = "%";
            this.button_div100.UseVisualStyleBackColor = true;
            this.button_div100.Click += new System.EventHandler(this.button_div100_Click);
            // 
            // button_1
            // 
            this.button_1.Location = new System.Drawing.Point(5, 115);
            this.button_1.Margin = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.button_1.Name = "button_1";
            this.button_1.Size = new System.Drawing.Size(50, 50);
            this.button_1.TabIndex = 10;
            this.button_1.Text = "1";
            this.button_1.UseVisualStyleBackColor = true;
            this.button_1.Click += new System.EventHandler(this.button_1_Click);
            // 
            // button_2
            // 
            this.button_2.Location = new System.Drawing.Point(60, 115);
            this.button_2.Margin = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.button_2.Name = "button_2";
            this.button_2.Size = new System.Drawing.Size(50, 50);
            this.button_2.TabIndex = 11;
            this.button_2.Text = "2";
            this.button_2.UseVisualStyleBackColor = true;
            this.button_2.Click += new System.EventHandler(this.button_2_Click);
            // 
            // button_3
            // 
            this.button_3.Location = new System.Drawing.Point(115, 115);
            this.button_3.Margin = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.button_3.Name = "button_3";
            this.button_3.Size = new System.Drawing.Size(50, 50);
            this.button_3.TabIndex = 12;
            this.button_3.Text = "3";
            this.button_3.UseVisualStyleBackColor = true;
            this.button_3.Click += new System.EventHandler(this.button_3_Click);
            // 
            // button_sub
            // 
            this.button_sub.Location = new System.Drawing.Point(170, 115);
            this.button_sub.Margin = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.button_sub.Name = "button_sub";
            this.button_sub.Size = new System.Drawing.Size(50, 50);
            this.button_sub.TabIndex = 13;
            this.button_sub.Text = "-";
            this.button_sub.UseVisualStyleBackColor = true;
            this.button_sub.Click += new System.EventHandler(this.button_sub_Click);
            // 
            // button_Reversion
            // 
            this.button_Reversion.Location = new System.Drawing.Point(225, 115);
            this.button_Reversion.Margin = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.button_Reversion.Name = "button_Reversion";
            this.button_Reversion.Size = new System.Drawing.Size(50, 50);
            this.button_Reversion.TabIndex = 14;
            this.button_Reversion.Text = "1/x";
            this.button_Reversion.UseVisualStyleBackColor = true;
            this.button_Reversion.Click += new System.EventHandler(this.button_Reversion_Click);
            // 
            // button_0
            // 
            this.button_0.Location = new System.Drawing.Point(5, 170);
            this.button_0.Margin = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.button_0.Name = "button_0";
            this.button_0.Size = new System.Drawing.Size(50, 50);
            this.button_0.TabIndex = 15;
            this.button_0.Text = "0";
            this.button_0.UseVisualStyleBackColor = true;
            this.button_0.Click += new System.EventHandler(this.button_0_Click);
            // 
            // button_PosNeg
            // 
            this.button_PosNeg.Location = new System.Drawing.Point(60, 170);
            this.button_PosNeg.Margin = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.button_PosNeg.Name = "button_PosNeg";
            this.button_PosNeg.Size = new System.Drawing.Size(50, 50);
            this.button_PosNeg.TabIndex = 16;
            this.button_PosNeg.Text = "+/-";
            this.button_PosNeg.UseVisualStyleBackColor = true;
            this.button_PosNeg.Click += new System.EventHandler(this.button_PosNeg_Click);
            // 
            // button_dot
            // 
            this.button_dot.Location = new System.Drawing.Point(115, 170);
            this.button_dot.Margin = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.button_dot.Name = "button_dot";
            this.button_dot.Size = new System.Drawing.Size(50, 50);
            this.button_dot.TabIndex = 17;
            this.button_dot.Text = ".";
            this.button_dot.UseVisualStyleBackColor = true;
            this.button_dot.Click += new System.EventHandler(this.button_dot_Click);
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(170, 170);
            this.button_Add.Margin = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(50, 50);
            this.button_Add.TabIndex = 18;
            this.button_Add.Text = "+";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_Equal
            // 
            this.button_Equal.Location = new System.Drawing.Point(225, 170);
            this.button_Equal.Margin = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.button_Equal.Name = "button_Equal";
            this.button_Equal.Size = new System.Drawing.Size(50, 50);
            this.button_Equal.TabIndex = 19;
            this.button_Equal.Text = "=";
            this.button_Equal.UseVisualStyleBackColor = true;
            this.button_Equal.Click += new System.EventHandler(this.button_Equal_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.button_memoryClear);
            this.flowLayoutPanel1.Controls.Add(this.button_memoryRecall);
            this.flowLayoutPanel1.Controls.Add(this.button_memoryStore);
            this.flowLayoutPanel1.Controls.Add(this.button_memoryAdd);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 47);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(58, 230);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // button_memoryClear
            // 
            this.button_memoryClear.Location = new System.Drawing.Point(5, 5);
            this.button_memoryClear.Margin = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.button_memoryClear.Name = "button_memoryClear";
            this.button_memoryClear.Size = new System.Drawing.Size(50, 50);
            this.button_memoryClear.TabIndex = 1;
            this.button_memoryClear.Text = "MC";
            this.button_memoryClear.UseVisualStyleBackColor = true;
            this.button_memoryClear.Click += new System.EventHandler(this.button_memoryClear_Click);
            // 
            // button_memoryRecall
            // 
            this.button_memoryRecall.Location = new System.Drawing.Point(5, 60);
            this.button_memoryRecall.Margin = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.button_memoryRecall.Name = "button_memoryRecall";
            this.button_memoryRecall.Size = new System.Drawing.Size(50, 50);
            this.button_memoryRecall.TabIndex = 2;
            this.button_memoryRecall.Text = "MR";
            this.button_memoryRecall.UseVisualStyleBackColor = true;
            this.button_memoryRecall.Click += new System.EventHandler(this.button_memoryRecall_Click);
            // 
            // button_memoryStore
            // 
            this.button_memoryStore.Location = new System.Drawing.Point(5, 115);
            this.button_memoryStore.Margin = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.button_memoryStore.Name = "button_memoryStore";
            this.button_memoryStore.Size = new System.Drawing.Size(50, 50);
            this.button_memoryStore.TabIndex = 3;
            this.button_memoryStore.Text = "MS";
            this.button_memoryStore.UseVisualStyleBackColor = true;
            this.button_memoryStore.Click += new System.EventHandler(this.button_memoryStore_Click);
            // 
            // button_memoryAdd
            // 
            this.button_memoryAdd.Location = new System.Drawing.Point(5, 170);
            this.button_memoryAdd.Margin = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.button_memoryAdd.Name = "button_memoryAdd";
            this.button_memoryAdd.Size = new System.Drawing.Size(50, 50);
            this.button_memoryAdd.TabIndex = 4;
            this.button_memoryAdd.Text = "M+";
            this.button_memoryAdd.UseVisualStyleBackColor = true;
            this.button_memoryAdd.Click += new System.EventHandler(this.button_memoryAdd_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 329);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Result_TextBox);
            this.MaximizeBox = false;
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Result_TextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Button button_7;
        private System.Windows.Forms.Button button_backSpace;
        private System.Windows.Forms.Button button_ClearEntry;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.Button button_8;
        private System.Windows.Forms.Button button_9;
        private System.Windows.Forms.Button button_Div;
        private System.Windows.Forms.Button button_Sqrt;
        private System.Windows.Forms.Button button_4;
        private System.Windows.Forms.Button button_5;
        private System.Windows.Forms.Button button_6;
        private System.Windows.Forms.Button button_Mult;
        private System.Windows.Forms.Button button_div100;
        private System.Windows.Forms.Button button_1;
        private System.Windows.Forms.Button button_2;
        private System.Windows.Forms.Button button_3;
        private System.Windows.Forms.Button button_sub;
        private System.Windows.Forms.Button button_Reversion;
        private System.Windows.Forms.Button button_0;
        private System.Windows.Forms.Button button_PosNeg;
        private System.Windows.Forms.Button button_dot;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button_Equal;
        private System.Windows.Forms.Button button_memoryClear;
        private System.Windows.Forms.Button button_memoryRecall;
        private System.Windows.Forms.Button button_memoryStore;
        private System.Windows.Forms.Button button_memoryAdd;
    }
}

