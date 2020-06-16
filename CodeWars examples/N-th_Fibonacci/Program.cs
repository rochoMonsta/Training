using System;

namespace N_th_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NthFib(2));
            Console.ReadLine();
        }
        public static int NthFib(int n)
        {
            if (n == 1)
                return 0;
            else if (n == 2)
                return 1;
            else
            {
                int first = 0, second = 1;
                for (int counter = 2; counter < n; ++counter)
                {
                    int box_var = second;
                    second += first;
                    first = box_var;
                }
                return second;
            }
        }
    }
}
