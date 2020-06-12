using System;

namespace Text
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetNewNext("hello hello my name is hello", "hello"));
            Console.ReadLine();
        }
        public static string GetNewNext(string text, string word)
        {
            var words_in_ = text.Split();
            for (int i = 0; i < words_in_.Length - 1; ++i)
                if (words_in_[i] == word)
                {
                    var box = words_in_[i];
                    words_in_[i] = words_in_[i + 1];
                    words_in_[i + 1] = box;
                }
            return String.Join(" ", words_in_);
        }
    }
}
