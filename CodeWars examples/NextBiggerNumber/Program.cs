using System;
using System.Collections.Generic;
using System.Linq;

namespace NextBiggerNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NextBiggerNumber(414));
            Console.ReadLine();
        }
        public static long NextBiggerNumber(long n)
        {
            var list = n.ToString().Select(number => (int)char.GetNumericValue(number)).ToList();
            while (true)
            {
                for (int i = 2; i <= list.Count; ++i)
                {
                    string result = "";
                    List<int> numbers_list = new List<int>();
                    List<long> generate_numbers = new List<long>();
                    for (int j = list.Count - 1; j > list.Count - i - 1; --j)
                    {
                        numbers_list.Add(list[j]);
                        result += list[j];
                    }
                    char[] ar = result.ToCharArray();
                    Array.Reverse(ar);
                    result = new string(ar);
                    heapPermutation(numbers_list, numbers_list.Count, numbers_list.Count, generate_numbers);
                    generate_numbers.Sort();
                    long result_int = Convert.ToInt64(result);
                    foreach (var element in generate_numbers)
                    {
                        if (element > result_int)
                        {
                            var number_array = element.ToString().Select(number => (int)char.GetNumericValue(number)).ToList();
                            for (int j = list.Count - 1, k = number_array.Count - 1; j > list.Count - i - 1; --j, --k)
                            {
                                list[j] = number_array[k];
                            }
                            return GetNumber(list);
                        }
                    }
                }
            }
        }
        public static long GetNumber<T>(List<T> list)
        {
            string result = "";
            foreach (T element in list)
                result += element;
            return Convert.ToInt64(result);
        }
        public static void PrintList(List<int> list)
        {
            foreach (var element in list)
                Console.WriteLine(element);
            Console.WriteLine();
        }
        public static void heapPermutation(List<int> list, int size, int n, List<long> list_of)
        {
            if (size == 1)
            {
                string res = "";
                foreach (var element in list)
                    res += element;
                list_of.Add(Convert.ToInt64(res));
            }

            for (int i = 0; i < size; i++)
            {
                heapPermutation(list, size - 1, n, list_of);

                if (size % 2 == 1)
                {
                    int temp = list[0];
                    list[0] = list[size - 1];
                    list[size - 1] = temp;
                }
                else
                {
                    int temp = list[i];
                    list[i] = list[size - 1];
                    list[size - 1] = temp;
                }
            }
        }
    }
}
