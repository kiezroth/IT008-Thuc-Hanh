using System.Text;

namespace Bai02
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.OutputEncoding = Encoding.UTF8;
      Console.Write("Nhập số nguyên dương n = ");
      int n;
      do
      {
        if (!int.TryParse(Console.ReadLine(), out n))
        {
          Console.Write("Dữ liệu không hợp lệ\n" + "Nhập lại số nguyên dương n: ");
          continue;
        }
        if (n <= 0)
          Console.Write("Dữ liệu không hợp lệ\n" + "Nhập lại số nguyên dương n: ");
      } while (n <= 0);

      int s = 0;
      if (n > 2) s = 2;
      for (int i = 3; i < n; i += 2)
        s += (is_Prime(i) ? i : 0);
      Console.WriteLine("Tổng các số nguyên tố nhỏ hơn n là: {0}", s);
    }
    static bool is_Prime(int n)
    {
      if (n < 2) return false;
      for (int i = 2; i * i <= n; i++)
        if (n % i == 0) return false;
      return true;
    }
  }
}
