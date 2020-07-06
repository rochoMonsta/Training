using System;

namespace ATM_C_Sharp
{
    class CardHolder
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public CardHolder() { }
        public CardHolder(string Name, string Surname, int Age)
        {
            if (string.IsNullOrWhiteSpace(Name))
                throw new ArgumentNullException(nameof(Name), "Wrong type of Name.");
            else
                this.Name = Name;

            if (string.IsNullOrWhiteSpace(Surname))
                throw new ArgumentNullException(nameof(Surname), "Wrong type of Surname.");
            else
                this.Surname = Surname;

            if (Age < 16)
                throw new ArgumentException(nameof(Age), "Wrong age.");
            else
                this.Age = Age;
        }
        public override string ToString()
        {
            return $"Account:\n\tName: {Name};\n\tSurname: {Surname};\n\tAge: {Age};\n";
        }
    }
}
