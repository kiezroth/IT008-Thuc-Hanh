using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Bai06
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.OutputEncoding = Encoding.UTF8;
      int[,] arr;
      Console.WriteLine("NHẬP KÍCH THƯỚC BẢNG");
      if (!ReadInput(out arr))
      {
        Console.WriteLine("Dữ liệu nhập vào không hợp lệ");
        return;
      }
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
          case 1: PrintArray(arr); break;
          case 2: Console.WriteLine("Phần tử lớn nhất (MAX) trong mảng có giá trị là: {0} ", GetMax(arr)); break;
          case 3: Console.WriteLine("Phần tử nhỏ nhất (MIN) trong mảng có giá trị là: {0} ", GetMin(arr)); break;
          case 4:
            Tuple<int, int> RowMax = GetMaxSum_Of_Row(arr);
            Console.WriteLine("Dòng {0} có tổng giá trị lớn nhất là: {1}", RowMax.Item2, RowMax.Item1);
            break;
          case 5: Console.WriteLine("Tổng các số không phải số nguyên tố là: {0}", GetSum_NonPrime(arr)); break;
          case 6:
            if (arr.Length == 0)
            {
              Console.WriteLine("Bảng rỗng");
              break;
            }
            Console.Write("Nhập dòng muốn xoá khỏi bảng: ");
            int RowToDelete;
            do
            {
              if (!int.TryParse(Console.ReadLine(), out RowToDelete))
              {
                Console.Write("Dữ liệu không hợp lệ\n" + "Nhập lại số dòng: ");
                continue;
              }
              if (DeleteRow(ref arr, RowToDelete)) break;
              else Console.Write("Số dòng không hợp lệ\n" + "Nhập lại số dòng: ");
            } while (true);
            if (DeleteRow(ref arr, RowToDelete))
            {
              Console.WriteLine("Bảng sau khi xoá dòng {0}:", RowToDelete);
              PrintArray(arr);
            }
            break;
          case 7:
            if (Delete_MaxSumColumn(ref arr, out Tuple<int, int> OldColumnMax))
            {
              Console.WriteLine("Cột {0} có tổng giá trị lớn nhất là: {1}", OldColumnMax.Item2, OldColumnMax.Item1);
              Console.WriteLine("Bảng sau khi xoá cột {0}:", OldColumnMax.Item2);
              PrintArray(arr);
            }
            else
              Console.WriteLine("Bảng rỗng");
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
    static Random rnd = new Random();
    static void printMenu()
    {
      Console.WriteLine("\n\n===== Danh sách lựa chọn =====");
      Console.WriteLine("1. Xuất ma trận");
      Console.WriteLine("2. Tìm phần tử lớn nhất");
      Console.WriteLine("3. Tìm phần tử nhỏ nhất");
      Console.WriteLine("4. Tìm dòng có tổng lớn nhất");
      Console.WriteLine("5. Tính tổng các số không phải là số nguyên tố");
      Console.WriteLine("6. Xóa dòng thứ k trong ma trận");
      Console.WriteLine("7. Xóa cột chứa phần tử lớn nhất trong ma trận");
      Console.WriteLine("0. Thoát\n");
    }
    static bool ReadInput(out int[,] arr)
    {
      int n, m;
      Console.Write("Nhập số dòng: ");
      int.TryParse(Console.ReadLine(), out n);
      Console.Write("Nhập số cột: ");
      int.TryParse(Console.ReadLine(), out m);
      if (n < 1 || m < 1)
      {
        arr = new int[0, 0];
        return false;
      }
      arr = new int[n, m];
      for (int i = 0; i < n; i++)
        for (int j = 0; j < m; j++)
          arr[i, j] = rnd.Next(100);
      return true;
    }
    static void PrintArray(int[,] arr)
    {
      if (arr.Length == 0)
      {
        Console.WriteLine("Bảng rỗng!");
        return;
      }
      int n = arr.GetLength(0),
      m = arr.GetLength(1);
      for (int i = 0; i < arr.GetLength(0); i++)
      {
        for (int j = 0; j < arr.GetLength(1); j++)
          Console.Write("{0} ", arr[i, j]);
        Console.WriteLine();
      }
    }
    static int GetMax(int[,] arr)
    {
      int Max = int.MinValue;
      int n = arr.GetLength(0),
      m = arr.GetLength(1);
      for (int i = 0; i < n; i++)
        for (int j = 0; j < m; j++)
          Max = Math.Max(arr[i, j], Max);
      return Max;
    }
    static int GetMin(int[,] arr)
    {
      int Min = int.MaxValue;
      int n = arr.GetLength(0),
      m = arr.GetLength(1);
      for (int i = 0; i < n; i++)
        for (int j = 0; j < m; j++)
          Min = Math.Min(arr[i, j], Min);
      return Min;
    }
    static Tuple<int, int> GetMaxSum_Of_Row(int[,] arr)
    {
      int MaxSum = int.MinValue;
      int Row = 0;
      int n = arr.GetLength(0),
      m = arr.GetLength(1);
      for (int i = 0; i < n; i++)
      {
        int s = 0;
        for (int j = 0; j < m; j++)
          s += arr[i, j];
        if (s > MaxSum)
        {
          MaxSum = s;
          Row = i + 1;
        }
      }
      return Tuple.Create(MaxSum, Row);
    }
    static Tuple<int, int> GetMaxSum_Of_Column(int[,] arr)
    {
      int MaxSum = int.MinValue;
      int Column = 0;
      int n = arr.GetLength(0),
      m = arr.GetLength(1);
      for (int j = 0; j < m; j++)
      {
        int s = 0;
        for (int i = 0; i < n; i++)
          s += arr[i, j];
        if (s > MaxSum)
        {
          MaxSum = s;
          Column = j + 1;
        }
      }
      return Tuple.Create(MaxSum, Column);
    }
    static bool Is_Prime(int n)
    {
      if (n < 2) return false;
      for (int i = 2; i * i <= n; i++)
        if (n % i == 0) return false;
      return true;
    }
    static int GetSum_NonPrime(int[,] arr)
    {
      int Sum = 0;
      int n = arr.GetLength(0),
      m = arr.GetLength(1);
      for (int i = 0; i < n; i++)
        for (int j = 0; j < m; j++)
          if (!Is_Prime(arr[i, j]))
            Sum += arr[i, j];
      return Sum;
    }
    static bool DeleteRow(ref int[,] arr, int k)
    {
      int n = arr.GetLength(0),
      m = arr.GetLength(1);
      if (k > n || k < 1) return false;
      int[,] newArr = new int[n - 1, m];
      int currentRow = 0;
      for (int i = 0; i < n; i++)
      {
        if (i != k - 1)
        {
          for (int j = 0; j < m; j++)
            newArr[currentRow, j] = arr[i, j];
          currentRow++;
        }
      }
      arr = newArr;
      return true;
    }
    static bool Delete_MaxSumColumn(ref int[,] arr, out Tuple<int, int> OldColumnMax)
    {
      OldColumnMax = GetMaxSum_Of_Column(arr);
      if (arr.Length == 0) return false;
      int n = arr.GetLength(0),
      m = arr.GetLength(1);
      int[,] newArr = new int[n, m - 1];
      int currentColumn = 0;
      for (int j = 0; j < m; j++)
      {
        if (j != OldColumnMax.Item2 - 1)
        {
          for (int i = 0; i < n; i++)
            newArr[i, currentColumn] = arr[i, j];
          currentColumn++;
        }
      }
      arr = newArr;
      return true;
    }
  }
}
