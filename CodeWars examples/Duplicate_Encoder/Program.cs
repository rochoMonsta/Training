using System;
using System.Linq;

namespace Duplicate_Encoder
{
    class Program
    {
        //The goal of this exercise is to convert a string to a new string where each character in the 
        //new string is "(" if that character appears only once in the original string, or ")" if that 
        //character appears more than once in the original string. Ignore capitalization when determining 
        //if a character is a duplicate.

        static void Main(string[] args)
        {
            Console.WriteLine(DuplicateEncode("Success"));
            Console.ReadLine();
        }
        public static string DuplicateEncode(string word)
        {
            string result = "";
            word = word.ToLower();
            foreach (var letter in word)
            {
                if (word.Count(x => x == letter) >= 2)
                    result += ')';
                else
                    result += '(';
            }
            return result;
        }
        //public static string DuplicateEncode(string word)
        //{
        //    return new string(word.ToLower().Select(ch => word.ToLower().Count(innerCh => ch == innerCh) == 1 ? '(' : ')').ToArray());
        //}
    }
}
