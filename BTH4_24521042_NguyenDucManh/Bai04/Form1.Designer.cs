using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Bai04
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.RichTextBox_Word = new System.Windows.Forms.RichTextBox();
            this.menuStrip_mainStrip = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItem_HeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_NewFile = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_OpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.ToollStripMenuItem_SaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Format = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_NewFile = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Save = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ComboBox_Font = new System.Windows.Forms.ToolStripComboBox();
            this.ComboBox_Size = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_Bold = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Italic = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Underline = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label_PathFile = new System.Windows.Forms.Label();
            this.menuStrip_mainStrip.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RichTextBox_Word
            // 
            this.RichTextBox_Word.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RichTextBox_Word.Location = new System.Drawing.Point(9, 51);
            this.RichTextBox_Word.Margin = new System.Windows.Forms.Padding(2);
            this.RichTextBox_Word.Name = "RichTextBox_Word";
            this.RichTextBox_Word.Size = new System.Drawing.Size(992, 523);
            this.RichTextBox_Word.TabIndex = 0;
            this.RichTextBox_Word.Text = "";
            // 
            // menuStrip_mainStrip
            // 
            this.menuStrip_mainStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip_mainStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_HeThong,
            this.ToolStripMenuItem_Format});
            this.menuStrip_mainStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_mainStrip.Name = "menuStrip_mainStrip";
            this.menuStrip_mainStrip.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip_mainStrip.Size = new System.Drawing.Size(1010, 24);
            this.menuStrip_mainStrip.TabIndex = 1;
            this.menuStrip_mainStrip.Text = "menuStrip1";
            // 
            // ToolStripMenuItem_HeThong
            // 
            this.ToolStripMenuItem_HeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_NewFile,
            this.ToolStripMenuItem_OpenFile,
            this.toolStripMenuItem1,
            this.ToollStripMenuItem_SaveAs,
            this.ToolStripMenuItem_Exit});
            this.ToolStripMenuItem_HeThong.Name = "ToolStripMenuItem_HeThong";
            this.ToolStripMenuItem_HeThong.Size = new System.Drawing.Size(69, 22);
            this.ToolStripMenuItem_HeThong.Text = "Hệ thống";
            // 
            // ToolStripMenuItem_NewFile
            // 
            this.ToolStripMenuItem_NewFile.Image = global::Bai04.Properties.Resources.new_document;
            this.ToolStripMenuItem_NewFile.Name = "ToolStripMenuItem_NewFile";
            this.ToolStripMenuItem_NewFile.ShortcutKeyDisplayString = "Ctrl + N";
            this.ToolStripMenuItem_NewFile.Size = new System.Drawing.Size(240, 26);
            this.ToolStripMenuItem_NewFile.Text = "Tạo văn bản mới ";
            this.ToolStripMenuItem_NewFile.Click += new System.EventHandler(this.ToolStripMenuItem_NewFile_Click);
            // 
            // ToolStripMenuItem_OpenFile
            // 
            this.ToolStripMenuItem_OpenFile.Image = global::Bai04.Properties.Resources.folder;
            this.ToolStripMenuItem_OpenFile.Name = "ToolStripMenuItem_OpenFile";
            this.ToolStripMenuItem_OpenFile.ShortcutKeyDisplayString = "Ctrl + O";
            this.ToolStripMenuItem_OpenFile.Size = new System.Drawing.Size(240, 26);
            this.ToolStripMenuItem_OpenFile.Text = "Mở tập tin";
            this.ToolStripMenuItem_OpenFile.Click += new System.EventHandler(this.ToolStripMenuItem_OpenFile_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(237, 6);
            // 
            // ToollStripMenuItem_SaveAs
            // 
            this.ToollStripMenuItem_SaveAs.Image = global::Bai04.Properties.Resources.diskette;
            this.ToollStripMenuItem_SaveAs.Name = "ToollStripMenuItem_SaveAs";
            this.ToollStripMenuItem_SaveAs.ShortcutKeyDisplayString = "Ctrl + S";
            this.ToollStripMenuItem_SaveAs.Size = new System.Drawing.Size(240, 26);
            this.ToollStripMenuItem_SaveAs.Text = "Lưu nội dung văn bản";
            this.ToollStripMenuItem_SaveAs.Click += new System.EventHandler(this.ToolStripMenuItem_Save_Click);
            // 
            // ToolStripMenuItem_Exit
            // 
            this.ToolStripMenuItem_Exit.Name = "ToolStripMenuItem_Exit";
            this.ToolStripMenuItem_Exit.Size = new System.Drawing.Size(240, 26);
            this.ToolStripMenuItem_Exit.Text = "Thoát";
            this.ToolStripMenuItem_Exit.Click += new System.EventHandler(this.ToolStripMenuItem_Exit_Click);
            // 
            // ToolStripMenuItem_Format
            // 
            this.ToolStripMenuItem_Format.Name = "ToolStripMenuItem_Format";
            this.ToolStripMenuItem_Format.Size = new System.Drawing.Size(74, 22);
            this.ToolStripMenuItem_Format.Text = "Định dạng";
            this.ToolStripMenuItem_Format.Click += new System.EventHandler(this.ToolStripMenuItem_Format_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_NewFile,
            this.toolStripButton_Save,
            this.toolStripSeparator2,
            this.ComboBox_Font,
            this.ComboBox_Size,
            this.toolStripSeparator3,
            this.toolStripButton_Bold,
            this.toolStripButton_Italic,
            this.toolStripButton_Underline,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1010, 27);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton_NewFile
            // 
            this.toolStripButton_NewFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_NewFile.Image = global::Bai04.Properties.Resources.new_document;
            this.toolStripButton_NewFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_NewFile.Name = "toolStripButton_NewFile";
            this.toolStripButton_NewFile.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton_NewFile.Text = "New Page";
            this.toolStripButton_NewFile.Click += new System.EventHandler(this.toolStripButton_NewFile_Click);
            // 
            // toolStripButton_Save
            // 
            this.toolStripButton_Save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_Save.Image = global::Bai04.Properties.Resources.diskette;
            this.toolStripButton_Save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Save.Name = "toolStripButton_Save";
            this.toolStripButton_Save.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton_Save.Text = "Save";
            this.toolStripButton_Save.Click += new System.EventHandler(this.toolStripButton_Save_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // ComboBox_Font
            // 
            this.ComboBox_Font.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.ComboBox_Font.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboBox_Font.DropDownHeight = 120;
            this.ComboBox_Font.DropDownWidth = 200;
            this.ComboBox_Font.IntegralHeight = false;
            this.ComboBox_Font.Name = "ComboBox_Font";
            this.ComboBox_Font.Size = new System.Drawing.Size(200, 27);
            this.ComboBox_Font.Sorted = true;
            this.ComboBox_Font.Text = "Tahoma";
            this.ComboBox_Font.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Font_SelectedIndexChanged);
            this.ComboBox_Font.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ComboBox_Font_KeyDown);
            // 
            // ComboBox_Size
            // 
            this.ComboBox_Size.AutoCompleteCustomSource.AddRange(new string[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "26",
            "28",
            "36",
            "72"});
            this.ComboBox_Size.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.ComboBox_Size.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboBox_Size.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.ComboBox_Size.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "26",
            "28",
            "36",
            "72"});
            this.ComboBox_Size.MaxLength = 2;
            this.ComboBox_Size.Name = "ComboBox_Size";
            this.ComboBox_Size.Size = new System.Drawing.Size(92, 27);
            this.ComboBox_Size.Text = "14";
            this.ComboBox_Size.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Size_SelectedIndexChanged);
            this.ComboBox_Size.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ComboBox_Size_KeyDown);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButton_Bold
            // 
            this.toolStripButton_Bold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_Bold.Image = global::Bai04.Properties.Resources.Bold;
            this.toolStripButton_Bold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Bold.Name = "toolStripButton_Bold";
            this.toolStripButton_Bold.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton_Bold.Text = "Bold";
            this.toolStripButton_Bold.Click += new System.EventHandler(this.toolStripButton_BoldStyle_Click);
            // 
            // toolStripButton_Italic
            // 
            this.toolStripButton_Italic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_Italic.Image = global::Bai04.Properties.Resources.italic;
            this.toolStripButton_Italic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Italic.Name = "toolStripButton_Italic";
            this.toolStripButton_Italic.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton_Italic.Text = "Italic";
            this.toolStripButton_Italic.Click += new System.EventHandler(this.toolStripButton_ItalicStyle_Click);
            // 
            // toolStripButton_Underline
            // 
            this.toolStripButton_Underline.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripButton_Underline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_Underline.Image = global::Bai04.Properties.Resources.Underline;
            this.toolStripButton_Underline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Underline.Name = "toolStripButton_Underline";
            this.toolStripButton_Underline.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton_Underline.Text = "Underline";
            this.toolStripButton_Underline.Click += new System.EventHandler(this.toolStripButton_UnderlineStyle_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label_PathFile
            // 
            this.label_PathFile.AutoSize = true;
            this.label_PathFile.Location = new System.Drawing.Point(12, 583);
            this.label_PathFile.Name = "label_PathFile";
            this.label_PathFile.Size = new System.Drawing.Size(81, 13);
            this.label_PathFile.TabIndex = 3;
            this.label_PathFile.Text = "New Document";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 605);
            this.Controls.Add(this.label_PathFile);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.RichTextBox_Word);
            this.Controls.Add(this.menuStrip_mainStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip_mainStrip;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Soạn thảo văn bản";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown_1);
            this.menuStrip_mainStrip.ResumeLayout(false);
            this.menuStrip_mainStrip.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox RichTextBox_Word;
        private MenuStrip menuStrip_mainStrip;
        private ToolStripMenuItem ToolStripMenuItem_HeThong;
        private ToolStripMenuItem ToolStripMenuItem_Format;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton_NewFile;
        private ToolStripButton toolStripButton_Save;
        private ToolStripComboBox ComboBox_Font;
        private ToolStripMenuItem ToolStripMenuItem_NewFile;
        private ToolStripMenuItem ToolStripMenuItem_OpenFile;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem ToollStripMenuItem_SaveAs;
        private ToolStripMenuItem ToolStripMenuItem_Exit;
        private ToolStripComboBox ComboBox_Size;
        private ToolStripButton toolStripButton_Bold;
        private ToolStripButton toolStripButton_Italic;
        private ToolStripButton toolStripButton_Underline;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator3;
        private Timer timer1;
        private Label label_PathFile;
    }
}
