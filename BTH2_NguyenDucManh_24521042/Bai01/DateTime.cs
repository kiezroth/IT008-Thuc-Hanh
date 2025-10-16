using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Bai01
{
    class DateTime
    {
        private int month;
        private int year;
        static Regex rex1 = new Regex(@"^(0[1-9]|1[0-2])/([0-9]{4})$");
        static Regex rex2 = new Regex(@"^([1-9]|1[0-2])/([0-9]{4})$");
        static int[] day_Of_month = new int[12] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        public enum Weekday
        {
            Sun,
            Mon,
            Tue,
            Wed,
            Thu,
            Fri,
            Sat
        }
        public DateTime()
        {
            month = 1;
            year = 1900;
        }
        public void ReadInput()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập tháng năm (mm/yyyy): ");
            string? dateStr;
            do
            {
                dateStr = Console.ReadLine();
                if (!IsValid(dateStr!))
                    Console.Write("Nhập lại: ");
                else
                {
                    Transfer(dateStr!);
                    return;
                }
            } while (true);
        }
        public bool IsValid(string dateStr)
        {
            if (dateStr == null) return false;
            if (!rex1.IsMatch(dateStr) && !rex2.IsMatch(dateStr)) 
                return false;
            return true;
        }
        private bool Transfer(string dateStr)
        {
            if (!IsValid(dateStr)) return false;
            int m = 0, y = 0;
            bool change = false;
            foreach (char c in dateStr)
            {
                if (c == '/') change = true;
                else
                    if (!change) m = m * 10 + int.Parse("" + c);
                else
                    y = y * 10 + int.Parse("" + c);
            }
            month = m;
            year = y;
            return true;
        }
        public Weekday GetFirstDay()
        {
            int d = 1, m = month, y = year;
            int Jday = (d + ((153 * (m + 12 * ((14 - m) / 12) - 3) + 2) / 5)
              + (365 * (y + 4800 - ((14 - m) / 12)))
              + ((y + 4800 - ((14 - m) / 12)) / 4)
              - ((y + 4800 - ((14 - m) / 12)) / 100)
              + ((y + 4800 - ((14 - m) / 12)) / 400) - 32045) % 7;
            switch (Jday)
            {
                case 0: return Weekday.Mon;
                case 1: return Weekday.Tue;
                case 2: return Weekday.Wed;
                case 3: return Weekday.Thu;
                case 4: return Weekday.Fri;
                case 5: return Weekday.Sat;
                case 6: return Weekday.Sun;
                default: return Weekday.Mon;
            }
        }
        public int CountDay()
        {
            int Count = 0;
            if (month != 2 || year % 4 != 0 || (year % 100 == 0 && year % 400 != 0))
                Count = day_Of_month[month - 1];
            else
                Count = day_Of_month[1] + 1;
            return Count;
        }
        public void printCalendar()
        {
            Weekday FirstDay = GetFirstDay();
            int Count = CountDay();
            Console.WriteLine("{0}   {1}   {2}   {3}   {4}   {5}   {6}",
                Weekday.Sun, Weekday.Mon, Weekday.Tue,
                Weekday.Wed,Weekday.Thu,Weekday.Fri,Weekday.Sat);
            int i = 0;
            for (i = 0; i <= Convert.ToInt32(FirstDay) - 1; i++)
                Console.Write("      ");
            for (int k = 1; k <= Count; k++, i++)
            {
                if (i % 7 == 0) Console.WriteLine();
                Console.Write($"{k,3}   ");
            }
        }
    }
}
