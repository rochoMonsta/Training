using System;
using System.Linq;

namespace Help_the_bookseller
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] art = new string[] { "ABAR 200", "CDXE 500", "BKWR 250", "BTSQ 890", "DRTY 600" };
            string[] cd = new String[] { "A", "B" };
            Console.WriteLine(stockSummary(art, cd));
            Console.ReadLine();
        }
        //public static string stockSummary(String[] lstOfArt, String[] lstOf1stLetter)
        //{
        //    if (!lstOfArt.Any())
        //        return "";
        //    else
        //        return string.Join(" - ", lstOf1stLetter.Select(c => string.Format("({0} : {1})", c,
        //                                  lstOfArt.Where(a => a[0] == c[0])
        //                                  .Sum(a => int.Parse(a.Split(' ')[1])))));
        //}
        public static string stockSummary(string[] lstOfArt, string[] lstOf1stLetter)
        {
            if (lstOfArt.Length == 0 || lstOf1stLetter.Length == 0)
                return "";
            else
            {
                string result = "";
                var categories_dict = lstOf1stLetter.ToDictionary(key => key, value => 0);
                result += String.Join(" - ", categories_dict.Select(c => String.Format("({0} : {1})", c.Key, 
                                             lstOfArt.Select(x => x.Split())
                                                     .Where(x => x[0][0] == c.Key
                                                     .ToCharArray()[0])
                                                     .Sum(x => Convert.ToInt32(x[1])))));
                return result;
            }
        }
    }
}
