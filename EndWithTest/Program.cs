using System;

namespace EndWithTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Roman".EndsWith("oman")); //стандартний метод
            Console.WriteLine("Roman".EndWith("oman"));
            Console.WriteLine("Roman".StartsWith("ro")); //стандартний метод
            Console.WriteLine("Roman".StartWith("ro"));
            Console.WriteLine("Roman".StartsWith("Ro"));
            Console.WriteLine("Roman".StartWith("Ro"));
            Console.ReadLine();
        }
    }
}
