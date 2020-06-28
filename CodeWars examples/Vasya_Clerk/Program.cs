using System;
using System.Collections.Generic;

namespace Vasya_Clerk
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Tickets(new int[] { 25, 25, 50, 50, 100}));
            Console.ReadLine();
        }
        public static string Tickets(int[] peopleInLine)
        {
            if (peopleInLine[0] > 25)
                return "NO";
            else
            {
                var count_of_bills = new Dictionary<int, int>() { { 25, 0 }, { 50, 0 }, { 100, 0 } };
                foreach (var bill in peopleInLine)
                {
                    switch (bill)
                    {
                        case 25: count_of_bills[25]++; break;
                        case 50:
                            if (count_of_bills[25] > 0)
                            {
                                count_of_bills[50]++;
                                count_of_bills[25]--;
                            }
                            else
                                return "NO";
                            break;
                        case 100:
                            if (count_of_bills[50] > 0 && count_of_bills[25] > 0)
                            {
                                count_of_bills[100]++;
                                count_of_bills[50]--;
                                count_of_bills[25]--;
                            }
                            else
                                return "NO";
                            break;
                    }
                }
                return "YES";
            }
        }
    }
}
