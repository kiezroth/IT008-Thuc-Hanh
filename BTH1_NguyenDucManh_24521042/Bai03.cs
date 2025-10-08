using System.Text;
using System.Text.RegularExpressions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Bai03
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.OutputEncoding = Encoding.UTF8;
      Console.Write("Nhập ngày tháng năm (dd/mm/yyyy): ");
      string? DateInput = Console.ReadLine();
      if (is_valid(DateInput))
        Console.WriteLine("Ngày nhập hợp lệ");
      else
        Console.WriteLine("Ngày nhập không hợp lệ");
    }
    static int[] day_Of_month = new int[12] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
    static bool is_valid(string? Date)
    {
      if (Date == null) return false;
      Regex dmy = new Regex(@"^(0[1-9]|[12][0-9]|3[01])/(0[1-9]|1[0-2])/([0-9]{4})$");
      if (!dmy.IsMatch(Date)) return false;
      int d = Convert.ToInt32(Date.Substring(0, 2));
      int m = Convert.ToInt32(Date.Substring(3, 2));
      int y = Convert.ToInt32(Date.Substring(6, 4));
      if (y % 4 != 0 || (y % 100 == 0 && y % 400 != 0))
      {
        if (d > day_Of_month[m - 1]) return false;
      }
      else
      if (m == 2)
      {
        if (d > 29) return false;
      }
      else
          if (d > day_Of_month[m - 1]) return false;
      return true;
    }


  }
}
