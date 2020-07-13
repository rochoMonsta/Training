using System;
using System.Linq;

namespace Stop_gninnipS_My_sdroW
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SpinWords("You are almost to the last test"));
            Console.ReadLine();
        }
        //public static string SpinWords(string sentence)
        //{
        //    var words_array = sentence.Split();
        //    for (int i = 0; i < words_array.Length; ++i)
        //    {
        //        if (words_array[i].Length > 4)
        //            words_array[i] = new string(words_array[i].Reverse().ToArray());
        //    }
        //    return String.Join(" ", words_array);
        //}
        public static string SpinWords(string sentence)
        {
            return String.Join(" ", sentence.Split().Select(word => word.Length >= 5 ? new string(word.Reverse().ToArray()) : word));
        }
    }
}
