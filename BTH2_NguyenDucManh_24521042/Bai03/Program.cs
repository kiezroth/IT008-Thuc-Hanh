namespace Bai03
{
    internal class Program
    {
        static cMatrix matr = new cMatrix();
        static void Main(string[] args)
        {
            matr.NhapMatrix();

            XuatMenu();
            int choice;
            do
            {
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Lựa chọn không hợp lệ vui lòng chọn lại: ");
                    continue;
                }

                doWorkChoice(choice);
            } while (choice != 0) ;
        }

        static void XuatMenu()
        {
            Console.WriteLine("=== Menu ===");
            Console.WriteLine("1. Xuất ma trận");
            Console.WriteLine("2. Tìm kiếm phần tử");
            Console.WriteLine("3. Xuất các phần tử là số nguyên tố");
            Console.WriteLine("4. Tìm dòng có nhiều số nguyên tố nhất");
            Console.WriteLine("0.-- Thoát chương trình --");
        }

        static void doWorkChoice(int choice)
        {
            switch (choice)
            {
                case 1:
                    matr.XuatMatrix();
                    break;
                case 2:
                    int n = int.Parse(Console.ReadLine()!);
                    if (matr.isFoundInMatrix(n))
                        Console.WriteLine("Phần tử tồn tại trong ma trận");
                    else
                        Console.WriteLine("Phần tử không tồn tại trong ma trận");
                    break;
                case 3:
                    matr.XuatSoNguyenTo();
                    Console.WriteLine();
                    break;
                case 4:
                    matr.Find_Rows_has_MaxCountPrime();
                    break;
                case 0:
                    Console.WriteLine("Thoát chương trình thành công");
                    return;
                default: break;
            }
        }
    }
}
