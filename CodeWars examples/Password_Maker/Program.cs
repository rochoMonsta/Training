using System;
using System.Linq;
using System.Text;

namespace Password_Maker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MakePassword(16, true, true, true));
            Console.ReadLine();
        }
        public static string MakePassword(int len, bool flagUpper, bool flagLower, bool flagDigit)
        {
            int number_or_letter = 1;

            StringBuilder password = new StringBuilder("");
            Random random = new Random(Guid.NewGuid().ToByteArray().Sum(x => x));

            for (int i = 0; i < len; ++i)
            {
                if (flagDigit && (flagUpper || flagLower)) { number_or_letter = random.Next(1, 3); }
                else if (!flagUpper && !flagLower) { number_or_letter = 2; }
                switch (number_or_letter)
                {
                    case 1:
                        char letter = (char)('a' + random.Next(0, 26));
                        while (password.ToString().ToLower().Contains(letter))
                            letter = (char)('a' + random.Next(0, 26));

                        if (flagUpper == true && flagLower == true)
                        {
                            int lower_or_upper = random.Next(1, 3);
                            switch (lower_or_upper)
                            {
                                case 1: password.Append(Char.ToUpper(letter)); break;
                                case 2: password.Append((letter)); break;
                            }
                        }
                        else if (flagUpper && !flagLower)
                            password.Append(Char.ToUpper(letter));
                        else
                            password.Append(letter);
                        break;
                    case 2:
                        password.Append(random.Next(0, 10));
                        break;
                }
            }
            return password.ToString();
        }
    }
}
