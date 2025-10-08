using System.Collections.Specialized;
using System.Text;

namespace Bai01
{
  internal class Program
  {

    static void Main(string[] args)
    {
      Console.OutputEncoding = Encoding.UTF8;
      Console.Write("Nhập số lượng phần tử của mảng: ");
      int n;
      do
      {
        if (!int.TryParse(Console.ReadLine(), out n))
        {
          Console.Write("Dữ liệu không hợp lệ\n" + "Nhập lại số phần tử của mảng: ");
          continue;
        }
        if (n <= 0)
          Console.Write("Dữ liệu không hợp lệ\n" + "Nhập lại số phần tử của mảng: ");
      } while (n <= 0);
      RandomArray(n, out int[] arr);

      int choice;
      do
      {
        printMenu();
        if (!int.TryParse(Console.ReadLine(), out choice))
        {
          Console.WriteLine("Nhập sai cú pháp");
          choice = -1;
          continue;
        }
        switch (choice)
        {
          case 1:
            PrintArray(arr);
            break;
          case 2:
            Console.WriteLine("Tổng các số lẻ trong mảng: {0}", Sum_Of_Odd(arr));
            break;
          case 3:
            Console.WriteLine("Mảng có {0} số nguyên tố", Count_Prime(arr));
            break;
          case 4:
            Console.WriteLine("Số chính phương nhỏ nhất trong mảng là {0}", Min_Square(arr));
            break;
          case 0:
            Console.WriteLine("Thoát chương trình thành công!");
            break;
          default:
            Console.WriteLine("Nhập sai cú pháp");
            break;
        }
      } while (choice != 0);
    }
    static void printMenu()
    {
      Console.WriteLine("\n\n===== Danh sách lựa chọn =====");
      Console.WriteLine("1. Xuất mảng");
      Console.WriteLine("2. Tính tổng các số lẻ trong mảng");
      Console.WriteLine("3. Đếm số nguyên tố trong mảng");
      Console.WriteLine("4. Tìm số chính phương nhỏ nhất");
      Console.WriteLine("0. Thoát\n");
    }

    static Random rnd = new Random();
    static void RandomArray(int n, out int[] arr)
    {
      arr = new int[n];
      for (int i = 0; i < n; i++)
        arr[i] = rnd.Next(100);
    }
    static void PrintArray(int[] arr)
    {
      if (arr.Length == 0)
        Console.WriteLine("Mảng rỗng");
      foreach (int p in arr)
        Console.Write(p + " ");
    }
    static bool is_Prime(int n)
    {
      if (n < 2) return false;
      for (int i = 2; i * i <= n; i++)
        if (n % i == 0) return false;
      return true;
    }
    static int Sum_Of_Odd(int[] arr)
    {
      int s = 0;
      foreach (int p in arr)
        s += (p % 2 == 0 ? 0 : p);
      return s;
    }
    static int Count_Prime(int[] arr)
    {
      int count = 0;
      foreach (int p in arr)
        count += (is_Prime(p) ? 1 : 0);
      return count;
    }
    static bool is_Square(int p)
    {
      double dp = (Math.Sqrt(p));
      if (dp * dp == 1.0 * p) return true;
      return false;
    }
    static int Min_Square(int[] arr)
    {
      int Min = int.MaxValue;
      for (int i = 0; i < arr.Length; i++)
        if (Min > arr[i] && is_Square(arr[i]))
          Min = arr[i];

      if (Min == int.MaxValue) return -1;
      return Min;
    }
  }
}
