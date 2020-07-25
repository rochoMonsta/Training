using System;
using System.Linq;

namespace CountOfDays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(UnluckyDays(1986));
            Console.ReadLine();
        }
        public static int UnluckyDays(int year)
        {
            return Enumerable.Range(1, 12).Select(x => new DateTime(year, x, 13)).Count(x => x.DayOfWeek == DayOfWeek.Friday);
        }
        public static int UnluckyDays(int year, DayOfWeek dayOfWeek)
        {
            return Enumerable.Range(1, 12).Select(x => new DateTime(year, x, 13)).Count(x => x.DayOfWeek == dayOfWeek);
        }
    }
}
