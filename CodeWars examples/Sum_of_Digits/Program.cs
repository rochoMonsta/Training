using System;

namespace Sum_of_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DigitalRoot(493193));
            Console.ReadLine();
        }
        public static int DigitalRoot(long n)
        {
            var input = n.ToString();
            while (input.Length != 1)
            {
                int result = 0;
                for (int i = 0; i < input.Length; ++i)
                    result += Int32.Parse(input[i].ToString());
                input = result.ToString();
            }
            return Int32.Parse(input);
        }
    }
}
