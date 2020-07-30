using System;
using System.Linq;

namespace Mumbling
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetSTR("abcd"));
            Console.ReadLine();
        }
        public static string GetSTR (string input)
        {
            //string result = "";
            //for (int letter = 0; letter < input.Length; ++letter)
            //    result += Char.ToUpper(input[letter]) + new string(Char.ToLower(input[letter]), letter) + "-";
            //return result.Substring(0, result.Length - 1);

            return String.Join("-", input.Select((x, y) => Char.ToUpper(x) + new string(Char.ToLower(x), y)));
        }
    }
}
