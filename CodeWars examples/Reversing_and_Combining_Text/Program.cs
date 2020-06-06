using System;
using System.Collections.Generic;
using System.Linq;

namespace Reversing_and_Combining_Text
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(reverseAndCombineText("rxsvlaeep lofst kptcb mqyrrvar uhzpeu yuegjesd wtbdqxy bolcvpzf " +
                                                    "rtckutwh iygcnvok kptcb bolcvpzf tjytw rtckutwh mqyrrvar " +
                                                    "mqyrrvar iygcnvok apymbyyjg kptcb pzepat vewasx"));
            Console.ReadLine();
        }
        public static string reverseAndCombineText(string text)
        {
            var words_array = text.Split(' ').ToList();
            while (words_array.Contains(""))
                words_array.Remove("");
            while (words_array.Count != 1)
            {
                List<string> newWord = new List<string>();
                for (int i = 0; i < words_array.Count; ++i)
                    words_array[i] = ReverseString(words_array[i]);
                for (int i = 0; i <= (words_array.Count - (words_array.Count % 2) - 1); i += 2)
                    words_array[i] = String.Concat(words_array[i], words_array[i + 1]);
                if (words_array.Count % 2 == 0)
                {
                    for (int i = 0; i <= (words_array.Count - (words_array.Count % 2) - 1); i += 2)
                        newWord.Add(words_array[i]);
                    words_array = newWord;
                }
                else
                {
                    for (int i = 0; i <= (words_array.Count - (words_array.Count % 2)); i += 2)
                        newWord.Add(words_array[i]);
                    words_array = newWord;
                }
            }
            return words_array[0];
        }
        public static string ReverseString(string word)
        {
            var wordAsString = word.ToCharArray();
            Array.Reverse(wordAsString);
            return new string(wordAsString);
        }
    }
}
