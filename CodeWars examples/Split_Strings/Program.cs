using System;
using System.Collections.Generic;

namespace Split_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintArray(Solution("abcdefg"));
            Console.ReadLine();
        }
        public static string[] Solution(string str)
        {
            List<string> lst = new List<string>();
            for (int i = 0; i < str.Length - (str.Length % 2); i += 2)
                lst.Add(str.Substring(i, 2));
            if (str.Length % 2 != 0)
                lst.Add(String.Concat(str[str.Length - 1], '_'));
            return lst.ToArray();
        }
        public static void PrintArray <T> (T[] array)
        {
            foreach (var element in array)
                Console.Write(element + " ");
            Console.WriteLine();
        }
    }
}
