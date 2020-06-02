using System;
using System.Linq;

namespace Array_diff
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintArray(ArrayDiff(new int[] { 1, 2, 2, 3, 17, 2, 8 }, new int[] { 1, 2 }));
            Console.ReadLine();
        }
        public static int[] ArrayDiff(int[] a, int[] b)
        {
            //Remove the numbers from the array a that are present in the array b
            return a.Where(item => !b.Contains(item)).ToArray();
        }
        public static void PrintArray <T> (T[] array)
        {
            foreach (T element in array)
                Console.Write(element + " ");
            Console.WriteLine();
        }
    }
}
