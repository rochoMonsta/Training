using System;
using System.Collections.Generic;

namespace JosephusSurvivor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(JosSurvivor(11, 19));
            Console.ReadLine();
        }
        public static int JosSurvivor(int n, int k)
        {
            int person_index = 0;
            List<int> people_numbe_list = new List<int>();
            for (int i = 1; i <= n; ++i)
                people_numbe_list.Add(i);
            while (people_numbe_list.Count > 1)
            {
                person_index = (person_index + k - 1) % people_numbe_list.Count;
                people_numbe_list.RemoveAt(person_index);
            }
            return people_numbe_list[0];
        }
    }
}
