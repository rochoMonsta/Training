using System;
using System.Collections.Generic;
using System.Linq;

namespace NextBiggerNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NextBiggerNumber(2017));
            Console.ReadLine();
        }
        public static long NextBiggerNumber(long n)
        {
            long result;
            var current_number_array = n.ToString().Select(number => (int)char.GetNumericValue(number)).ToList();
            for (int i = current_number_array.Count - 1; i > 0; --i)
            {
                if (current_number_array[i] > current_number_array[i - 1])
                {
                    int box = current_number_array[i];
                    current_number_array[i] = current_number_array[i - 1];
                    current_number_array[i - 1] = box;

                    result = GetNumber(current_number_array);
                    if (n < result)
                        return result;
                    else
                        continue;
                }
            }
            return -1;
        }
        public static long GetNumber <T> (List<T> list)
        {
            string result = "";
            foreach (T element in list)
                result += element;
            return Int32.Parse(result);
        }
    }
}
