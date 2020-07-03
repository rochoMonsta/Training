using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace New_Cashier_Does_Not_Know_About_Space_or_Shift
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetOrder("milkshakepizzachickenfriescokeburgerpizzasandwichmilkshakepizza"));
            Console.ReadLine();
        }
        public static Dictionary<string, int> menu = new Dictionary<string, int>()
        {
            {"Burger", 0},
            {"Fries", 0},
            {"Chicken", 0},
            {"Pizza", 0},
            {"Sandwich", 0},
            {"Onionrings", 0},
            {"Milkshake", 0},
            {"Coke", 0}
        };
        public static string GetOrder(string input)
        {
            string order = "";
            foreach (var food in menu.Keys.ToList())
            {
                int count = (input.Length - input.Replace(food.ToLower(), "").Length) / food.ToLower().Length;
                menu[food] = count;
            }
            foreach (var food in menu.Keys.ToList())
                for (int i = 0; i < menu[food]; ++i)
                    order += food + " ";
            return order.Trim();
        }
        //public static string GetOrder(string input)
        //{
        //    return string.Join(" ", new[] { "Burger", "Fries", "Chicken", "Pizza", "Sandwich", "Onionrings", "Milkshake", "Coke" }
        //                 .SelectMany(f => Enumerable.Repeat(f, Regex.Matches(input, f.ToLower()).Count)));
        //}
    }
}
