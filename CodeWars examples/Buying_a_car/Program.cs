using System;
using System.Diagnostics;

namespace Buying_a_car
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Diagnostics.Stopwatch sw = new Stopwatch();

            sw.Start();
            PrintArray(nbMonths(2000, 8000, 1000, 1.5));
            sw.Stop();

            Console.WriteLine(sw.ElapsedMilliseconds / 100.0);
            Console.ReadLine();
        }
        public static int[] nbMonths(int startPriceOld, int startPriceNew, int savingPerMonth, double percentLossByMonth)
        {
            if (startPriceOld > startPriceNew)
                return new int[] { 0, startPriceOld - startPriceNew };
            else
            {
                int month_count = 1, deposition = savingPerMonth;
                double preservation = 0, startPriceOld_d = startPriceOld, startPriceNew_d = startPriceNew;
                while (preservation < startPriceNew_d)
                {
                    preservation = 0;
                    if (month_count % 2 == 0)
                        percentLossByMonth += 0.5;

                    startPriceOld_d = (startPriceOld_d * ((100 - percentLossByMonth) / 100));
                    startPriceNew_d = (startPriceNew_d * ((100 - percentLossByMonth) / 100));

                    preservation = startPriceOld_d + deposition;
                    deposition += savingPerMonth;
                    month_count++;
                }
                return new int[] { month_count - 1, (int)Math.Round(preservation - startPriceNew_d, MidpointRounding.AwayFromZero) };
            }
        }
        public static void PrintArray <T> (T[] array)
        {
            foreach (var element in array)
                Console.Write(element + " ");
            Console.WriteLine();
        }
    }
}
