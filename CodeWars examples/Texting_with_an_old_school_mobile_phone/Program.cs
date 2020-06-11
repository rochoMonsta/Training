using System;
using System.Collections.Generic;
using System.Linq;

namespace Texting_with_an_old_school_mobile_phone
{
    class Program
    {
        public static Dictionary<string, string> phone_buttons = new Dictionary<string, string>()
        {
            {"1", ".,?!" }, {"2", "abc"}, {"3", "def"},
            {"4", "ghi" },  {"5", "jkl"}, {"6", "mno"},
            {"7", "pqrs" }, {"8", "tuv"}, {"9", "wxyz"},
            {"*", "'-+=" }, {"0", " "}, {"0-", "0"},
            {"1-", "1"}, {"2-", "2"}, {"3-", "3"},
            {"4-", "4"}, {"5-", "5"}, {"6-", "6"},
            {"7-", "7"}, {"8-", "8"}, {"9-", "9"},
            {"*-", "*"}, {"#-", "#"}
        };
        static void Main(string[] args)
        {
            Console.WriteLine(SendMessage(".,?! '-+=*#"));
            Console.ReadLine();
        }
        public static string SendMessage(string message)
        {
            string result = " ";
            bool isUpper = false;
            var value_list = new List<string>(phone_buttons.Values);
            foreach (var letter in message)
            {
                char letter_copy = letter;
                if (Char.IsUpper(letter_copy) && isUpper == false)
                {
                    result += '#';
                    letter_copy = Char.ToLower(letter_copy);
                    isUpper = true;
                }
                else if (Char.IsUpper(letter_copy) && isUpper == true)
                {
                    letter_copy = Char.ToLower(letter_copy);
                    isUpper = true;
                }
                else if (isUpper && Char.IsLower(letter_copy))
                {
                    result += '#';
                    isUpper = false;
                }
                for (int i = 0; i < value_list.Count; ++i)
                {
                    if (value_list[i].Contains(letter_copy))
                    {
                        if (result[result.Length - 1] != phone_buttons.ElementAt(i).Key[0])
                        {
                            for (int j = 0; j < value_list[i].IndexOf(letter_copy) + 1; ++j)
                                result += phone_buttons.ElementAt(i).Key;
                            break;
                        }
                        else
                        {
                            result += ' ';
                            for (int j = 0; j < value_list[i].IndexOf(letter_copy) + 1; ++j)
                                result += phone_buttons.ElementAt(i).Key;
                            break;
                        }
                    }
                }
            }
            return result.Substring(1, result.Length - 1);
        }
    }
}
