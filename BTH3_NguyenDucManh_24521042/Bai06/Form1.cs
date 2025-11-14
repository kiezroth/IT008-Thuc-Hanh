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
    public partial class Calculator : Form
    {
        List<Button> NumberButton;
        List<Button> OperatorButton;
        List<Button> MathButton;
        List<Button> MemoryButton;
        List<Button> EditButton;
        cData CurrentData = new cData();
        cData PreviousData = new cData();
        cData  NewNumber = new cData(), Result = new cData();
        cData MemoryData = new cData();
        enum _Operator
        {
            None,
            Add,
            Sub,
            Mult,
            Div,
            Equal
        }
        _Operator chosen = _Operator.Add;
        private void InitializeButton()
        {
            NumberButton = new List<Button>
            {
                button_0,
                button_1,
                button_2,
                button_3,
                button_4,
                button_5,
                button_6,
                button_7,
                button_8,
                button_9,
            };
            foreach (Button button in NumberButton)
            {
                button.Click += button_Number_Click;
            }
            OperatorButton = new List<Button>
            {
                button_Div,
                button_Mult,
                button_sub,
                button_Add
            };
            MathButton = new List<Button>
            {
                button_Sqrt,
                button_div100,
                button_Reversion,
                button_Equal
            };
            MemoryButton = new List<Button>
            {
                button_memoryClear,
                button_memoryRecall,
                button_memoryStore,
                button_memoryAdd,
            };
            EditButton = new List<Button>
            {
                button_backSpace,
                button_ClearEntry,
                button_Clear
            };
        }
        public Calculator()
        {
            InitializeComponent();
            InitializeButton();
        }
        private void button_0_Click(object sender, EventArgs e)
        {
            NewNumber.InsertEnd('0');
        }
        private void button_1_Click(object sender, EventArgs e)
        {
            NewNumber.InsertEnd('1');
        }
        private void button_2_Click(object sender, EventArgs e)
        {
            NewNumber.InsertEnd('2');
        }
        private void button_3_Click(object sender, EventArgs e)
        {
            NewNumber.InsertEnd('3');
        }
        private void button_4_Click(object sender, EventArgs e)
        {
            NewNumber.InsertEnd('4');
        }
        private void button_5_Click(object sender, EventArgs e)
        {
            NewNumber.InsertEnd('5');
        }
        private void button_6_Click(object sender, EventArgs e)
        {
            NewNumber.InsertEnd('6');
        }
        private void button_7_Click(object sender, EventArgs e)
        {
            NewNumber.InsertEnd('7');
        }
        private void button_8_Click(object sender, EventArgs e)
        {
            NewNumber.InsertEnd('8');
        }
        private void button_9_Click(object sender, EventArgs e)
        {
            NewNumber.InsertEnd('9'); 
        }
        private void button_Number_Click(object sender, EventArgs e)
        {
            if (chosen == _Operator.None && Result.str != "") Result.Clear();
            display_newNumber();
        }
        private void button_dot_Click(object sender, EventArgs e)
        {
            if (NewNumber.dot == true) return;
            if (NewNumber.str == "") NewNumber.InsertEnd('0');
            NewNumber.InsertEnd('.');
            NewNumber.dot = true ;
        }

        private void button_ClearEntry_Click(object sender, EventArgs e)
        {
            NewNumber.Clear();
            Result_TextBox.Text = "0";
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            NewNumber.Clear();
            Result.Clear();
            Result_TextBox.Text = "0";
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            chosen = _Operator.Add;
            update_buttonOpClick();
        }
        private void button_sub_Click(object sender, EventArgs e)
        {
            chosen = _Operator.Sub;
            update_buttonOpClick();

        }

        private void button_Mult_Click(object sender, EventArgs e)
        {
            chosen = _Operator.Mult;
            update_buttonOpClick();

        }

        private void button_Div_Click(object sender, EventArgs e)
        {
            chosen = _Operator.Div;
            update_buttonOpClick();

        }
        private void update_buttonOpClick()
        {
            if (Result.str == "") Result.dble = NewNumber.dble;
            NewNumber.Clear();
            Result_TextBox.Text = "0";
        }
        private void button_Backspace_Click(object sender, EventArgs e)
        {
            if (NewNumber.isEmpty()) return;
            NewNumber.RemoveEnd();
            display_newNumber();
        }

        private void button_Reversion_Click(object sender, EventArgs e)
        {
            if (NewNumber.dble == 0) throw new Exception("Div 0");
            Result.dble = 1f / NewNumber.dble;
            Result_TextBox.Text = Result.str;
        }
        private void button_Sqrt_Click(object sender, EventArgs e)
        {
            Result.dble = Math.Sqrt(NewNumber.dble);
            Result_TextBox.Text = Result.str;
        }
        private void button_div100_Click(object sender, EventArgs e)
        {
            Result.dble = NewNumber.dble/100f;
            Result_TextBox.Text = Result.str;
        }

        private void button_memoryClear_Click(object sender, EventArgs e)
        {
            MemoryData.dble = 0;
        }

        private void button_memoryRecall_Click(object sender, EventArgs e)
        {
            Result_TextBox.Text = MemoryData.str;
            Result.dble = MemoryData.dble;
        }

        private void button_memoryStore_Click(object sender, EventArgs e)
        {
            MemoryData.dble = double.Parse(Result_TextBox.Text);
        }

        private void button_memoryAdd_Click(object sender, EventArgs e)
        {
            MemoryData.dble += double.Parse(Result_TextBox.Text);
            Result_TextBox.Text = MemoryData.str;
            Result.dble = MemoryData.dble;
        }

        private void button_PosNeg_Click(object sender, EventArgs e)
        {
            NewNumber.dble *= -1;
            display_newNumber();
        }



        private void button_Equal_Click(object sender, EventArgs e)
        {
            updateResult(chosen);
            chosen = _Operator.None;
        }

        private void display_newNumber()
        {
            Result_TextBox.Text = NewNumber.str;
        }
        private void updateResult(_Operator op)
        {
            switch (op)
            {
                case _Operator.Add:
                    Result.dble = (Result.dble + NewNumber.dble);
                    break;
                case _Operator.Sub:
                    Result.dble = (Result.dble - NewNumber.dble);
                    break;
                case _Operator.Mult:
                    Result.dble = (Result.dble * NewNumber.dble);
                    break;
                case _Operator.Div:
                    if (NewNumber.dble == 0) throw new Exception("Div 0");
                    Result.dble = (Result.dble / NewNumber.dble);
                    break;
                default: break;
            }
            Result_TextBox.Text = Result.str;
            NewNumber.Clear();
        }
    }
}
