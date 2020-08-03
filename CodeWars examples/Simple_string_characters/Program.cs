using System;
using System.Linq;

namespace Simple_string_characters
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintArrayValue(Solve("Codewars@codewars123.com"));
            Console.ReadLine();
        }
        //public static int[] Solve(string s)
        //{
        //    int[] resultArray = new int[4];
        //    foreach (var letter in s)
        //    {
        //        if (Char.IsUpper(letter)) resultArray[0]++;
        //        else if (Char.IsLower(letter)) resultArray[1]++;
        //        else if (Char.IsNumber(letter)) resultArray[2]++;
        //        else resultArray[3]++;
        //    }
        //    return resultArray;
        //}
        public static int[] Solve(string s)
        {
            return new int[]
            {
                s.Count(letter => Char.IsUpper(letter)),
                s.Count(letter => Char.IsLower(letter)),
                s.Count(letter => Char.IsDigit(letter)),
                s.Count(letter => !Char.IsLetterOrDigit(letter))
            };
        }
        public static void PrintArrayValue <T> (T[] array)
        {
            foreach (var element in array)
                Console.Write(element + " ");
            Console.WriteLine();
        }
    }
}
