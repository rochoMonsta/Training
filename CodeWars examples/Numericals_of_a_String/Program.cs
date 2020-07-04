using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Numericals_of_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Numericals("Hello, World! It's me, JomoPipi!") == "11121111213112111131224132411122");
            Console.ReadLine();
        }
        public static string Numericals(string s)
        {
            StringBuilder result = new StringBuilder("");
            var letter_dict = new Dictionary<char, int>();
            foreach (var letter in s)
            {
                if (letter_dict.Keys.Contains(letter))
                {
                    letter_dict[letter]++;
                    result.Append(letter_dict[letter]);
                }
                else
                {
                    letter_dict.Add(letter, 1);
                    result.Append(letter_dict[letter]);
                }
            }
            return result.ToString();
        }
    }
}
