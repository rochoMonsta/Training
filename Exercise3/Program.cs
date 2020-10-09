using System;
using System.Collections.Generic;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = GetPalindromeTime();

            foreach (var time in result)
                Console.WriteLine(time);

            Console.ReadLine();
        }
        #region Methods
        /// <summary>
        /// This method generate all possible time options and check them for palindrome
        /// </summary>
        /// <returns></returns>
        public static List<Time> GetPalindromeTime()
        {
            var palindromeTimeList = new List<Time>();

            for (int hour = 0; hour < 24; ++hour)
            {
                for (int minute = 0; minute < 60; ++minute)
                {
                    var time = new Time(hour, minute);

                    if (CheckForPalidrome(time.ToString()))
                        palindromeTimeList.Add(time);
                }
            }
            return palindromeTimeList;
        }
        /// <summary>
        /// This method checks the value on the palindrome
        /// </summary>
        /// <param name="value" - the value to be checked on the palindrome ></param>
        /// <returns></returns>
        private static bool CheckForPalidrome(string value)
        {
            int valueLength = value.Length;
            for (int i = 0; i < valueLength / 2; ++i)
            {
                if (value[i] != value[valueLength - i - 1])
                    return false;
            }
            return true;
        }
        #endregion
    }
}
