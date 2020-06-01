using System;

namespace Onion_array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsOnionArray(new int[] { 1, 1, 15, 10, -1 }));
            Console.ReadLine();
        }
        public static bool IsOnionArray(int[] arr)
        {
            for (int i = 0; i < arr.Length / 2; ++i)
            {
                if (!(arr[i] + arr[arr.Length - 1 - i] <= 10))
                    return false;
            }
            return true;
        }
    }
}
