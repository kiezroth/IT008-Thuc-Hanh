using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai05
{
    class KhuDat : loaiBDS
    {
        public KhuDat() { }
        public override void Xuat()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("====Khu Đất====");
            base.Xuat();
        }
        public override HinhThucBDS getLoai()
        {
            return HinhThucBDS.Dat;
        }
    }
}
