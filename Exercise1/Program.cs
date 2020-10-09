using System;
using System.Collections.Generic;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] first = { 2, 4, 8, 34 };
            int[] second = { 2, 5, 6, 8, 12, 42, 54 };

            foreach (var element in CombineSortedArrayWithSort(first, second))
                Console.Write(element + " ");

            Console.ReadLine();
        }
        #region Methods
        /// <summary>
        /// This method combines and sorts two sorted arrays
        /// </summary>
        /// <param name="sArr1" - an array of sorted numbers ></param>
        /// <param name="sArr2" - an array of sorted numbers ></param>
        /// <returns></returns>
        public static int[] CombineSortedArrayWithSort(int[] sArr1, int[] sArr2)
        {
            var resultList = new List<int>(sArr1);

            for(int i = 0; i < sArr2.Length; ++i)
            {
                for (int j = 0; j < resultList.Count; ++j)
                {
                    if (sArr2[i] == resultList[j] || sArr2[i] < resultList[j])
                    {
                        resultList.Insert(j, sArr2[i]);
                        break;
                    }
                }
                if (resultList[resultList.Count - 1] < sArr2[i])
                    resultList.Add(sArr2[i]);
            }
            return resultList.ToArray();
        }
        #endregion
    }
}
