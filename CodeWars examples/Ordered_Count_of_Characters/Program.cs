using System;
using System.Collections.Generic;
using System.Linq;

namespace Ordered_Count_of_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintListTuple(OrderedCount("abracadabra"));
            Console.ReadLine();
        }
        public static List<Tuple<char, int>> OrderedCount(string input)
        {
            var resultList = new List<Tuple<char, int>>();
            var letterDictionary = new Dictionary<char, int>();
            foreach (var letter in input)
            {
                if (letterDictionary.ContainsKey(letter))
                    letterDictionary[letter]++;
                else
                    letterDictionary.Add(letter, 1);
            }
            letterDictionary = letterDictionary.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, y => y.Value);
            foreach (var element in letterDictionary)
                resultList.Add(new Tuple<char, int>(element.Key, element.Value));
            return resultList;
        }
        public static void PrintListTuple(List<Tuple<char, int>> list)
        {
            foreach (var element in list)
                Console.WriteLine(element.Item1 + " " + element.Item2);
            Console.WriteLine();
        }
    }
}
