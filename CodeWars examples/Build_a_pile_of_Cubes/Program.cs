using System;

namespace Build_a_pile_of_Cubes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(findNb(135440716410000));
            Console.ReadLine();
        }
        public static long findNb(long m)
        {
            int counter = 1;
            long cube_volume = 0;
            while (cube_volume < m)
            {
                cube_volume += Convert.ToInt64(Math.Pow(counter, 3));
                counter++;
            }
            return cube_volume == m ? Convert.ToInt64(counter) - 1 : -1;
        }
    }
}
