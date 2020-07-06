using System;
using System.Collections.Generic;
using System.Linq;

namespace Character_with_longest_consecutive_repetition
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = LongestRepetition("bbbaaabaaaa");
            Console.WriteLine(result.Item1 + "---" + result.Item2);
            Console.ReadLine();
        }

        //public static Tuple<Char?, Int32> LongestRepetition(String input)
        //=> input
        //       .Select((x, i) => new Tuple<Char?, Int32>(x, input.Substring(i).TakeWhile(y => y == x).Count()))
        //       .OrderByDescending(x => x.Item2)
        //       .FirstOrDefault()
        //   ?? new Tuple<Char?, Int32>(null, 0);
        public static Tuple<char?, int> LongestRepetition(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return new Tuple<char?, int>(null, 0);
            else
            {
                List<Charset> letter_list = new List<Charset>();
                int letter_counter = 1;
                for (int i = 0; i < input.Length - 1; ++i)
                {
                    if (input[i] == input[i + 1]) { letter_counter++; }
                    else
                    {
                        letter_list.Add(new Charset(input[i], letter_counter));
                        letter_counter = 1;
                    }
                    if (i == input.Length - 2)
                        letter_list.Add(new Charset(input[i], letter_counter));
                }
                return GetMaxCount(letter_list);
            }
        }
        public static Tuple<char?, int> GetMaxCount(List<Charset> lst)
        {
            int max = 0;
            foreach (var element in lst)
                if (element.Count > max) { max = element.Count; }
            return new Tuple<char?, int>(lst.First(x => x.Count == max).Letter, lst.First(x => x.Count == max).Count);
        }
    }
    public class Charset
    {
        public char Letter { get; set; }
        public int Count { get; set; }
        public Charset() { }
        public Charset(char Letter, int Count)
        {
            this.Letter = Letter;
            this.Count = Count;
        }
    }
}
