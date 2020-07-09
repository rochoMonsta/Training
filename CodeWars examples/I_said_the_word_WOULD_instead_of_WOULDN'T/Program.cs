using System;
using System.Collections.Generic;

namespace I_said_the_word_WOULD_instead_of_WOULDN_T
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = new HashSet<string> { "can", "do", "have", "was", "would" };
            Console.WriteLine(SpeechCorrection(words, "Wouldn't you believe it? I can't!"));
            Console.ReadLine();
        }
        public static string SpeechCorrection(HashSet<string> words, string speech)
        {
            var speech_coll = speech.Split();
            foreach (var element in words)
            {
                for (int i = 0; i < speech_coll.Length; ++i)
                {
                    bool isUpperCase = CheckWordForUpperCase(speech_coll[i]);
                    bool firstLetterIsUpper = CheckFirstLetterForUpperCase(speech_coll[i]);

                    speech_coll[i] = speech_coll[i].ToLower();

                    if (speech_coll[i].Contains(element))
                    {
                        if (speech_coll[i].Contains("n't"))
                        {
                            if (Char.IsPunctuation(speech_coll[i][speech_coll[i].Length - 1]))
                                speech_coll[i] = element + speech_coll[i][speech_coll[i].Length - 1];
                            else
                                speech_coll[i] = element;
                        }
                        else
                        {
                            if (Char.IsPunctuation(speech_coll[i][speech_coll[i].Length - 1]))
                            {
                                if (speech_coll[i][speech_coll[i].Length - 2] == 'n')
                                    speech_coll[i] = element + "'t" + speech_coll[i][speech_coll[i].Length - 1];
                                else
                                    speech_coll[i] = element + "n't" + speech_coll[i][speech_coll[i].Length - 1];
                            }
                            else
                            {
                                if (speech_coll[i][speech_coll[i].Length - 1] == 'n')
                                    speech_coll[i] = element + "'t";
                                else
                                    speech_coll[i] = element + "n't";
                            }
                        }
                    }
                    if (isUpperCase) { speech_coll[i] = speech_coll[i].ToUpper(); }
                    if (firstLetterIsUpper)
                        speech_coll[i] = String.Concat(Char.ToUpper(speech_coll[i][0]), speech_coll[i].Substring(1, speech_coll[i].Length - 1));
                }
            }
            return String.Join(" ", speech_coll);
        }
        public static bool CheckWordForUpperCase(string word)
        {
            foreach (var letter in word.ToCharArray())
            {
                if (Char.IsLetter(letter))
                    if (!Char.IsUpper(letter))
                        return false;
            }
            return true;
        }
        public static bool CheckFirstLetterForUpperCase(string word)
        {
            return Char.IsUpper(word[0]) ? true : false;
        }
    }
}
