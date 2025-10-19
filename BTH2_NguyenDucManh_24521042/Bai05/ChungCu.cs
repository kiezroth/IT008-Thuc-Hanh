using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai05
{
    class ChungCu : loaiBDS
    {
        private short Tang;

        public ChungCu() { }

        public ChungCu(string dd, int gia, double dt, short tang)
            : base(dd, gia, dt)
        {
            if (tang <= 0)
                throw new ArgumentOutOfRangeException("Phạm vi dữ liệu không phù hợp");
            Tang = tang;
        }

        public override void Nhap()
        {
            Console.OutputEncoding = Encoding.UTF8;
            base.Nhap();
            Console.Write("Nhập tầng: ");
            Tang = inputShort();
        }

        public override void Xuat()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("=== Chung cư ===");
            base.Xuat();
            Console.WriteLine($"Tầng: {Tang}");
        }
        public override HinhThucBDS getLoai()
        {
            return HinhThucBDS.chungCu;
        }
    }
}
