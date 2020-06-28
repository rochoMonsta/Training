using System;
using System.Linq;

namespace Your_order_please
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Order("is2 Thi1s T4est 3a"));
            Console.ReadLine();
        }
        //public static string Order(string words)
        //{
        //    if (String.IsNullOrWhiteSpace(words))
        //        return "";
        //    else
        //    {
        //        string result = "";
        //        var words_list = new List<Word>();
        //        foreach (var element in words.Split())
        //        {
        //            var word = new Word();
        //            word.word = element;
        //            foreach (var letter in element)
        //                if (Char.IsDigit(letter))
        //                    word.word_position = Convert.ToInt32(letter.ToString());
        //            words_list.Add(word);
        //        }
        //        words_list = words_list.OrderBy(x => x.word_position).ToList();
        //        foreach (var element in words_list)
        //            result += element.word + " ";
        //        return result.Trim();
        //    }
        //}
        public static string Order(string words)
        {
            if (string.IsNullOrEmpty(words))
                return "";
            else
                return string.Join(" ", words.Split().OrderBy(word => word.ToList().Find(letter => char.IsDigit(letter))));
        }
    }
    //public class Word
    //{
    //    public string word { get; set; }
    //    public int word_position { get; set; }
    //}
}
