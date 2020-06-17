using System;

namespace Chess_Board_Cell_Color
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ChessBoardCellColor("A1", "A3"));
            Console.ReadLine();
        }
        public static bool ChessBoardCellColor(string cell1, string cell2)
        {
            var letter_arr = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H' };
            int number1 = Int32.Parse(cell1[1].ToString());
            int number2 = Int32.Parse(cell2[1].ToString());

            int index1 = Array.IndexOf(letter_arr, cell1[0]) + 1;
            int index2 = Array.IndexOf(letter_arr, cell2[0]) + 1;

            if ((index1 % 2 != 0 && index2 % 2 != 0) || (index1 % 2 == 0 && index2 % 2 == 0))
            {
                if ((number1 % 2 != 0 && number2 % 2 != 0) || (number1 % 2 == 0 && number2 % 2 == 0))
                    return true;
                else
                    return false;
            }
            else
            {
                if ((number1 % 2 == 0 && number2 % 2 != 0) || (number1 % 2 != 0 && number2 % 2 == 0))
                    return true;
                else
                    return false;
            }
        }
        //public static bool ChessBoardCellColor(string cell1, string cell2)
        //{
        //    return (cell1[0] + cell1[1]) % 2 == (cell2[0] + cell2[1]) % 2;
        //}
    }
}
