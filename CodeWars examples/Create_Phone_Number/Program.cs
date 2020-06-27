using System;
using System.Linq;

namespace Create_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CreatePhoneNumber(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0}));
            Console.ReadLine();
        }
        public static string CreatePhoneNumber(int[] numbers)
        {
            var numb_ch = numbers.Select(x => x = Convert.ToChar(x)).ToArray();
            string result = String.Concat("(", numb_ch[0], numb_ch[1], numb_ch[2], ") ",
                                           numb_ch[3], numb_ch[4], numb_ch[5], "-",
                                           numb_ch[6], numb_ch[7], numb_ch[8], numb_ch[9]);
            return result;
        }
        //public static string CreatePhoneNumber(int[] numbers)
        //{
        //    return String.Format("({0}{1}{2}) {3}{4}{5}-{6}{7}{8}{9}", numbers.Select(x => x.ToString()).ToArray());
        //}
        //public static string CreatePhoneNumber(int[] numbers)
        //{
        //    return long.Parse(string.Concat(numbers)).ToString("(000) 000-0000");
        //}
    }
}
