using System.Collections.Specialized;
using System.Text;
using System.Text.RegularExpressions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Bai05
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.OutputEncoding = Encoding.UTF8;
      Console.Write("Nhập ngày tháng năm (dd/mm/yyyy): ");
      string? DateInput = Console.ReadLine();
      if (!Is_valid(DateInput))
      {
        Console.WriteLine("DỮ liệu nhập vào không hợp lệ");
        return;
      }
      int d = Convert.ToInt32(DateInput!.Substring(0, 2));
      int m = Convert.ToInt32(DateInput!.Substring(3, 2));
      int y = Convert.ToInt32(DateInput!.Substring(6, 4));
      Console.WriteLine("Ngày {0} Tháng {1} Năm {2} là {3}", d, m, y, GetDay(DateInput));
    }

    static string[] dayOfWeek = new string[7] { "Thứ 2", "Thứ 3", "Thứ 4", "Thứ 5", "Thứ 6", "Thứ 7", "Chủ Nhật" };
    static int[] day_Of_month = new int[12] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
    static bool Is_valid(string? Date)
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
    static string GetDay(string Date)
    {
      int d = Convert.ToInt32(Date.Substring(0, 2));
      int m = Convert.ToInt32(Date.Substring(3, 2));
      int y = Convert.ToInt32(Date.Substring(6, 4));
      int Jday = (d + ((153 * (m + 12 * ((14 - m) / 12) - 3) + 2) / 5)
      + (365 * (y + 4800 - ((14 - m) / 12)))
      + ((y + 4800 - ((14 - m) / 12)) / 4)
      - ((y + 4800 - ((14 - m) / 12)) / 100)
      + ((y + 4800 - ((14 - m) / 12)) / 400) - 32045) % 7;
      return dayOfWeek[Jday];
    }

  }
}
