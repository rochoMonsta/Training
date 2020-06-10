using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Consonant_value
{
    class Program
    {
        private static readonly char[] Vowels = { 'a', 'e', 'i', 'o', 'u' };
        static void Main(string[] args)
        {
            Console.WriteLine(Solve("mischtschenkoana"));
            Console.ReadLine();
        }

        //public static int Solve(string s)
        //{
        //    string result = "";
        //    char[] consonants = { 'a', 'e', 'i', 'o', 'u' };
        //    foreach (var letter in s)
        //    {
        //        if (!consonants.Contains(letter))
        //            result += letter;
        //        else
        //            result += ' ';
        //    }
        //    var vowels_letters = Regex.Replace(result, "[ ]+", " ").Split();
        //    return GetHighestVowelIndex(vowels_letters);
        //}
        //public static int GetHighestVowelIndex(string[] vowels)
        //{
        //    int max = 0;
        //    for (int i = 0; i < vowels.Length; ++i)
        //    {
        //        int local_max = 0;
        //        foreach (var letter in vowels[i])
        //            local_max += (int)letter % 32;
        //        if (local_max > max)
        //            max = local_max;
        //    }
        //    return max;
        //}
        public static int Solve(string input)
        {
            return input.ToLowerInvariant()
              .Split(Vowels, StringSplitOptions.RemoveEmptyEntries)
              .Max(s => s.Sum(c => c - 'a' + 1));
        }
    }
}
