using System;
using System.Linq;

namespace Validate_my_Password
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(validator("Username123!"));
            Console.ReadLine();
        }
        public static string validator(string password)
        {
            password = password.ToLower();
            if (password.Length <= 3 || password.Length >= 20)
                return "INVALID";
            else
            {
                bool has_number = false, has_letter = false;
                char[] numbers = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
                char[] letters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i',
                                   'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r',
                                   's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
                foreach (var element in password)
                {
                    if (!numbers.Contains(element) && !letters.Contains(element))
                        return "INVALID";
                    else
                    {
                        if (numbers.Contains(element) && has_number == false)
                            has_number = true;
                        if (letters.Contains(element) && has_letter == false)
                            has_letter = true;
                    }
                }
                if (has_letter && has_number)
                    return "VALID";
                else
                    return "INVALID";
            }
        }
        //public static string validator(string password)
        //{
        //    bool is_valid = password.Length > 3 && password.Length < 20 && !password.Any(Char.IsPunctuation) && password.Any(Char.IsDigit) && password.Any(Char.IsLetter);
        //    return is_valid == true ? "VALID" : "INVALID";
        //}
        //public static string validator(string password)
        //{
        //    if (password.Length <= 3 || password.Length >= 20)
        //        return "INVALID";

        //    if (password.Any(x => !char.IsLetter(x) && !char.IsDigit(x)))
        //        return "INVALID";

        //    if (password.All(x => char.IsLetter(x)) || password.All(x => char.IsDigit(x)))
        //        return "INVALID";

        //    return "VALID";
        //}
    }
}
