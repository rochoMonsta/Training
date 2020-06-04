using System;

namespace Product_of_consecutive_Fib_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintArray(productFib(714));
            Console.ReadLine();
        }
        public static ulong[] productFib(ulong prod)
        {
            ulong number1 = 0, number2 = 1;
            while (number1 * number2 <= prod)
            {
                if (number1 * number2 == prod)
                    return new ulong[] { number1, number2, 1 };
                else
                {
                    var box = number2;
                    number2 += number1;
                    number1 = box;
                }
            }
            return new ulong[] { number1, number2, 0 };
        }
        public static void PrintArray <T> (T[] arr)
        {
            foreach (T element in arr)
                Console.Write(element + " ");
            Console.WriteLine();
        }
    }
}
