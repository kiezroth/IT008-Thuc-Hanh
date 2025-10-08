using System.Text;
using System.Text.RegularExpressions;

namespace Bai04
{

  internal class Program
  {
    static void Main(string[] args)
    {
      Console.OutputEncoding = Encoding.UTF8;
      Console.Write("Nhập tháng và năm (mm/yyyy): ");
      string? DateInput = Console.ReadLine();
      if (is_valid(DateInput))
      {
        int m = Convert.ToInt32(DateInput!.Substring(0, 2));
        int y = Convert.ToInt32(DateInput!.Substring(3, 4));
        int Count = 0;
        if (m != 2 || y % 4 != 0 || (y % 100 == 0 && y % 400 != 0))
          Count = day_Of_month[m - 1];
        else
          Count = day_Of_month[1] + 1;
        Console.WriteLine("Tháng {0} năm {1} có {2} ngày", m, y, Count);
      }
      else
        Console.WriteLine("Dữ liệu nhập vào không hợp lệ");
    }

    static int[] day_Of_month = new int[12] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
    static bool is_valid(string? Date)
    {
      if (Date == null) return false;
      Regex dmy = new Regex(@"^(0[1-9]|1[0-2])/([0-9]{4})$");
      if (!dmy.IsMatch(Date)) return false;
      return true;
    }

  }
}
