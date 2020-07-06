using System;
using System.Linq;

namespace N_smallest_elements_in_original_order
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintArr(FirstNSmallest(new[] { 1, 2, 3, 4, 2 }, 4));
            Console.ReadLine();
        }
        //public static int[] FirstNSmallest(int[] arr, int n)
        //{
        //    int[] result = new int[n];

        //    var arr_as_list = arr.ToList();
        //    arr_as_list.Sort();
        //    arr_as_list.RemoveRange(n, arr_as_list.Count - n);

        //    for (int i = 0, j = 0; j < n; ++i)
        //    {
        //        if (arr_as_list.Contains(arr[i]))
        //        {
        //            arr_as_list.Remove(arr[i]);
        //            result[j] = arr[i];
        //            j++;
        //        }
        //    }
        //    return result;
        //}
        public static int[] FirstNSmallest(int[] arr, int n)
        {
            var smallestNumbers = arr.OrderBy(x => x).Take(n).ToList();
            return arr.Where(x => smallestNumbers.Remove(x)).ToArray();
        }
        public static void PrintArr <T> (T[] array)
        {
            foreach (var element in array)
                Console.Write(element + " ");
            Console.WriteLine();
        }
    }
}
