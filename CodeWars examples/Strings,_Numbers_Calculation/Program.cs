using System;
using System.Collections.Generic;
using System.Linq;

namespace Strings__Numbers_Calculation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(calculateString(";$%§fsdfsd235??df/sdfgf5gh.000kk0000"));
            Console.WriteLine(calculateString("sdfsd23454sdf*2342"));
            Console.WriteLine(calculateString("fsdfsd235???34.4554s4234df-sdfgf2g3h4j442"));
            Console.WriteLine(calculateString("fsdfsd234.4554s4234df+sf234442"));
            Console.ReadLine();
        }
        public static string calculateString(string calcIt)
        {
            calcIt = calcIt.Replace('.', ',');
            string dirty_string = "";

            char[] numbers = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', ','};
            char[] operations = { '/', '*', '+', '-' };

            List<string> operators = new List<string>();
            for (int i = 0; i < calcIt.Length; ++i)
            {
                if (numbers.Contains(calcIt[i]))
                    dirty_string += calcIt[i];
                if (operations.Contains(calcIt[i]))
                {
                    operators.Add(dirty_string);
                    dirty_string = calcIt[i].ToString();
                    operators.Add(dirty_string);
                    dirty_string = "";
                }
            }
            operators.Add(dirty_string);
            return GetResult(operators);
        }
        public static string GetResult(List<string> list)
        {   
            var first_number = Convert.ToDouble(list[0]);
            var second_number = Convert.ToDouble(list[2]);
            switch (list[1])
            {
                case "*": return Math.Round(first_number * second_number).ToString();
                case "/": return Math.Round(first_number / second_number).ToString();
                case "+": return Math.Round(first_number + second_number).ToString();
                case "-": return Math.Round(first_number - second_number).ToString();
                default: return "Null";
            }
        }
    }
}
