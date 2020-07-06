using System;
using System.Collections.Generic;
using System.Linq;

namespace Pyramid_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintArray(Pyramid(3));
            Console.ReadLine();
        }
        //public static int[][] Pyramid(int n)
        //{
        //    return Enumerable.Range(1, n).Select(i => Enumerable.Repeat(1, i).ToArray()).ToArray();
        //}
        public static int[][] Pyramid(int n)
        {
            List<int[]> Pyramid_array_lst = new List<int[]>();
            for (int i = 1; i <= n; ++i)
            {
                var array = new int[i];
                for (int j = 0; j < i; ++j)
                    array[j] = 1;
                Pyramid_array_lst.Add(array);
            }
            return Pyramid_array_lst.ToArray();
        }
        public static void PrintArray (int[][] array)
        {
            for (int i = 0; i < array.Length; ++i)
            {
                for (int j = 0; j < array[i].Length; ++j)
                    Console.Write(array[i][j] + " ");
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
