﻿using System;

namespace Is_a_number_prime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsPrime(4));
            Console.ReadLine();
        }
        public static bool IsPrime(int number)
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
    }
}
