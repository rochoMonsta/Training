using System;

namespace ATM_C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            CardHolder cardHolder1 = new CardHolder()
            {
                Name = "Roman",
                Surname = "Cholkan",
                Age = 19
            };
            CardHolder cardHolder2 = new CardHolder()
            {
                Name = "Mia",
                Surname = "Sorokotyaha",
                Age = 19
            };
            BankAccount bankAccount1 = new BankAccount(cardHolder1);
            bankAccount1.Balance = 1000;
            Console.WriteLine(bankAccount1);

            BankAccount bankAccount2 = new BankAccount(cardHolder2);
            bankAccount2.Balance = 22000;

            Console.WriteLine(bankAccount2);

            BankDataBase bankDataBase = new BankDataBase();
            bankDataBase.AddNewBankAccount(bankAccount1);
            bankDataBase.AddNewBankAccount(bankAccount2);

            BankATM ATM = new BankATM("6900");

            ATM.Start(bankAccount1.BankCard);

            Console.WriteLine(bankAccount1);
            Console.WriteLine(bankAccount2);
            Console.ReadLine();
        }
    }
}
