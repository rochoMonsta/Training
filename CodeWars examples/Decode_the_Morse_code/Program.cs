using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Decode_the_Morse_code
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Decode("   .   "));
            Console.ReadLine();
        }
        static readonly Regex trimmer = new Regex(@"\s\s+");
        public static Dictionary<string, string> _morseAlphabetDictionary = new Dictionary<string, string>()
        {
            {"a", ".-"},
            {"b", "-..."},
            {"c", "-.-."},
            {"d", "-.."},
            {"e", "."},
            {"f", "..-."},
            {"g", "--."},
            {"h", "...."},
            {"i", ".."},
            {"j", ".---"},
            {"k", "-.-"},
            {"l", ".-.."},
            {"m", "--"},
            {"n", "-."},
            {"o", "---"},
            {"p", ".--."},
            {"q", "--.-"},
            {"r", ".-."},
            {"s", "..."},
            {"t", "-"},
            {"u", "..-"},
            {"v", "...-"},
            {"w", ".--"},
            {"x", "-..-"},
            {"y", "-.--"},
            {"z", "--.."},
            {"0", "-----"},
            {"1", ".----"},
            {"2", "..---"},
            {"3", "...--"},
            {"4", "....-"},
            {"5", "....."},
            {"6", "-...."},
            {"7", "--..."},
            {"8", "---.."},
            {"9", "----."},
            {"SOS", "...---..."},
            {".", ".-.-.-"},
            {",", "--..--"},
            {"!", "-.-.--"},
            {"?", "..--.."}
        };
        public static string Decode(string morseCode)
        {
            string sentences = "";
            var morse_words_codes_ = morseCode.Split();
            foreach (var word_code_ in morse_words_codes_)
            {
                if (String.IsNullOrWhiteSpace(word_code_))
                    sentences += " ";
                else
                    sentences += _morseAlphabetDictionary.FirstOrDefault(x => x.Value == word_code_).Key;
            }
            return trimmer.Replace(sentences.ToUpper().Trim(), " ");
        }
    }
}
