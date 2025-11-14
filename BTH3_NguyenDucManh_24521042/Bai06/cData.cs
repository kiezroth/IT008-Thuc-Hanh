using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Bai06
{
    public class cData
    {
        string text;
        bool haveDot;
        public cData()
        {
            text = "";
            haveDot = false;
        }
        public double dble
        {
            get
            {
                if (text.Length == 0) return 0;
                if (text.Length > 18)
                    throw new Exception("Dữ liệu dài");
                return double.Parse(text);
            }
            set
            {
                double rounded = Math.Round(value, 7);
                string formatted = rounded.ToString("0.#######");
                text = formatted;
                value = 0;
            }
        }
        public bool dot
        {
            get { return haveDot; }
            set { haveDot = value; }
        }
        public string str { get { return text; } }
        public void InsertEnd(char key)
        {
            if (text.Length > 12) return;
            text += key;
        }
        public void RemoveEnd()
        {
            if (string.IsNullOrEmpty(text))
                return;
            text = text.Remove(text.Length - 1);
        }
        public void Clear()
        {
            text = "";
            haveDot = false;
        }
        
        public bool isEmpty()
        {
            return text.Length == 0;
        }
    }
}
