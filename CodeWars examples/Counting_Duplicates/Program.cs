using System;
using System.Collections.Generic;
using System.Linq;

namespace Counting_Duplicates
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DuplicateCount("aaBbcdeE"));
            Console.ReadLine();
        }
        public static int DuplicateCount(string str)
        {
            str = str.ToLower();
            Dictionary<char, int> letter_counter_dict = new Dictionary<char, int>();
            foreach (var letter in str)
            {
                List<char> letter_list = new List<char>(letter_counter_dict.Keys);
                if (letter_list.Contains(letter))
                    letter_counter_dict[letter]++;
                else
                    letter_counter_dict.Add(letter, 1);
            }
            return letter_counter_dict.Count(x => x.Value > 1);
        }
        //public static int DuplicateCount(string str)
        //{
        //    return str.ToLower().GroupBy(c => c).Where(g => g.Count() > 1).Count();
        //}
    }
}
