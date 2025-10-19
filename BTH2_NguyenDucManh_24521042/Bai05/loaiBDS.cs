using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai05
{
    class loaiBDS
    {
        protected string DiaDiem;
        protected int GiaBan;
        protected double DienTich;
        public loaiBDS(string dd = "", int gia = 1, double dt = 1f)
        {
            if (gia <= 0 || dt <= 0)
                throw new ArgumentOutOfRangeException("Phạm vi dữ liệu không phù hợp");
            DiaDiem = dd;
            GiaBan = gia;
            DienTich = dt;
        }
        public string diaDiem { get { return DiaDiem; } }
        public int Gia
        {
            get { return GiaBan; }
        }
        public double dienTich
        {
            get { return DienTich; }
        }

        public virtual short namXay {  get { return 0; } }
        public enum HinhThucBDS
        {
            None,
            Dat,
            Nha,
            chungCu
        }
        protected static int inputInt()
        {
            int n;
            if (!int.TryParse(Console.ReadLine(), out n))
                throw new InvalidDataException("Dữ liệu không phù hợp");

            if (n <= 0)
                throw new ArgumentOutOfRangeException("Phạm vi dữ liệu không phù hợp");
            return n;
        }
        protected static short inputShort()
        {
            short n;
            if (!short.TryParse(Console.ReadLine(), out n))
                throw new InvalidDataException("Dữ liệu không phù hợp");
            if (n <= 0)
                throw new ArgumentOutOfRangeException("Phạm vi dữ liệu không phù hợp");
            return n;
        }
        protected static double inputDouble()
        {
            double n;
            if (!double.TryParse(Console.ReadLine(), out n))
                throw new InvalidDataException("Dữ liệu không phù hợp");
            if (n <= 0)
                throw new ArgumentOutOfRangeException("Phạm vi dữ liệu không phù hợp");
            return n;
        }

        public bool suitableSearching(string dd, int gia, double dt)
        {
            /*
                Địa điểm chứa chuỗi tìm kiếm không phân biệt hoa thường, có giá <= giá tìm
                kiếm, và diện tích >= diện tích cần tìm kiếm 
            */
            if (!dd.Equals(DiaDiem, StringComparison.OrdinalIgnoreCase)) return false;
            if (Gia > gia) return false;
            if (DienTich < dt) return false;
            return true;

        }
        public virtual void Nhap()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập địa điểm: ");
            DiaDiem = Console.ReadLine()!;

            Console.Write("Nhập giá bán (VND): ");
            GiaBan = inputInt();

            Console.Write("Nhập diện tích (m2): ");
            DienTich = inputDouble();
        }

        public virtual void Xuat()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine($"Địa điểm: {DiaDiem}");
            Console.WriteLine($"Giá bán: {GiaBan:N0} VND");
            Console.WriteLine($"Diện tích: {DienTich} m2");
        }

        public virtual HinhThucBDS getLoai()
        {
            return HinhThucBDS.None;
        }
    }
}
