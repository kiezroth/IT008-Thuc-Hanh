using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai05
{
    class listBDS
    {
        private List<loaiBDS> QuanLy;

        public listBDS()
        {
            QuanLy = new List<loaiBDS>();
        }
        public listBDS(List<loaiBDS> list)
        {
            QuanLy = list;
        }
        private static int inputInt()
        {
            int n;
            if (!int.TryParse(Console.ReadLine(), out n))
                throw new InvalidDataException("Dữ liệu không phù hợp");
            return n;
        }

        public void NhapDanhSach()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập số lượng bất động sản cần quản lý: ");
            int n = inputInt();
            for (int i = 0; i < n; i++)
            {
                Console.Write("===================\n"
                                  + "Chọn loại hình kinh doanh (1. Khu đất, 2. Nhà phố, 3. Chung cư): ");
                int type = inputInt();
                loaiBDS loaiBDS = new loaiBDS();
                switch (type)
                {
                    case 1: loaiBDS = new KhuDat(); break;
                    case 2: loaiBDS = new NhaPho(); break;
                    case 3: loaiBDS = new ChungCu(); break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ");
                        throw new ArgumentOutOfRangeException("Phạm vi dữ liệu sai");
                }
                loaiBDS.Nhap();
                QuanLy.Add(loaiBDS);
                        
            }
        }
        public void XuatDanhSach()
        {
            foreach (var item in QuanLy)
            {
                item.Xuat();
                Console.WriteLine();
            }
        }

        public Int64 TongGia(loaiBDS.HinhThucBDS loai)
        {
            Int64 sum = 0;
            foreach (var item in QuanLy)
            {
                if (item.getLoai() == loai)
                    sum += item.Gia;
            }
            return sum;
        }


        public void XuatDanhSach_CoDK()
        {
            /* 
                Xuất danh sách các khu đất có diện tích > 100m2 
                hoặc là nhà phố mà có diện tích >60m2 và năm xây dựng >= 2019.
            */
            Console.WriteLine("Danh sách các khu đất có diện tích > 100m2 " +
                              "hoặc là nhà phố mà có diện tích >60m2 và năm xây dựng >= 2019.");
            foreach (var item in QuanLy)
            {
                if (item.getLoai() == loaiBDS.HinhThucBDS.Dat && item.dienTich > 100)
                {
                    item.Xuat();
                    Console.WriteLine();
                }
                if (item.getLoai() == loaiBDS.HinhThucBDS.Nha && item.dienTich > 60 && item.namXay >= 2019)
                {
                    item.Xuat();
                    Console.WriteLine();
                }
            }
        }

        public void XuatDanhSach_ThoaManTimKiem()
        {

            Console.WriteLine("Nhập thông tin tìm kiếm");

            string dd;
            Console.Write("1. Địa điểm: ");
            dd = Console.ReadLine()!;
            if (dd == "")
                throw new InvalidDataException("Dữ liệu trống");

            Console.Write("2. Giá bán: ");
            int gia = int.Parse(Console.ReadLine()!);

            Console.Write("3. Diện tích: ");
            double dt = double.Parse(Console.ReadLine()!);
            Console.WriteLine();
            Console.WriteLine("Danh sách tìm kiếm phù hợp");
            foreach (var item in QuanLy)
                if (item.suitableSearching(dd, gia, dt))
                {
                    item.Xuat();
                    Console.WriteLine();
                }
        }
    }
   
}
