using System;

namespace forbidden_words
{
    class Program
    {
        static void Main(string[] args)
        {
            Forbidden forbidden = new Forbidden();
            string user_message = "You fucking noob and puSSy";
            Console.WriteLine(forbidden.CheckForForbiddenWord(user_message));
            Console.ReadLine();
        }
    }
}
