using System;
using System.Linq;

namespace RandomPasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            string CharacherCharset = "abcdefghijkl" +
                                      "mnopqrstuvwx" +
                                      "yz1234567890" +
                                      "ABCDEFGHIJKL" +
                                      "MNOPQRSTUVWX" +
                                      "YZ!@#$%^&*()" +
                                      "_-+[]{};/';.,";
            //Generate 10 random password
            for (int i = 0; i < 10; ++i)
                Console.WriteLine(GerRandomPassword(16, CharacherCharset));

            Console.ReadLine();

        }
        /// <summary
        /// This method creates a random password>
        /// </summary>
        /// <param name="passwordlenth" password length></param>
        /// <param name="charset" the ribbon from which the characters will be randomly selected></param>
        /// <returns created password></returns>
        public static string GerRandomPassword(int passwordlenth, string charset)
        {
            string password = "";
            Random random = new Random(Guid.NewGuid().ToByteArray().Sum(x => x));
            for (int i = 0; i < passwordlenth; ++i)
                password += charset[random.Next(charset.Length)];
            return password;
        }
    }
}
