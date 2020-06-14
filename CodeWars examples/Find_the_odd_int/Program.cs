using System;
using System.Collections.Generic;
using System.Linq;

namespace Find_the_odd_int
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(find_it(new[] { 20, 1, -1, 2, -2, 3, 3, 5, 5, 1, 2, 4, 20, 4, -1, -2, 5 }));
            Console.ReadLine();
        }
        public static int find_it(int[] numbers_arr)
        {
            Dictionary<int, int> numbers_dict = new Dictionary<int, int>();
            foreach (var number in numbers_arr)
            {
                List<int> key_list = new List<int>(numbers_dict.Keys);
                if (key_list.Contains(number))
                    numbers_dict[number]++;
                else
                    numbers_dict.Add(number, 1);
            }
            return numbers_dict.Single(item => item.Value % 2 != 0).Key;
        }
        //public static int find_it(int[] seq)
        //{
        //    return seq.GroupBy(x => x).Single(g => g.Count() % 2 != 0).Key;
        //}
    }
}
