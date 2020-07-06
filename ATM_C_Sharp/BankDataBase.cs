using System;
using System.Collections.Generic;
using System.Linq;

namespace ATM_C_Sharp
{
    class BankDataBase
    {
        private static List<BankAccount> bankAccounts = new List<BankAccount>();
        public BankDataBase() { }
        public void AddNewBankAccount(BankAccount bankAccount)
        {
            if (!bankAccounts.Any(x => x.AccountHolder == bankAccount.AccountHolder && x.BankCard == bankAccount.BankCard))
                bankAccounts.Add(bankAccount);
            else
                Console.WriteLine("This account is allready created.");
        }
        public bool CheckForAccount(BankAccount bankAccount)
        {
            if (bankAccounts.Any(x => x.AccountHolder == bankAccount.AccountHolder && x.BankCard == bankAccount.BankCard))
                return true;
            else
                return false;
        }
        public bool CheckForAccount(BankCard bankCard)
        {
            if (bankAccounts.Any(x => x.BankCard == bankCard))
                return true;
            else
                return false;
        }
        public bool CheckForAccount(string card_number)
        {
            if (bankAccounts.Any(x => x.BankCard.UniqueRoom == card_number))
                return true;
            else
                return false;
        }
        public BankAccount GetBankAccount(string card_number)
        {
            if (CheckForAccount(card_number))
                return bankAccounts.Last(x => x.BankCard.UniqueRoom == card_number);
            else
                return null;
        }
        public void TransferTo(string card_number_to, string card_number_from, decimal sum)
        {
            int index_to = bankAccounts.IndexOf(bankAccounts.Last(x => x.BankCard.UniqueRoom == card_number_to));
            int index_from = bankAccounts.IndexOf(bankAccounts.Last(x => x.BankCard.UniqueRoom == card_number_from));
            bankAccounts[index_to].Balance += sum;
            bankAccounts[index_from].Balance -= sum;
        }
    }
}
