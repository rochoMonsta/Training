using System;
using System.Collections.Generic;

namespace Detect_Pangram
{
    class Program
    { 
        /// A pangram is a sentence that contains every single letter of the alphabet at least once. 
        /// For example, the sentence "The quick brown fox jumps over the lazy dog" is a pangram, 
        /// because it uses the letters A-Z at least once (case is irrelevant).
        static void Main(string[] args)
        {
            Console.WriteLine(IsPangram("The quick brown fox jumps over the lazy dog.")); //true
            Console.WriteLine(IsPangramWithCountOfLetter("The quick brown fox jumps over the lazy dog.")); //true

            Console.WriteLine(IsPangram("abcdefghijklmnopqrstuvwxy")); //false
            Console.WriteLine(IsPangramWithCountOfLetter("abcdefghijklmnopqrstuvwxy")); //false
            Console.ReadLine();
        }
        /// <summary>
        /// checks if the text is a pangram
        /// </summary>
        /// <param name="str" custom text></param>
        /// <returns></returns>
        public static bool IsPangram(string str)
        {
            str = str.ToLower();
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            foreach (char letter in alphabet)
                if (!str.Contains(letter.ToString()))
                    return false;
            return true;
        }
        /// <summary>
        /// checks whether the text is a pangram and counts the number of letters
        /// </summary>
        /// <param name="str" custom text></param>
        /// <returns></returns>
        public static bool IsPangramWithCountOfLetter(string str)
        {
            str = str.ToLower();
            var letter_dict = new Dictionary<char, int>();
            foreach (var letter in str)
            {
                if (Char.IsLetter(letter))
                {
                    var key_list = new List<char>(letter_dict.Keys);
                    if (key_list.Contains(letter))
                        letter_dict[letter]++;
                    else
                        letter_dict.Add(letter, 1);
                }
            }
            return letter_dict.Count == 26 ? true : false;
        }
    }
}
