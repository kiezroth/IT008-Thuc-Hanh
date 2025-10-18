using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Bai04
{
    class cPhanSo : IComparable<cPhanSo>
    {
        public int Tu { get; set; }
        public int Mau { get; set; }
        static Regex regPhanSo = new Regex( "^\\s*(?<TuSo>[+-]?\\d+)\\s*/\\s*(?<MauSo>[+-]?\\d+)\\s*$" );
        static Regex regInt = new Regex("\\s*(?<TuSo>[+-]?\\d+)\\s*$");
        public cPhanSo(int tu = 0, int mau = 1)
        {
            Tu = tu;
            Mau = mau;
            if (mau == 0)
                throw new DivideByZeroException("Không chia cho 0");
            RutGon();
        }

        private void RutGon()
        {
            int n = UCLN(Math.Abs(Tu), Math.Abs(Mau));
            Tu /= n;
            Mau /= n;
            if (Mau < 0)
            {
                Tu = -Tu;
                Mau = -Mau;
            }
        }

        private int UCLN(int a, int b)
        {
            while (b != 0)
            {
                int tmp = a % b;
                a = b;
                b = tmp;
            }
            return a;
        }
        private int readInt(string input)
        {
            int _Convert;
            if (!int.TryParse(input, out _Convert))
                throw new InvalidDataException("Dữ liệu nhập vào không phải số nguyên");
            return _Convert;
        }
        public void NhapPhanSo()
        {
            string s = Console.ReadLine()!;
            Match matchInt = regInt.Match(s),
                  matchPhanSo = regPhanSo.Match(s);
            if (matchInt.Success && matchInt.Value.Length == s.Length)
            {
                Tu = readInt(matchInt.Groups["TuSo"].Value);
                Mau = 1;
            }
            else if (matchPhanSo.Success && matchPhanSo.Value.Length == s.Length)
            {
                Tu = readInt(matchPhanSo.Groups["TuSo"].Value);
                Mau = readInt(matchPhanSo.Groups["MauSo"].Value);
            }
            else
            {
                Console.WriteLine("Phân số không hợp lệ");
                throw new InvalidDataException("Không phải phân số");
            }
            if (Mau == 0)
                throw new DivideByZeroException("Không chia cho 0");
            RutGon();
        }
        public static cPhanSo operator +(cPhanSo a, cPhanSo b)
        {
            return new cPhanSo(a.Tu * b.Mau + b.Tu * a.Mau, a.Mau * b.Mau);
        }
        public static cPhanSo operator -(cPhanSo a, cPhanSo b)
        {
            return new cPhanSo(a.Tu * b.Mau - b.Tu * a.Mau, a.Mau * b.Mau);
        }
        public static cPhanSo operator *(cPhanSo a, cPhanSo b)
        {
            return new cPhanSo(a.Tu * b.Tu, a.Mau * b.Mau);
        }
        public static cPhanSo operator /(cPhanSo a, cPhanSo b)
        {
            if (b.Tu == 0) throw new DivideByZeroException("Không chia cho 0");
            return new cPhanSo(a.Tu * b.Mau, a.Mau * b.Tu);
        }

        public int CompareTo(cPhanSo? other)
        {
            if(other==null) throw new ArgumentNullException("Null Other");
            double val1 = (double)Tu / Mau;
            double val2 = (double)other.Tu / other.Mau;
            return val1.CompareTo(val2);
        }

        public override string ToString()
        {
            if (Mau == 1)
            {
                if (Tu < 0)
                    return $"({Tu})";
                return $"{Tu}";
            }
            if (Tu < 0)
                return $"({Tu}/{Mau})";
            return $"{Tu}/{Mau}";
        }
    }
}
