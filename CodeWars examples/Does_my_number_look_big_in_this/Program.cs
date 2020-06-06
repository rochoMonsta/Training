using System;

namespace Does_my_number_look_big_in_this
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Narcissistic(1634));
            Console.ReadLine();
        }
        //A Narcissistic Number is a number which is the sum of its own digits, 
        //each raised to the power of the number of digits in a given base. 
        //In this Kata, we will restrict ourselves to decimal (base 10).
        public static bool Narcissistic(int value)
        {
            double result = 0;
            var valueAsString = value.ToString();
            foreach (var element in valueAsString)
                result += Math.Pow(Char.GetNumericValue(element), valueAsString.Length);
            if (result == value)
                return true;
            return false;
        }
        //public static bool Narcissistic(int value)
        //{
        //    var str = value.ToString();
        //    return str.Sum(c => Math.Pow(Convert.ToInt16(c.ToString()), str.Length)) == value;
        //}
    }
}
