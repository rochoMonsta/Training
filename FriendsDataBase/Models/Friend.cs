using System;
using System.ComponentModel.DataAnnotations;

namespace FriendsDataBase.Models
{
    class Friend
    {
        [Key]
        public int FriendID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public Friend() { }
        public Friend(string Name, string Surname)
        {
            if (string.IsNullOrWhiteSpace(Name) || string.IsNullOrWhiteSpace(Surname))
                throw new ArgumentNullException();
            this.Name = Name; this.Surname = Surname;
        }
        public string GetFullName() => $"{this.Name} {this.Surname}";
    }
}
