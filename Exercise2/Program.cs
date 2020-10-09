using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Test array
            int[] array = new int[] { 1, 2, 4, 7, 8, 9, 10, 1 };

            //Console.WriteLine(GetRecurringElementJustTry(/*some array[1...100]*/));

            Console.WriteLine(GetRecurringElementLinQ(array)); // 1

            Console.WriteLine(GetRecurringElementList(array)); // 1

            Console.ReadLine();
        }

        #region Methods
        // Один з способів коли ми від очікуваної суми значень з проміжку [1, 100] віднімаємо отриману суму значень масиву
        public static int GetRecurringElementJustTry(int[] array) => (101 * 50) - array.Sum();

        /// <summary>
        /// This method returns the value that occurs most often in the array (using Linq)
        /// </summary>
        /// <param name="array" - numbers array ></param>
        /// <returns></returns>
        public static int? GetRecurringElementLinQ(int[] array)
        {
            var result = array.GroupBy(n => n)
                              .Select(n => new { Key = n.Key, Count = n.Count() })
                              .FirstOrDefault(n => n.Count > 1)?.Key;
            return result;
        }
        /// <summary>
        /// This method returns the value that occurs most often in the array (using List)
        /// </summary>
        /// <param name="array" - numbers array ></param>
        /// <returns></returns>
        public static int GetRecurringElementList(int[] array)
        {
            var numbersCount = new List<int>();
            foreach (var number in array)
            {
                if (numbersCount.Contains(number))
                    return number; // numbersCount[number]++;
                else
                    numbersCount.Add(number);
            }
            return -1;
        }
        #endregion
    }
}
