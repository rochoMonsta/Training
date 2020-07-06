using System;

namespace ATM_C_Sharp
{
    class BankAccount
    {
        public CardHolder AccountHolder { get; }
        public BankCard BankCard { get; }
        public decimal Balance { get; set; }
        public BankAccount() { }
        public BankAccount(CardHolder cardHolder)
        {
            if (cardHolder == null)
                throw new ArgumentNullException(nameof(cardHolder), "Invalid user.");
            else
            {
                AccountHolder = cardHolder;
                BankCard = new BankCard(cardHolder);
            }
        }
        public override string ToString()
        {
            return $"{BankCard}\n\n\tBalance: {Balance}$\n";
        }
    }
}
