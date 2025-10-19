using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai05
{
    class NhaPho: loaiBDS
    {
        private short namXayDung;
        private short soTang;
        public NhaPho() { namXayDung = soTang = 0; }
        public NhaPho(string dd, int gia, double dt, short nam, short tang) : base(dd, gia, dt)
        {
            if (nam <= 0 || tang <= 0)
                throw new ArgumentOutOfRangeException("Phạm vi dữ liệu không phù hợp");

            namXayDung = nam;
            soTang = tang;
        }

        public override short namXay { get { return namXayDung; } }
        public override void Nhap()
        {
            Console.OutputEncoding = Encoding.UTF8;
            base.Nhap();
            Console.Write("Nhập năm xây dựng: ");
            namXayDung = inputShort();

            Console.Write("Nhập số tầng: ");
            soTang = inputShort();

        }

        public override void Xuat()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("=== Nhà phố ===");
            base.Xuat();
            Console.WriteLine($"Năm xây dựng: {namXayDung}");
            Console.WriteLine($"Số tầng: {soTang}");
        }
        public override HinhThucBDS getLoai()
        {
            return HinhThucBDS.Nha;
        }
    }
}
