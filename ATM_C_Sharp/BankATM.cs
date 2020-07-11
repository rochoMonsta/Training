using System;

namespace ATM_C_Sharp
{
    class BankATM
    {
        private BankDataBase bankDataBase = new BankDataBase();
        private bool IsEnterPin = false;
        public string ATMIndex { get; set; }
        public BankATM() { }
        public BankATM(string ATMIndex)
        {
            if (string.IsNullOrWhiteSpace(ATMIndex))
                throw new ArgumentNullException(nameof(ATMIndex), "Wrong type of ATMIndex.");
            else
                this.ATMIndex = ATMIndex;
        }
        public void Start(BankCard bankCard)
        {
            if (InputCardAndEnterPin(bankCard))
            {
                ChooseOperation(bankCard);
            }
        }
        private void ChooseOperation(BankCard bankCard)
        {
            if (IsEnterPin)
            {
                Console.WriteLine("Select the operation you want to perform:\n\tTransfer: press 1\n\tEnd: press 0\n\tShow balance: press 2\n\t" +
                    "Exit: press 3\n");
                if (Int32.TryParse(Console.ReadLine(), out int result))
                {
                    switch (result)
                    {
                        case 0:
                            Console.WriteLine("Thank you."); break;
                        case 1:
                            Transfer(bankCard); break;
                        case 2:
                            ShowBalance(bankCard); break;
                        case 3:
                            EndAndExit(bankCard); break;
                        default:
                            Console.WriteLine("This operation doesn't exist."); break;
                    }
                }
                else
                    Console.WriteLine("Wrong type.");
            }
        }
        private bool InputCardAndEnterPin(BankCard bankCard)
        {
            if (bankDataBase.CheckForAccount(bankCard))
            {
                Console.Write("Enter pin code: ");
                string pin_code = Console.ReadLine();
                if (bankCard.CheckForCorrectPin(pin_code))
                {
                    IsEnterPin = true;
                    return true;
                }
                else
                    return false;
            }
            else
                return false;
        }
        private void Transfer(BankCard bankCard)
        {
            if (IsEnterPin)
            {
                Console.Write("Enter the card number of the person to whom you want to send money: ");
                string card_number = Console.ReadLine();
                while (card_number.Length != 12)
                {
                    Console.Write("Enter the card number of the person to whom you want to send money: ");
                    card_number = Console.ReadLine();
                }
                if (bankDataBase.CheckForAccount(card_number))
                {
                    var card_owner_account = bankDataBase.GetBankAccount(bankCard.UniqueRoom);

                    Console.Write("Еnter the transfer amount: ");
                    decimal sum_of_transfer = Convert.ToDecimal(Console.ReadLine());

                    if (card_owner_account.Balance >= sum_of_transfer)
                    {
                        bankDataBase.TransferTo(card_number, bankCard.UniqueRoom, sum_of_transfer);
                        Console.WriteLine("The transfer was successful.");
                    }
                    else
                        Console.WriteLine("Not enough money.");
                }
                else
                    Console.WriteLine("Such a card does not exist.");
            }
            ChooseOperation(bankCard);
        }
        private void ShowBalance(BankCard bankCard)
        {
            if (IsEnterPin)
            {
                var card_owner_account = bankDataBase.GetBankAccount(bankCard.UniqueRoom);
                Console.WriteLine("Your balance: " + card_owner_account.Balance + "$");

                ChooseOperation(bankCard);
            }
        }
        private void EndAndExit(BankCard bankCard)
        {
            if (IsEnterPin)
            {
                Console.Write("End and exit? (<yes> or <no>): ");
                string result = Console.ReadLine();
                while (result != "yes" && result != "no")
                {
                    Console.Write("End and exit? (<yes> or <no>): ");
                    result = Console.ReadLine();
                }

                var card_owner_account = bankDataBase.GetBankAccount(bankCard.UniqueRoom);
                switch (result)
                {
                    case "yes": Console.WriteLine($"Thank you and goodbye. {card_owner_account.AccountHolder.Name} " +
                        $"{card_owner_account.AccountHolder.Surname}!");
                        break;
                    case "no": ChooseOperation(bankCard); break;
                }
            }
        }
    }
}
