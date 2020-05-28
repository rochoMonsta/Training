using System;

namespace BuildTower
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintArray(TowerBuilder(6));
            Console.ReadLine();
        }
        public static string[] TowerBuilder(int nFloors)
        {
            string[] tower_string = new string[nFloors];
            int max_count_of_star = nFloors * 2 - 1;
            for (int i = 0; i < nFloors; ++i)
            {
                string floor_string = "";
                for (int j = 0; j < max_count_of_star; ++j)
                    floor_string += "*";
                if (i * 2 > 0)
                    for (int k = 0; k < i; ++k)
                    {
                        floor_string = floor_string.Insert(0, " ");
                        floor_string = floor_string.Insert(floor_string.Length, " ");
                    }
                max_count_of_star -= 2;
                tower_string[i] = floor_string;
            }
            Array.Reverse(tower_string);
            return tower_string;
        }
        //public static string[] TowerBuilder(int nFloors)
        //{
        //    string[] tower_string = new string[nFloors];
        //    for (int i = 0; i < nFloors; i++)
        //        tower_string[i] = string.Concat(new string(' ', nFloors - i - 1),
        //                                  new string('*', i * 2 + 1),
        //                                  new string(' ', nFloors - i - 1));
        //    return tower_string;
        //}
        public static void PrintArray(string[] array)
        {
            for (int i = 0; i < array.Length; ++i)
            {
                for (int j = 0; j < array[i].Length; ++j)
                    Console.Write(array[i][j]);
                Console.WriteLine();
            }
        }
    }
}
