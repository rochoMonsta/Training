using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Easy_Balance_Checking
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Balance("1000.00!=\n125 Market !=:125.45\n126 Hardware =34.95\n127 Video! 7.45\n128 Book   :14.32\n129 Gasoline ::16.10"));
            Console.WriteLine();
            Console.WriteLine(Balance("1233.00\n125 Hardware;! 24.80?\n123 Flowers 93.50;\n127 Meat 120.90\n120 Picture 34.00\n124 Gasoline 11.00\n" +
                    "123 Photos;! 71.40?\n122 Picture 93.50\n132 Tyres;! 19.00,?;\n129 Stamps; 13.60\n129 Fruits{} 17.60\n129 Market;! 128.00?\n121 Gasoline;! 13.60?"));
            Console.ReadLine();
        }
        public static string Balance(string book)
        {
            book = GetCorrectBook(book);
            var string_list = book.Split('\n');
            double balance = Convert.ToDouble(string_list[0]);
            double start_balance = balance, total_expense = 0;

            var operation_list = new List<Operation>();
            for (int i = 1; i < string_list.Length; ++i)
            {
                var operation = new Operation(string_list[i].Split(), balance);
                operation_list.Add(operation);
                balance = operation.Balance;
                total_expense += operation.OperationPrice;
            }
            return CreateStringResult(start_balance, operation_list, total_expense);
        }
        public static string GetCorrectBook(string book)
        {
            string result = "";
            foreach (var letter in book)
                if (Char.IsDigit(letter) || Char.IsLetter(letter) || letter == '.' || letter == '\n' || letter == ' ')
                    result += letter;
            return Regex.Replace(result, " {2,}", " ").Replace('.', ',');
        }
        public static string CreateStringResult(double start_balance, List<Operation> operations, double total_expense)
        {
            string result = $"Original Balance: {start_balance.ToString("0.00").Replace(',', '.')}\n";
            double average_expense = total_expense / operations.Count;
            foreach (var element in operations)
                result += element.ToString();
            result += $"Total expense  {total_expense.ToString("0.00").Replace(',', '.')}\n";
            result += $"Average expense  {average_expense.ToString("0.00").Replace(',', '.')}";

            return result;
        }

    }
    public class Operation
    {
        public int ID { get; set; }
        public string Operation_ { get; set; }
        public double Balance { get; set; }
        public double OperationPrice { get; set; }
        public Operation() { }
        public Operation(string[] operations_info, double current_balance)
        {
            if (operations_info.Length == 3)
            {
                ID = Convert.ToInt32(operations_info[0]);
                Operation_ = operations_info[1];
                OperationPrice = Convert.ToDouble(operations_info[2]);
                Balance = current_balance - OperationPrice;
            }
        }
        public override string ToString()
        {
            return $"{ID} {Operation_} {OperationPrice.ToString("0.00").Replace(',', '.')} Balance {Balance.ToString("0.00").Replace(',', '.')}\n";
        }
    }
}
