namespace Bai08
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
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.textBox_STK = new System.Windows.Forms.TextBox();
            this.textBox_TenKH = new System.Windows.Forms.TextBox();
            this.textBox_DiaChi = new System.Windows.Forms.TextBox();
            this.textBox_SoTien = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label_STK = new System.Windows.Forms.Label();
            this.label_TenKH = new System.Windows.Forms.Label();
            this.label_DiaChi = new System.Windows.Forms.Label();
            this.label_SoTien = new System.Windows.Forms.Label();
            this.listView_TaiKhoan = new System.Windows.Forms.ListView();
            this.STT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MaTK = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TenNguoi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DiaChi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SoTien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_AddUpdate = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.textBox_TongTien = new System.Windows.Forms.TextBox();
            this.labelTongTien = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(782, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ THÔNG TIN TÀI KHOẢN";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.textBox_STK);
            this.flowLayoutPanel1.Controls.Add(this.textBox_TenKH);
            this.flowLayoutPanel1.Controls.Add(this.textBox_DiaChi);
            this.flowLayoutPanel1.Controls.Add(this.textBox_SoTien);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(278, 91);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(406, 174);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // textBox_STK
            // 
            this.textBox_STK.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_STK.Location = new System.Drawing.Point(3, 5);
            this.textBox_STK.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.textBox_STK.MaxLength = 10;
            this.textBox_STK.Name = "textBox_STK";
            this.textBox_STK.Size = new System.Drawing.Size(395, 31);
            this.textBox_STK.TabIndex = 0;
            // 
            // textBox_TenKH
            // 
            this.textBox_TenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_TenKH.Location = new System.Drawing.Point(3, 46);
            this.textBox_TenKH.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.textBox_TenKH.MaxLength = 50;
            this.textBox_TenKH.Name = "textBox_TenKH";
            this.textBox_TenKH.Size = new System.Drawing.Size(395, 31);
            this.textBox_TenKH.TabIndex = 1;
            // 
            // textBox_DiaChi
            // 
            this.textBox_DiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_DiaChi.Location = new System.Drawing.Point(3, 87);
            this.textBox_DiaChi.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.textBox_DiaChi.MaxLength = 200;
            this.textBox_DiaChi.Name = "textBox_DiaChi";
            this.textBox_DiaChi.Size = new System.Drawing.Size(395, 31);
            this.textBox_DiaChi.TabIndex = 2;
            // 
            // textBox_SoTien
            // 
            this.textBox_SoTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_SoTien.Location = new System.Drawing.Point(3, 128);
            this.textBox_SoTien.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.textBox_SoTien.MaxLength = 12;
            this.textBox_SoTien.Name = "textBox_SoTien";
            this.textBox_SoTien.Size = new System.Drawing.Size(395, 31);
            this.textBox_SoTien.TabIndex = 3;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label_STK);
            this.flowLayoutPanel2.Controls.Add(this.label_TenKH);
            this.flowLayoutPanel2.Controls.Add(this.label_DiaChi);
            this.flowLayoutPanel2.Controls.Add(this.label_SoTien);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLayoutPanel2.Location = new System.Drawing.Point(40, 91);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flowLayoutPanel2.Size = new System.Drawing.Size(235, 174);
            this.flowLayoutPanel2.TabIndex = 4;
            // 
            // label_STK
            // 
            this.label_STK.AutoSize = true;
            this.label_STK.Location = new System.Drawing.Point(100, 7);
            this.label_STK.Margin = new System.Windows.Forms.Padding(3, 7, 3, 9);
            this.label_STK.Name = "label_STK";
            this.label_STK.Size = new System.Drawing.Size(132, 25);
            this.label_STK.TabIndex = 0;
            this.label_STK.Text = "Số tài khoản";
            // 
            // label_TenKH
            // 
            this.label_TenKH.AutoSize = true;
            this.label_TenKH.Location = new System.Drawing.Point(65, 48);
            this.label_TenKH.Margin = new System.Windows.Forms.Padding(3, 7, 3, 9);
            this.label_TenKH.Name = "label_TenKH";
            this.label_TenKH.Size = new System.Drawing.Size(167, 25);
            this.label_TenKH.TabIndex = 1;
            this.label_TenKH.Text = "Tên khách hàng";
            // 
            // label_DiaChi
            // 
            this.label_DiaChi.AutoSize = true;
            this.label_DiaChi.Location = new System.Drawing.Point(36, 89);
            this.label_DiaChi.Margin = new System.Windows.Forms.Padding(3, 7, 3, 9);
            this.label_DiaChi.Name = "label_DiaChi";
            this.label_DiaChi.Size = new System.Drawing.Size(196, 25);
            this.label_DiaChi.TabIndex = 2;
            this.label_DiaChi.Text = "Địa chỉ khách hàng";
            // 
            // label_SoTien
            // 
            this.label_SoTien.AutoSize = true;
            this.label_SoTien.Location = new System.Drawing.Point(4, 130);
            this.label_SoTien.Margin = new System.Windows.Forms.Padding(3, 7, 3, 9);
            this.label_SoTien.Name = "label_SoTien";
            this.label_SoTien.Size = new System.Drawing.Size(228, 25);
            this.label_SoTien.TabIndex = 3;
            this.label_SoTien.Text = "Số tiền trong tài khoản";
            // 
            // listView_TaiKhoan
            // 
            this.listView_TaiKhoan.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.STT,
            this.MaTK,
            this.TenNguoi,
            this.DiaChi,
            this.SoTien});
            this.listView_TaiKhoan.FullRowSelect = true;
            this.listView_TaiKhoan.HideSelection = false;
            this.listView_TaiKhoan.Location = new System.Drawing.Point(22, 314);
            this.listView_TaiKhoan.Name = "listView_TaiKhoan";
            this.listView_TaiKhoan.Size = new System.Drawing.Size(766, 260);
            this.listView_TaiKhoan.TabIndex = 5;
            this.listView_TaiKhoan.UseCompatibleStateImageBehavior = false;
            this.listView_TaiKhoan.View = System.Windows.Forms.View.Details;
            this.listView_TaiKhoan.SelectedIndexChanged += new System.EventHandler(this.listView_TaiKhoan_SelectedIndexChanged);
            // 
            // STT
            // 
            this.STT.Text = "STT";
            this.STT.Width = 50;
            // 
            // MaTK
            // 
            this.MaTK.Text = "Mã tài khoản";
            this.MaTK.Width = 120;
            // 
            // TenNguoi
            // 
            this.TenNguoi.Text = "Tên khách hàng";
            this.TenNguoi.Width = 180;
            // 
            // DiaChi
            // 
            this.DiaChi.Text = "Địa chỉ";
            this.DiaChi.Width = 247;
            // 
            // SoTien
            // 
            this.SoTien.Text = "Số tiền";
            this.SoTien.Width = 154;
            // 
            // button_AddUpdate
            // 
            this.button_AddUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_AddUpdate.Location = new System.Drawing.Point(281, 271);
            this.button_AddUpdate.Name = "button_AddUpdate";
            this.button_AddUpdate.Size = new System.Drawing.Size(163, 35);
            this.button_AddUpdate.TabIndex = 6;
            this.button_AddUpdate.Text = "Thêm / Cập nhật";
            this.button_AddUpdate.UseVisualStyleBackColor = true;
            this.button_AddUpdate.Click += new System.EventHandler(this.button_AddUpdate_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Delete.Location = new System.Drawing.Point(450, 271);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(86, 35);
            this.button_Delete.TabIndex = 7;
            this.button_Delete.Text = "Xóa";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_exit
            // 
            this.button_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_exit.Location = new System.Drawing.Point(575, 271);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(109, 35);
            this.button_exit.TabIndex = 8;
            this.button_exit.Text = "Thoát";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // textBox_TongTien
            // 
            this.textBox_TongTien.BackColor = System.Drawing.Color.White;
            this.textBox_TongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_TongTien.Location = new System.Drawing.Point(354, 590);
            this.textBox_TongTien.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.textBox_TongTien.MaxLength = 18;
            this.textBox_TongTien.Name = "textBox_TongTien";
            this.textBox_TongTien.ReadOnly = true;
            this.textBox_TongTien.Size = new System.Drawing.Size(434, 31);
            this.textBox_TongTien.TabIndex = 4;
            this.textBox_TongTien.Text = "0";
            this.textBox_TongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelTongTien
            // 
            this.labelTongTien.AutoSize = true;
            this.labelTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTongTien.Location = new System.Drawing.Point(230, 590);
            this.labelTongTien.Margin = new System.Windows.Forms.Padding(3, 7, 3, 9);
            this.labelTongTien.Name = "labelTongTien";
            this.labelTongTien.Size = new System.Drawing.Size(118, 25);
            this.labelTongTien.TabIndex = 4;
            this.labelTongTien.Text = "Tổng Tiền";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 635);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_AddUpdate);
            this.Controls.Add(this.listView_TaiKhoan);
            this.Controls.Add(this.labelTongTien);
            this.Controls.Add(this.textBox_TongTien);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Name = "Form1";
            this.Text = "Quản lý tài khoản";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox textBox_STK;
        private System.Windows.Forms.TextBox textBox_TenKH;
        private System.Windows.Forms.TextBox textBox_DiaChi;
        private System.Windows.Forms.TextBox textBox_SoTien;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label_STK;
        private System.Windows.Forms.Label label_TenKH;
        private System.Windows.Forms.Label label_DiaChi;
        private System.Windows.Forms.Label label_SoTien;
        private System.Windows.Forms.ListView listView_TaiKhoan;
        private System.Windows.Forms.ColumnHeader STT;
        private System.Windows.Forms.ColumnHeader MaTK;
        private System.Windows.Forms.ColumnHeader TenNguoi;
        private System.Windows.Forms.ColumnHeader DiaChi;
        private System.Windows.Forms.ColumnHeader SoTien;
        private System.Windows.Forms.Button button_AddUpdate;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.TextBox textBox_TongTien;
        private System.Windows.Forms.Label labelTongTien;
    }
}

