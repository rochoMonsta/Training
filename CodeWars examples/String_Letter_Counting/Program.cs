using System;
using System.Collections.Generic;
using System.Linq;

namespace String_Letter_Counting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(StringLetterCount("This is a test sentence."));
            Console.WriteLine(StringLetterCount("The quick brown fox jumps over the lazy dog."));
            Console.WriteLine(StringLetterCount("The time you enjoy wasting is not wasted time."));
            Console.ReadLine();
        }
        //Description:
        //Take an input string and return a string that is made up of the number of occurances of each english letter
        //in the input, followed by that letter. The string shouldn't contain zeros; leave them out.

        //An empty string, or one with no letters, should return an empty string.

        //Notes:
        //the input will always be valid;
        //treat letters as case-insensitive
        public static string StringLetterCount(string sentence)
        {
            string result = "";
            sentence = sentence.ToLower();
            Dictionary<char, int> letters_dict = new Dictionary<char, int>();
            foreach (var letter in sentence)
            {
                List<char> key_list = new List<char>(letters_dict.Keys);
                if (Char.IsLetter(letter))
                {
                    if (key_list.Contains(letter))
                        letters_dict[letter]++;
                    else
                        letters_dict.Add(letter, 1);
                }
            }
            var order_collection = letters_dict.OrderBy(element => element.Key);
            foreach (var element in order_collection)
                result += element.Value.ToString() + element.Key.ToString();
            return result;
        }
    }
}
