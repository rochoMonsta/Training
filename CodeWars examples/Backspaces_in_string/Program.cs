using System;

namespace Backspaces_in_string
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CleanString("abc####d##c#"));
            Console.ReadLine();
        }
        public static string CleanString(string s)
        {
            string result = "";
            for (int i = 0; i < s.Length; ++i)
            {
                if (s[i] != '#')
                    result += s[i];
                else
                {
                    if (result.Length > 0)
                        result = result.Substring(0, result.Length - 1);
                }
            }
            return result;
        }
    }
}
