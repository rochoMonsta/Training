using System;
using System.Linq;

namespace Tribonacci_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintArr(Tribonacci(new double[] { 5, 11, 3 }, 37));
            Console.ReadLine();
        }
        public static double[] Tribonacci(double[] signature, int n)
        {
            if (n == 0)
                return new double[0];
            else if (n <= signature.Length)
            {
                double[] signature_low = new double[n];
                for (int i = 0; i < n; ++i)
                    signature_low[i] = signature[i];
                return signature_low;
            }
            else
            {
                var tribonacci_lst = signature.ToList();
                for (int i = 0; i < n - signature.Length; ++i)
                    tribonacci_lst.Add(tribonacci_lst[i] + tribonacci_lst[i + 1] + tribonacci_lst[i + 2]);
                return tribonacci_lst.ToArray();
            }
        }
        public static void PrintArr <T> (T[] arr)
        {
            foreach (var element in arr)
                Console.WriteLine(element);
            Console.WriteLine();
        }
    }
}
