using System;
using System.Collections.Generic;
using System.Linq;

namespace Arrh_grabscrab
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintList(Grabscrab("ortsp", new List<string> { "sport", "parrot", "ports", "matey" }));
            Console.ReadLine();
        }
        //public static List<string> Grabscrab(string anagram, List<string> dictionary)
        //{
        //    var pirates_words_ = new List<string>();
        //    foreach (var word in dictionary)
        //    {
        //        if (anagram.Length == word.Length)
        //        {
        //            var result = true;
        //            foreach (var letter in anagram)
        //            {
        //                if (!(anagram.Count(x => x == letter) == word.Count(x => x == letter)))
        //                {
        //                    result = false;
        //                    break;
        //                }
        //            }
        //            if (result) pirates_words_.Add(word);
        //        }
        //    }
        //    return pirates_words_;
        //}
        public static void PrintList <T> (List<T> list)
        {
            foreach (var element in list)
                Console.WriteLine(element);
        }
        public static List<string> Grabscrab(string anagram, List<string> dictionary)
        {
            return dictionary.Where(x => x.OrderBy(y => y).SequenceEqual(anagram.OrderBy(z => z))).ToList();
        }
    }
}
