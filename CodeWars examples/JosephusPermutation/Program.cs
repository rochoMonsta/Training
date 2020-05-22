using System;
using System.Collections.Generic;

namespace JosephusPermutation
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> list = new List<object>() { 1, 2, 3, 4, 5, 6, 7 };
            PrintList(JosephusPermutation(list, 3));
            Console.ReadLine();
        }
        //public static List<object> JosephusPermutation(List<object> items, int k)
        //{
        //    List<object> list = new List<object>();
        //    if (items.Count > 0)
        //    {
        //        int element_index = k - 1;
        //        while (items.Count != 1)
        //        {
        //            if (element_index % items.Count == 0)
        //                element_index = 0;
        //            else
        //                element_index = element_index > items.Count ? element_index % items.Count : element_index;
        //            list.Add(items[element_index]);
        //            items.RemoveAt(element_index);
        //            element_index += k - 1;
        //        }
        //        list.Add(items[items.Count - 1]);
        //        return list;
        //    }
        //    else
        //        return items;
        //}
        public static List<object> JosephusPermutation(List<object> items, int k)
        {
            int index = 0;
            List<object> list = new List<object>();
            while (items.Count > 0)
            {
                index = (index + k - 1) % items.Count;
                list.Add(items[index]);
                items.RemoveAt(index);
            }
            return list;
        }
        public static void PrintList <T> (List<T> list)
        {
            foreach (T element in list)
                Console.Write(element + " ");
            Console.WriteLine();
        }
    }
}
