using System;

namespace Hearthstone
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] cards = { 1, 1, 2, 2, 2, 3, 3, 5, 8, 10, 0, 0 };
            printGraffManaCoast(getCardManaCoast(createArray(10, 10), cards));
            Console.ReadLine();
        }
        public static char[,] getCardManaCoast(char[,] diagramArray, int[] cards)
        {
            foreach (var card in cards)
            {
                int max_length = diagramArray.GetLength(0);
                while (diagramArray[max_length - 1, card] == '*')
                    max_length--;

                diagramArray[max_length - 1, card] = '*';
            }
            return diagramArray;
        }
        public static char[,] createArray(int size_x, int size_y)
        {
            var graff_array = new char[size_x, size_y + 1];
            for (int i = 0; i < size_x; ++i)
                for (int j = 0; j < size_y; ++j)
                    graff_array[i, j] = ' ';
            return graff_array;
        }
        public static void printGraffManaCoast(char[,] array)
        {
            for (int i = 0; i < array.GetLength(0); ++i)
            {
                for (int j = 0; j < array.GetLength(1); ++j)
                    Console.Write(array[i, j]);
                Console.WriteLine();
            }  
        }
    }
}
