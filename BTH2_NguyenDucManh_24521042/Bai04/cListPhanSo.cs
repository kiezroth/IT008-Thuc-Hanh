using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai04
{
    class cListPhanSo
    {
        List<cPhanSo> phanSoList;
        public cListPhanSo()
        {
            phanSoList = new List<cPhanSo>();
        }

        public void Nhap()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập số lượng: ");
            int n;
            do
            {
                if (!int.TryParse(Console.ReadLine(), out n))
                {
                    Console.Write("Số lượng không hợp lệ vui lòng nhập lại: ");
                }
            } while (n <= 0);
            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhập phân số thứ [{0}]: ", i + 1);
                cPhanSo newPS = new cPhanSo();
                newPS.NhapPhanSo();
                phanSoList.Add(newPS);
            }
        }
        public void Xuat()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("========================");
            foreach (var p in phanSoList)
            {
                Console.WriteLine(p.ToString());
            }
            Console.WriteLine("========================");
        }
        public cPhanSo findMax()
        {
            cPhanSo Max = new cPhanSo(-int.MaxValue);
            foreach (var ps in phanSoList)
            {
                if (ps.CompareTo(Max) > 0) 
                    Max = ps;
            }
            return Max;
        }
        public void Sort_Tang()
        {
            for (int i = 0; i < phanSoList.Count; i++)
                for (int j = 0; j < i; j++)
                {
                    if (phanSoList[i].CompareTo(phanSoList[j]) < 0)
                    {
                        cPhanSo temp = phanSoList[i];
                        phanSoList[i] = phanSoList[j];
                        phanSoList[j] = temp;
                    }
                }
        }
    }
}
