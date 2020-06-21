using System;
using System.Linq;

namespace Make_the_Deadfish_swim
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintArray(Parse("iiisdeeeosodddddiso"));
            Console.ReadLine();
        }
        public static int[] Parse(string data)
        {
            int number = 0, counter = 0;
            int[] output_array = new int[data.Count(x => x == 'o')];
            foreach (var letter in data)
            {
                switch (letter)
                {
                    case 'i': number++; break;
                    case 'd': number--; break;
                    case 's': number *= number; break;
                    case 'o': output_array[counter] = number; counter++; break;
                    default: break;
                }
            }
            return output_array;
        }
        public static void PrintArray <T> (T[] array)
        {
            foreach (var element in array)
                Console.Write(element + " ");
            Console.WriteLine();
        }
    }
}
