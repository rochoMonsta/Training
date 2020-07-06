using System;
using System.Collections.Generic;

namespace Mexican_Wave
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintArr(wave("codewars"));
            Console.ReadLine();
        }
        //public static List<string> wave(string str)
        //{
        //    if (string.IsNullOrWhiteSpace(str))
        //        return new List<string>();
        //    else
        //    {
        //        List<string> wave_list = new List<string>();
        //        for (int i = 0, j = str.Length - 1; i < str.Length; ++i, --j)
        //        {
        //            string element = str;
        //            if (element[i] != ' ')
        //            {
        //                element = String.Concat(element.Substring(0, i), Char.ToUpper(element[i]), element.Substring(i + 1, j));
        //                wave_list.Add(element);
        //            }
        //        }
        //        return wave_list;
        //    }
        //}
        public static List<string> wave(string str)
        {
            if (string.IsNullOrWhiteSpace(str))
                return new List<string>();
            else
            {
                List<string> wave_list = new List<string>();
                for (int i = 0; i < str.Length; ++i)
                {
                    var wave_element = str.ToCharArray();
                    if (wave_element[i] != ' ')
                    {
                        wave_element[i] = Char.ToUpper(wave_element[i]);
                        wave_list.Add(new string(wave_element));
                    }
                }
                return wave_list;
            }
        }
        public static void PrintArr <T> (List<T> list)
        {
            foreach (var element in list)
                Console.Write(element + " ");
            Console.WriteLine();
        }
    }
}
