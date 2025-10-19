namespace Bai05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            listBDS danhsach = new listBDS();
            danhsach.NhapDanhSach();
            Console.Clear();
            danhsach.XuatDanhSach();

            Console.WriteLine("Tổng giá loại hình Khu đất: {0} ",danhsach.TongGia(loaiBDS.HinhThucBDS.Dat));
            Console.WriteLine("Tổng giá loại hình Nhà phố: {0} ", danhsach.TongGia(loaiBDS.HinhThucBDS.Nha));
            Console.WriteLine("Tổng giá loại hình Chung cư: {0} ", danhsach.TongGia(loaiBDS.HinhThucBDS.chungCu));

            Console.ReadLine();
            Console.Clear();
            danhsach.XuatDanhSach_CoDK();

            Console.ReadLine();
            Console.Clear();
            danhsach.XuatDanhSach_ThoaManTimKiem();
        }
    }
}
