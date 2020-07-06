using System;
using System.Collections.Generic;
using System.Linq;

namespace Unique_In_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            Print(UniqueInOrder("AAAABBBCCDAABBB"));
            Console.ReadLine();
        }
        public static IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> iterable)
        {
            var result_list = new List<T>();
            foreach (var element in iterable)
                if (!element.Equals(result_list.LastOrDefault()))
                    result_list.Add(element);
            return result_list;
        }
        public static void Print <T> (IEnumerable<T> collection)
        {
            foreach (var element in collection)
                Console.Write(element + " ");
            Console.WriteLine();
        }
    }
}
