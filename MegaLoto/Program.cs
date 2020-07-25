using System;
using System.Collections.Generic;
using System.Linq;

namespace MegaLoto
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintDictionaryInfo(GetAVGResult(1000, 1000, 41).OrderByDescending(x => x.Value)
                                                            .ToDictionary(x => x.Key, y => y.Value));
            Console.WriteLine("\n--------------------\n");
            PrintDictionaryInfo(GetAVGResult(1000, 1000, 9).OrderByDescending(x => x.Value)
                                                           .ToDictionary(x => x.Key, y => y.Value));

            Console.ReadLine();
        }
        public static Dictionary<int, double> GetRandomCounter (Dictionary<int, double> valueDictionary, int countOfGeneric)
        {
            Random random = new Random(Guid.NewGuid().ToByteArray().Sum(x => x));
            for (int i = 0; i < countOfGeneric; ++i)
            {
                int genericRandomNumber = random.Next(1, valueDictionary.Keys.Count + 1);
                valueDictionary[genericRandomNumber]++;
            }
            return valueDictionary;
        }
        public static Dictionary<int, double> CreateDictionary (int count)
        {
            Dictionary<int, double> valuesDictionary = new Dictionary<int, double>();
            for (int i = 1; i <= count; ++i)
                valuesDictionary.Add(i, 0);
            return valuesDictionary;
        }
        public static void PrintDictionaryInfo (Dictionary<int, double> valueDictionary)
        {
            foreach (var element in valueDictionary.Keys)
                Console.WriteLine($"Число: {element}; Кiлькiсть випадань: {valueDictionary[element]}");
        }
        public static Dictionary<int, double> GetAVGResult (int countOfTest, int countOfGeneric, int dictLength)
        {
            var emptyCopy = CreateDictionary(dictLength);
            for (int counter = 0; counter < countOfTest; ++counter)
            {
                var dictionaryWithNumber = CreateDictionary(dictLength);
                dictionaryWithNumber = GetRandomCounter(dictionaryWithNumber, countOfGeneric);
                for (int i = 1; i <= dictLength; ++i)
                    emptyCopy[i] += dictionaryWithNumber[i];
            }
            for (int counter = 1; counter <= dictLength; ++counter)
                emptyCopy[counter] = emptyCopy[counter] / countOfTest;
            return emptyCopy;
        }
    }
}
