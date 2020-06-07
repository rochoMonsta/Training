using System;

namespace Backwards_Read_Primes
{
    class Program
    {
        //Backwards Read Primes are primes that when read backwards in base 10 (from right to left) are a different prime. 
        //(This rules out primes which are palindromes.)

        //Find all Backwards Read Primes between two positive given numbers (both inclusive), the second one always being 
        //greater than or equal to the first one. The resulting array or the resulting string will be ordered following the 
        //natural order of the prime numbers.
        static void Main(string[] args)
        {
            Console.WriteLine(backwardsPrime(2, 100));
            Console.ReadLine();
        }
        public static string backwardsPrime(long start, long end)
        {
            string result = "";
            for (long i = start; i <= end; ++i)
            {
                var reverseNumber = Convert.ToInt64(ReverseString(i.ToString()));
                if (IsPrime(i) && IsPrime(reverseNumber) && (reverseNumber != i))
                    result += i + " ";
            }
            return result.Trim();
        }
        public static bool IsPrime(long number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
                if (number % i == 0)
                    return false;

            return true;
        }
        public static string ReverseString(string word)
        {
            var wordAsString = word.ToCharArray();
            Array.Reverse(wordAsString);
            return new string(wordAsString);
        }
    }
}
