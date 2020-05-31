using System;
using System.Collections.Generic;
using System.Linq;

namespace Difference_of_2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] array = { 4, 3, 1, 6, 5};
            PrintArray(TwosDifference(array));
            Console.ReadLine();
        }
        public static void PrintArray((int, int)[] array)
        {
            for (int i = 0; i < array.Length; ++i)
                Console.WriteLine(array[i].Item1 + " " + array[i].Item2);
            Console.WriteLine();
        }
        public static (int, int)[] TwosDifference(int[] array)
        {
            List<(int, int)> array_list = new List<(int, int)>();
            for (int i = 0; i < array.Length; ++i)
            {
                if (array.Contains(array[i] + 2) || array.Contains(array[i] - 2))
                {
                    if (array.Contains(array[i] + 2))
                    {
                        var simple_array = (array[i], array[i] + 2);
                        if (!array_list.Any(item => item.Item1 == simple_array.Item1 && item.Item2 == simple_array.Item2))
                            array_list.Add(simple_array);
                    }
                    else
                    {
                        if (array.Contains(array[i] - 2))
                        {
                            var simple_array = (array[i] - 2, array[i]);
                            if (!array_list.Any(item => item.Item1 == simple_array.Item1 && item.Item2 == simple_array.Item2))
                                array_list.Add(simple_array);
                        }
                    }
                }
            }
            var list = array_list.OrderBy(number => number.Item1);
            return list.ToArray();
        }
    }
}
