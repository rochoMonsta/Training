using System;
using System.Linq;

namespace ATM_C_Sharp
{
    class BankCard
    {
        public CardHolder CardHolder { get; }
        public string UniqueRoom { get; }
        private string PinCode;
        public BankCard() { }
        public BankCard(CardHolder cardHolder)
        {
            CardHolder = cardHolder;
            var random_generator = new Random(Guid.NewGuid().ToByteArray().Sum(x => x));
            for (int i = 0; i < 12; ++i)
                UniqueRoom += random_generator.Next(0, 9);
            PinCode = CreatePinCode();
        }
        public override string ToString()
        {
            return $"Bank card:\n{CardHolder}\n\tCard number: {UniqueRoom};\n";
        }
        private string CreatePinCode()
        {
            Console.Write("Enter your pin code: ");
            string pin_code = Console.ReadLine();
            while (pin_code.Length != 4)
            {
                Console.Write("Enter your pin code: ");
                pin_code = Console.ReadLine();
            }
            return pin_code;
        }
        public bool CheckForCorrectPin(string pin_code)
        {
            if (PinCode == pin_code)
                return true;
            else
                return false;
        }
    }
}
