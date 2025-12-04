using System;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BT4
{
    public partial class Form1 : Form
    {
        private string CurrentFilePath = "";
        private Font fontDefault = new Font("Tahoma", 14, FontStyle.Regular, GraphicsUnit.Point);
        private FontStyle styleFont = FontStyle.Regular;
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
            AddFont();
        }
        private void AddFont()          //Add font vào combobox
        {
            InstalledFontCollection Fonts = new InstalledFontCollection();
            foreach (FontFamily font in Fonts.Families)
            {
                ComboBox_Font.Items.Add(font.Name);
                ComboBox_Font.AutoCompleteCustomSource.Add(font.Name);
            }
            ComboBox_Font.SelectedItem = "Tahoma";
        }
        // Thoát chương trình
        private void ToolStripMenuItem_Exit_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Result == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult Result = MessageBox.Show("Dữ liệu sẽ mất nếu như bạn chưa lưu dữ liệu, bạn có chắc chắn không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Result == DialogResult.No)
                e.Cancel = true;

        }
        //  Mở trang mới
        //
        private void ToolStripMenuItem_NewFile_Click(object sender, EventArgs e)
        {
            NewFile();
        }

        private void NewFile()
        {
            CurrentFilePath = "";
            label_PathFile.Text = "New Document";
            styleFont = FontStyle.Regular;
            RichTextBox_Word.Font = fontDefault;
            RichTextBox_Word.Text = string.Empty;
        }
        private void toolStripButton_NewFile_Click(object sender, EventArgs e)
        {
            NewFile();
        }

        //  Mở tệp tin
        //
        private void OpenFile()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "All Supported|*.txt;*.rtf|Text Files|*.txt|Rich Text Files|*.rtf";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (Path.GetExtension(ofd.FileName).ToLower() == ".rtf")
                    RichTextBox_Word.LoadFile(ofd.FileName, RichTextBoxStreamType.RichText);
                else
                    RichTextBox_Word.Text = File.ReadAllText(ofd.FileName);
                CurrentFilePath = ofd.FileName;
            }
            label_PathFile.Text = CurrentFilePath;
        }
        private void ToolStripMenuItem_OpenFile_Click(object sender, EventArgs e)
        {
            OpenFile();
        }
        // Lưu File
        private void SaveFile()
        {
            if (string.IsNullOrEmpty(CurrentFilePath))
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Text Files|*.txt|Rich Text Files|*.rtf";
                sfd.Title = "Save As";
                sfd.FileName = "Untitled";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    CurrentFilePath = sfd.FileName;
                    label_PathFile.Text = CurrentFilePath;
                }
                else
                {
                    return;
                }
            }

            string ext = Path.GetExtension(CurrentFilePath).ToLower();
            try
            {
                if (ext == ".rtf")
                    RichTextBox_Word.SaveFile(CurrentFilePath, RichTextBoxStreamType.RichText);
                else if (ext == ".txt")
                    File.WriteAllText(CurrentFilePath, RichTextBox_Word.Text);
                else throw new Exception(CurrentFilePath);
                MessageBox.Show("Lưu thành công!", "Lưu dữ liệu");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu file: " + ex.Message);
            }
        }
        private void toolStripButton_Save_Click(object sender, EventArgs e)
        {
            SaveFile();
        }
        private void ToolStripMenuItem_Save_Click(object sender, EventArgs e)
        {
            SaveFile();
        }
        private void Form1_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyValue == (int)Keys.N)
                NewFile();
            if (e.Control && e.KeyValue == (int)Keys.S)
                SaveFile();
            if (e.Control && e.KeyValue == (int)Keys.O)
                OpenFile();
        }


        // Xử lí FontStyle
        //

        //Button Event
        private void toolStripButton_BoldStyle_Click(object sender, EventArgs e)
        {
            if (RichTextBox_Word.SelectionLength == 0)
                styleFont ^= FontStyle.Bold;
            ToggleFontStyle(FontStyle.Bold);
        }

        private void toolStripButton_ItalicStyle_Click(object sender, EventArgs e)
        {
            if (RichTextBox_Word.SelectionLength == 0)
                styleFont ^= FontStyle.Italic;
            ToggleFontStyle(FontStyle.Italic);
        }

        private void toolStripButton_UnderlineStyle_Click(object sender, EventArgs e)
        {
            if (RichTextBox_Word.SelectionLength == 0)
                styleFont ^= FontStyle.Underline;
            ToggleFontStyle(FontStyle.Underline);
        }

        //Process
        private void ToggleFontStyle(FontStyle style)
        {
            var rtb = RichTextBox_Word;
            int start = rtb.SelectionStart;
            int length = rtb.SelectionLength;
            if (length == 0)
            {
                rtb.SelectionFont = new Font(rtb.Font, styleFont);
                return;
            }
            bool consistent = IsStyleConsistent(rtb, style);

            bool applyOn = !consistent;                     //mixed -> bật
            if (consistent && rtb.SelectionFont != null)    // đồng nhất style --> bật/tắt
                applyOn = !rtb.SelectionFont.Style.HasFlag(style);

            for (int i = start; i < start + length; i++)
            {
                rtb.Select(i, 1);
                Font f = rtb.SelectionFont;
                if (f == null) continue;
                FontStyle newStyle = f.Style;
                if (applyOn)
                    newStyle |= style;
                else
                    newStyle &= ~style;
                rtb.SelectionFont = new Font(f.FontFamily, f.Size, newStyle);
            }
            rtb.Select(start, length);
        }
        //Kiểm tra tính đồng nhất của FontStyle của selection Text
        private bool IsStyleConsistent(RichTextBox rtb, FontStyle style)
        {
            int start = rtb.SelectionStart;
            int length = rtb.SelectionLength;
            if (length == 0)
                return rtb.SelectionFont != null && rtb.SelectionFont.Style.HasFlag(style);

            int i = start;
            do
            {
                rtb.Select(i, 1);
                i++;
            } while (i < start + length && rtb.SelectionFont == null);
            rtb.Select(i, 1);
            bool first = rtb.SelectionFont.Style.HasFlag(style);
            i++;
            for (; i < start + length; i++)
            {
                rtb.Select(i, 1);
                if (rtb.SelectionFont == null) continue;

                bool has = rtb.SelectionFont.Style.HasFlag(style);
                if (first != has)
                    return false;
            }
            return true;
        }
        // UI button Fontstyle checked ?
        private void activeBtn(ToolStripButton sender, bool signal)
        {
           sender.BackColor = (signal == true ? SystemColors.GradientActiveCaption : SystemColors.Control);
        }

        //ToolstripFormat
        private void ToolStripMenuItem_Format_Click(object sender, EventArgs e)
        {
            FontDialog fontDLG = new FontDialog();
            fontDLG.Font = new Font("Tahoma",14, FontStyle.Regular, GraphicsUnit.Point);
            if (fontDLG.ShowDialog() == DialogResult.OK)
            {
                Font CurrentFont = fontDLG.Font;
                ComboBox_Font.Text = fontDLG.Font.Name;
                ComboBox_Size.Text = fontDLG.Font.Size.ToString();
                activeBtn(toolStripButton_Bold, fontDLG.Font.Style.HasFlag(FontStyle.Bold));
                activeBtn(toolStripButton_Italic, fontDLG.Font.Style.HasFlag(FontStyle.Italic));
                activeBtn(toolStripButton_Underline, fontDLG.Font.Style.HasFlag(FontStyle.Underline));
                RichTextBox_Word.Font = CurrentFont;
            }
        }

        //Thay đổi phông chữ
        private void ChangeFont()
        {
            Font CurrentFont = RichTextBox_Word.SelectionFont;
            if (RichTextBox_Word.SelectionLength == 0 )
            {
                RichTextBox_Word.SelectionFont =  new Font(ComboBox_Font.Text, CurrentFont.Size, 
                    CurrentFont.Style, CurrentFont.Unit);
                return;
            }
            var rtb = RichTextBox_Word;
            int start = RichTextBox_Word.SelectionStart;
            int length = RichTextBox_Word.SelectionLength;
            for (int i = start; i < start + length; i++)
            {
                rtb.Select(i, 1);
                Font f = rtb.SelectionFont;
                rtb.SelectionFont = new Font(ComboBox_Font.Text, f.Size, f.Style, f.Unit);
            }
            rtb.Select(start, length);
        }
        private void ComboBox_Font_KeyDown(object sender, KeyEventArgs e)
        {
            if ((Keys)e.KeyCode == Keys.Enter)
            {
                if (ComboBox_Font.FindString(ComboBox_Font.Text) == -1)
                    MessageBox.Show("Không tìm thấy font", "Cảnh báo",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ChangeFont();
                this.ActiveControl = null; 
            }
        }
        private void ComboBox_Font_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }

        //Thay đổi cỡ chữ
        private void ChangeSize()
        {
            float sz = convertFloat(ComboBox_Size.Text);
            if (sz <= 0) sz = RichTextBox_Word.SelectionFont.Size;

            Font CurrentFont = RichTextBox_Word.SelectionFont;
            if (RichTextBox_Word.SelectionLength == 0)
            {
                RichTextBox_Word.SelectionFont = new Font(CurrentFont.FontFamily.Name, sz,
                    CurrentFont.Style, CurrentFont.Unit);
                return;
            }

            var rtb = RichTextBox_Word;
            int start = RichTextBox_Word.SelectionStart;
            int length = RichTextBox_Word.SelectionLength;
            for (int i = start; i < start + length; i++)
            {
                rtb.Select(i, 1);
                Font f = rtb.SelectionFont;
                rtb.SelectionFont = new Font(f.FontFamily.Name,sz , f.Style,f.Unit);
            }
            rtb.Select(start, length);
            
        }
        private void ComboBox_Size_KeyDown(object sender, KeyEventArgs e)
        {
            if ((Keys)e.KeyCode == Keys.Enter)
            {
                if (convertFloat(ComboBox_Size.Text) < 8)
                    ComboBox_Size.Text = "8";
                ChangeSize();
                this.ActiveControl = null;
            }
        }
        private void ComboBox_Size_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeSize();
        }
        
        //Timer kiểm tra selection text có định dạng gì
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ComboBox_Font.Focused || ComboBox_Size.Focused) return;
            if (RichTextBox_Word.SelectionLength > 0)
            {
                RichTextBox rtb = new RichTextBox();
                rtb.Rtf = RichTextBox_Word.Rtf;
                int start = RichTextBox_Word.SelectionStart;
                int length = RichTextBox_Word.SelectionLength;
                rtb.Select(start, 1);
                FontStyle intersection = rtb.SelectionFont != null
                    ? rtb.SelectionFont.Style
                    : FontStyle.Regular;
                Font f = rtb.SelectionFont;
                string name = f.FontFamily.Name, size = f.Size.ToString();
                for (int i = start + 1; i < start + length; i++)
                {
                    rtb.Select(i, 1);
                    if (rtb.SelectionFont != null)
                        intersection &= rtb.SelectionFont.Style;
                    else
                        intersection = 0;
                    if (rtb.SelectionFont.Size != f.Size)
                        size = "";
                    if (rtb.SelectionFont.FontFamily.Name != f.FontFamily.Name)
                        name = "";
                }
                ComboBox_Font.Text = name;
                ComboBox_Size.Text = size;
                styleFont = intersection;
                rtb.Select(start, length);
                activeBtn(toolStripButton_Bold, styleFont.HasFlag(FontStyle.Bold));
                activeBtn(toolStripButton_Italic, styleFont.HasFlag(FontStyle.Italic));
                activeBtn(toolStripButton_Underline, styleFont.HasFlag(FontStyle.Underline));
            }
            else
            {
                Font f = GetCaretFont(RichTextBox_Word);
                activeBtn(toolStripButton_Bold, f.Style.HasFlag(FontStyle.Bold));
                activeBtn(toolStripButton_Italic, f.Style.HasFlag(FontStyle.Italic));
                activeBtn(toolStripButton_Underline, f.Style.HasFlag(FontStyle.Underline));
            }
            
        }
        Font GetCaretFont(RichTextBox rtb)  // Lấy Font của vị trí Caret đang đứng
        {
            int pos = rtb.SelectionStart;

            rtb.SelectionLength = 0;
            rtb.SelectedText = " ";

            // Lấy font của space tạm
            rtb.Select(pos, 1);
            Font f = rtb.SelectionFont;

            rtb.Select(pos, 1);
            rtb.SelectedText = "";

            return f;
        }
        private float convertFloat(string text)
        {
            int val = 0;
            int.TryParse(text, out val);
            return val;
        }
    }
}
