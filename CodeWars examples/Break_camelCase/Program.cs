using System;

namespace Break_camelCase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(BreakCamelCase("camelCasingTest"));
            Console.ReadLine();
        }
        public static string BreakCamelCase(string str)
        {
            string result_string = "";
            for (int i = 0; i < str.Length; ++i)
            {
                if (!Char.IsUpper(str[i]))
                    result_string += str[i];
                else
                    result_string = result_string + ' ' + str[i];
            }
            return result_string;
        }
    }
}
