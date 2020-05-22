using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encrypt_this
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(EncryptThis("hello world"));
            Console.ReadLine();
        }
        //public static string EncryptThis(string input)
        //{
        //    string result_input_after_encrypt = "";

        //    if (input == "")
        //        return result_input_after_encrypt;
        //    else
        //    {
        //        var words_array = input.Split();
        //        for (int i = 0; i < words_array.Length; ++i)
        //        {
        //            if (words_array[i].Length == 1)
        //            {
        //                result_input_after_encrypt += (int)words_array[i][0];
        //                if (i != words_array.Length - 1)
        //                    result_input_after_encrypt += ' ';
        //            }
        //            if (words_array[i].Length == 2)
        //            {
        //                result_input_after_encrypt += (int)words_array[i][0];
        //                result_input_after_encrypt += words_array[i][1];
        //                if (i != words_array.Length - 1)
        //                    result_input_after_encrypt += ' ';
        //            }
        //            if (words_array[i].Length >= 3)
        //            {
        //                result_input_after_encrypt += (int)words_array[i][0];
        //                var word_char_array = words_array[i].ToArray();

        //                char char_box = word_char_array[1];
        //                word_char_array[1] = word_char_array[word_char_array.Length - 1];
        //                word_char_array[word_char_array.Length - 1] = char_box;

        //                for (int j = 1; j < word_char_array.Length; ++j)
        //                    result_input_after_encrypt += word_char_array[j];
        //                if (i != words_array.Length - 1)
        //                    result_input_after_encrypt += ' ';
        //            }
        //        }
        //        return result_input_after_encrypt;
        //    }
        //}
        //public static string EncryptThis(string s)
        //  => string.Join(" ", s.Split(' ').Select(Encrypt));
        //public static string Encrypt(string input)
        //{
        //    if (string.IsNullOrEmpty(input)) return "";
        //    else if (input.Length == 1) return $"{(int)input[0]}";
        //    else if (input.Length == 2) return $"{(int)input[0]}{input[1]}";
        //    return $"{(int)input[0]}{input.Last()}{input.Substring(2, input.Length - 3)}{input[1]}";
        //}
        public static string EncryptThis(string input)
        {
            if (input.Length < 1) return "";
            string rtn = "";
            foreach (string s in input.Split())
            {
                rtn += (int)(s[0]);
                if (s.Length > 1) rtn += s[s.Length - 1];
                if (s.Length > 3) rtn += s.Substring(2, s.Length - 3);
                if (s.Length > 2) rtn += s[1];
                rtn += " ";
            }
            return rtn.Trim();
        }
    }
}
