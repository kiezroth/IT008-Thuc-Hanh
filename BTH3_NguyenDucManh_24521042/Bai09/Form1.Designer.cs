namespace Bai09
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_MSSV = new System.Windows.Forms.TextBox();
            this.label_MSSV = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox_TenSV = new System.Windows.Forms.TextBox();
            this.label_TenSV = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboBox_CN = new System.Windows.Forms.ComboBox();
            this.label_CN = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.radioButton_Nu = new System.Windows.Forms.RadioButton();
            this.radioButton_Nam = new System.Windows.Forms.RadioButton();
            this.label_gen = new System.Windows.Forms.Label();
            this.label_selectSubj = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.listBox_selected = new System.Windows.Forms.ListBox();
            this.button_remove = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.listBox_unselect = new System.Windows.Forms.ListBox();
            this.listView_DS = new System.Windows.Forms.ListView();
            this.STT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MSSV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HoTen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ChuyenNganh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GioiTinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SoMon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_Delete);
            this.groupBox1.Controls.Add(this.button_Save);
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(66, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 397);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sinh viên";
            // 
            // button_Delete
            // 
            this.button_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Delete.Location = new System.Drawing.Point(366, 348);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(92, 32);
            this.button_Delete.TabIndex = 2;
            this.button_Delete.Text = "Xóa Chọn";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_Save
            // 
            this.button_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Save.Location = new System.Drawing.Point(247, 348);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(113, 32);
            this.button_Save.TabIndex = 1;
            this.button_Save.Text = "Lưu Thông Tin";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Controls.Add(this.panel4);
            this.flowLayoutPanel1.Controls.Add(this.label_selectSubj);
            this.flowLayoutPanel1.Controls.Add(this.panel5);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(81, 38);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(660, 304);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox_MSSV);
            this.panel1.Controls.Add(this.label_MSSV);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(657, 34);
            this.panel1.TabIndex = 1;
            // 
            // textBox_MSSV
            // 
            this.textBox_MSSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_MSSV.Location = new System.Drawing.Point(143, 3);
            this.textBox_MSSV.MaxLength = 8;
            this.textBox_MSSV.Name = "textBox_MSSV";
            this.textBox_MSSV.Size = new System.Drawing.Size(250, 24);
            this.textBox_MSSV.TabIndex = 1;
            // 
            // label_MSSV
            // 
            this.label_MSSV.AutoSize = true;
            this.label_MSSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_MSSV.Location = new System.Drawing.Point(4, 4);
            this.label_MSSV.Name = "label_MSSV";
            this.label_MSSV.Padding = new System.Windows.Forms.Padding(5, 5, 5, 3);
            this.label_MSSV.Size = new System.Drawing.Size(100, 26);
            this.label_MSSV.TabIndex = 0;
            this.label_MSSV.Text = "Mã sinh viên";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox_TenSV);
            this.panel2.Controls.Add(this.label_TenSV);
            this.panel2.Location = new System.Drawing.Point(3, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(657, 34);
            this.panel2.TabIndex = 2;
            // 
            // textBox_TenSV
            // 
            this.textBox_TenSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_TenSV.Location = new System.Drawing.Point(143, 3);
            this.textBox_TenSV.MaxLength = 50;
            this.textBox_TenSV.Name = "textBox_TenSV";
            this.textBox_TenSV.Size = new System.Drawing.Size(308, 24);
            this.textBox_TenSV.TabIndex = 1;
            // 
            // label_TenSV
            // 
            this.label_TenSV.AutoSize = true;
            this.label_TenSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TenSV.Location = new System.Drawing.Point(4, 4);
            this.label_TenSV.Name = "label_TenSV";
            this.label_TenSV.Padding = new System.Windows.Forms.Padding(5, 5, 5, 3);
            this.label_TenSV.Size = new System.Drawing.Size(67, 26);
            this.label_TenSV.TabIndex = 0;
            this.label_TenSV.Text = "Họ Tên";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.comboBox_CN);
            this.panel3.Controls.Add(this.label_CN);
            this.panel3.Location = new System.Drawing.Point(3, 83);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(657, 34);
            this.panel3.TabIndex = 3;
            // 
            // comboBox_CN
            // 
            this.comboBox_CN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_CN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_CN.FormattingEnabled = true;
            this.comboBox_CN.Items.AddRange(new object[] {
            "Công nghệ Thông tin",
            "Hệ thống Thông tin",
            "Khoa học Máy tính",
            "Kỹ thuật Phần mềm",
            "Kỹ thuật Máy tính",
            "Mạng máy tính & Truyền thông Dữ liệu",
            "An toàn Thông tin",
            "Thương mại Điện tử",
            "Khoa học Dữ liệu",
            "Trí tuệ Nhân tạo",
            "Thiết kế Vi mạch",
            "Truyền thông Đa phương tiện"});
            this.comboBox_CN.Location = new System.Drawing.Point(143, 3);
            this.comboBox_CN.Name = "comboBox_CN";
            this.comboBox_CN.Size = new System.Drawing.Size(308, 26);
            this.comboBox_CN.TabIndex = 1;
            this.comboBox_CN.SelectedIndexChanged += new System.EventHandler(this.comboBox_CN_SelectedIndexChanged);
            // 
            // label_CN
            // 
            this.label_CN.AutoSize = true;
            this.label_CN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CN.Location = new System.Drawing.Point(4, 4);
            this.label_CN.Name = "label_CN";
            this.label_CN.Padding = new System.Windows.Forms.Padding(5, 5, 5, 3);
            this.label_CN.Size = new System.Drawing.Size(115, 26);
            this.label_CN.TabIndex = 0;
            this.label_CN.Text = "Chuyên Ngành";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.radioButton_Nu);
            this.panel4.Controls.Add(this.radioButton_Nam);
            this.panel4.Controls.Add(this.label_gen);
            this.panel4.Location = new System.Drawing.Point(3, 123);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(657, 34);
            this.panel4.TabIndex = 4;
            // 
            // radioButton_Nu
            // 
            this.radioButton_Nu.AutoSize = true;
            this.radioButton_Nu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_Nu.Location = new System.Drawing.Point(266, 7);
            this.radioButton_Nu.Name = "radioButton_Nu";
            this.radioButton_Nu.Size = new System.Drawing.Size(45, 22);
            this.radioButton_Nu.TabIndex = 2;
            this.radioButton_Nu.TabStop = true;
            this.radioButton_Nu.Text = "Nữ";
            this.radioButton_Nu.UseVisualStyleBackColor = true;
            // 
            // radioButton_Nam
            // 
            this.radioButton_Nam.AutoSize = true;
            this.radioButton_Nam.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_Nam.Location = new System.Drawing.Point(143, 7);
            this.radioButton_Nam.Name = "radioButton_Nam";
            this.radioButton_Nam.Size = new System.Drawing.Size(58, 22);
            this.radioButton_Nam.TabIndex = 1;
            this.radioButton_Nam.TabStop = true;
            this.radioButton_Nam.Text = "Nam";
            this.radioButton_Nam.UseVisualStyleBackColor = true;
            // 
            // label_gen
            // 
            this.label_gen.AutoSize = true;
            this.label_gen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_gen.Location = new System.Drawing.Point(4, 4);
            this.label_gen.Name = "label_gen";
            this.label_gen.Padding = new System.Windows.Forms.Padding(5, 5, 5, 3);
            this.label_gen.Size = new System.Drawing.Size(77, 26);
            this.label_gen.TabIndex = 0;
            this.label_gen.Text = "Giới Tính";
            // 
            // label_selectSubj
            // 
            this.label_selectSubj.AutoSize = true;
            this.label_selectSubj.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_selectSubj.Location = new System.Drawing.Point(3, 160);
            this.label_selectSubj.Name = "label_selectSubj";
            this.label_selectSubj.Padding = new System.Windows.Forms.Padding(5, 5, 5, 3);
            this.label_selectSubj.Size = new System.Drawing.Size(205, 26);
            this.label_selectSubj.TabIndex = 5;
            this.label_selectSubj.Text = "Chọn các môn học tham gia";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.listBox_selected);
            this.panel5.Controls.Add(this.button_remove);
            this.panel5.Controls.Add(this.button_add);
            this.panel5.Controls.Add(this.listBox_unselect);
            this.panel5.Location = new System.Drawing.Point(3, 189);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(657, 107);
            this.panel5.TabIndex = 1;
            // 
            // listBox_selected
            // 
            this.listBox_selected.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_selected.FormattingEnabled = true;
            this.listBox_selected.Location = new System.Drawing.Point(358, 15);
            this.listBox_selected.Name = "listBox_selected";
            this.listBox_selected.Size = new System.Drawing.Size(267, 82);
            this.listBox_selected.TabIndex = 3;
            // 
            // button_remove
            // 
            this.button_remove.Location = new System.Drawing.Point(298, 60);
            this.button_remove.Name = "button_remove";
            this.button_remove.Size = new System.Drawing.Size(30, 30);
            this.button_remove.TabIndex = 2;
            this.button_remove.Text = "<";
            this.button_remove.UseVisualStyleBackColor = true;
            this.button_remove.Click += new System.EventHandler(this.button_remove_Click);
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(298, 24);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(30, 30);
            this.button_add.TabIndex = 1;
            this.button_add.Text = ">";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // listBox_unselect
            // 
            this.listBox_unselect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_unselect.FormattingEnabled = true;
            this.listBox_unselect.Location = new System.Drawing.Point(7, 15);
            this.listBox_unselect.Name = "listBox_unselect";
            this.listBox_unselect.Size = new System.Drawing.Size(267, 82);
            this.listBox_unselect.TabIndex = 0;
            // 
            // listView_DS
            // 
            this.listView_DS.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView_DS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView_DS.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.STT,
            this.MSSV,
            this.HoTen,
            this.ChuyenNganh,
            this.GioiTinh,
            this.SoMon});
            this.listView_DS.FullRowSelect = true;
            this.listView_DS.HideSelection = false;
            this.listView_DS.Location = new System.Drawing.Point(66, 415);
            this.listView_DS.Name = "listView_DS";
            this.listView_DS.Size = new System.Drawing.Size(776, 229);
            this.listView_DS.TabIndex = 1;
            this.listView_DS.UseCompatibleStateImageBehavior = false;
            this.listView_DS.View = System.Windows.Forms.View.Details;
            // 
            // STT
            // 
            this.STT.Text = "*";
            this.STT.Width = 30;
            // 
            // MSSV
            // 
            this.MSSV.Text = "MSSV";
            this.MSSV.Width = 116;
            // 
            // HoTen
            // 
            this.HoTen.Text = "Họ Tên";
            this.HoTen.Width = 210;
            // 
            // ChuyenNganh
            // 
            this.ChuyenNganh.Text = "Chuyên Ngành";
            this.ChuyenNganh.Width = 226;
            // 
            // GioiTinh
            // 
            this.GioiTinh.Text = "Giới Tính";
            this.GioiTinh.Width = 126;
            // 
            // SoMon
            // 
            this.SoMon.Text = "Số Môn";
            this.SoMon.Width = 58;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 656);
            this.Controls.Add(this.listView_DS);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox_MSSV;
        private System.Windows.Forms.Label label_MSSV;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox_TenSV;
        private System.Windows.Forms.Label label_TenSV;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox comboBox_CN;
        private System.Windows.Forms.Label label_CN;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton radioButton_Nu;
        private System.Windows.Forms.RadioButton radioButton_Nam;
        private System.Windows.Forms.Label label_gen;
        private System.Windows.Forms.Label label_selectSubj;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ListBox listBox_unselect;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.ListBox listBox_selected;
        private System.Windows.Forms.Button button_remove;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.ListView listView_DS;
        private System.Windows.Forms.ColumnHeader STT;
        private System.Windows.Forms.ColumnHeader MSSV;
        private System.Windows.Forms.ColumnHeader HoTen;
        private System.Windows.Forms.ColumnHeader ChuyenNganh;
        private System.Windows.Forms.ColumnHeader GioiTinh;
        private System.Windows.Forms.ColumnHeader SoMon;
    }
}

