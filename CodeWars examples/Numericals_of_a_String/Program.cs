using System;
using System.Collections.Generic;

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
            string result = "";
            var letter_dict = new Dictionary<char, int>();
            foreach (var letter in s)
            {
                List<char> dict_keys = new List<char>(letter_dict.Keys);
                if (dict_keys.Contains(letter))
                {
                    letter_dict[letter]++;
                    result += letter_dict[letter];
                }
                else
                {
                    letter_dict.Add(letter, 1);
                    result += letter_dict[letter];
                }
            }
            return result;
        }
    }
}
