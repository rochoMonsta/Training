using System;

namespace Normalizing_Out_of_Range_Array_Indexes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NormIndex(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9}, -11));
            Console.ReadLine();
        }
        public static int NormIndex(int[] array, int index)
        {
            if (index > 0)
                return array[index % array.Length];
            else
            {
                if (Math.Abs(index) % array.Length == 0)
                    return array[0];
                else
                    return array[array.Length - (Math.Abs(index) % array.Length)];
            }
        }
        //public static int NormIndex(int[] array, int index)
        //{
        //    while (index < 0) index += array.Length;
        //    return array[index % array.Length];
        //}
    }
}
