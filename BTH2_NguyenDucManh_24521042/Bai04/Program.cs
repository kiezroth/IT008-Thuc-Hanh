namespace Bai04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            // Nhập 2 phân số, Xuất tổng, hiệu, tích và thương của 2 phân số
            cPhanSo a = new cPhanSo(),
                    b = new cPhanSo();
            Console.WriteLine("Nhập phân số A");
            a.NhapPhanSo();
            Console.WriteLine("Nhập phân số B");
            b.NhapPhanSo();
            Console.WriteLine("{0} + {1} = {2}", a.ToString(), b.ToString(), (a + b).ToString());
            Console.WriteLine("{0} - {1} = {2}", a.ToString(), b.ToString(), (a - b).ToString());
            Console.WriteLine("{0} * {1} = {2}", a.ToString(), b.ToString(), (a * b).ToString());
            Console.WriteLine("{0} / {1} = {2}", a.ToString(), b.ToString(), (a / b).ToString());
            Console.WriteLine("\n\n");

            //Nhập dãy phân số, sắp xếp tăng dần
            Console.WriteLine("=========================================");
            cListPhanSo ListPS = new cListPhanSo();
            Console.WriteLine("NHẬP MẢNG PHÂN SỐ");
            ListPS.Nhap();
            ListPS.Xuat();
            Console.WriteLine();
            Console.WriteLine("Phân số lớn nhất trong mảng là {0}", ListPS.findMax().ToString());
            ListPS.Sort_Tang();
            Console.WriteLine("Mảng sau khi sắp xếp tăng dần: ");
            ListPS.Xuat();            
            

        }
    }
}
