using System;
using System.Collections.Generic;
using System.Linq;

namespace Address_Book_by_State
{
    class Program
    {
        static void Main(string[] args)
        {

            String ad0 = "John Daggett, 341 King Road, Plymouth MA\n" +
                            "Alice Ford, 22 East Broadway, Richmond VA\n" +
                            "Orville Thomas, 11345 Oak Bridge Road, Tulsa OK\n" +
                            "Terry Kalkas, 402 Lans Road, Beaver Falls PA\n" +
                            "Eric Adams, 20 Post Road, Sudbury MA\n" +
                            "Hubert Sims, 328A Brook Road, Roanoke VA\n" +
                            "Amy Wilde, 334 Bayshore Pkwy, Mountain View CA\n" +
                            "Sal Carpenter, 73 6th Street, Boston MA";
            Console.WriteLine(ByState(ad0));
            Console.ReadLine();
        }
        public static string ByState(string str)
        {
            var friends_dict = new Dictionary<string, List<Person>>()
            {
                {"Arizona", new List<Person>() }, {"California", new List<Person>()},
                {"Idaho", new List<Person>() }, {"Indiana", new List<Person>()},
                {"Massachusetts", new List<Person>()}, {"Oklahoma", new List<Person>()},
                {"Pennsylvania", new List<Person>()}, {"Virginia", new List<Person>()}
            };
            foreach (var element in str.Split('\n'))
            {
                var person = new Person(element.Split(','));
                FriendsByState(person, friends_dict);
            }
            foreach (var element in friends_dict.Keys.ToList())
                friends_dict[element] = friends_dict[element].OrderBy(x => x.Name).ToList();

            return AddresBookStringBuilder(friends_dict);
        }
        public static void FriendsByState (Person person, Dictionary<string, List<Person>> lst)
        {
            if (person.State.Contains("AZ")) { person.State = person.State.Replace("AZ", "Arizona"); lst["Arizona"].Add(person); }
            if (person.State.Contains("CA")) { person.State = person.State.Replace("CA", "California"); lst["California"].Add(person); }
            if (person.State.Contains("ID")) { person.State = person.State.Replace("ID", "Idaho"); lst["Idaho"].Add(person); }
            if (person.State.Contains("IN")) { person.State = person.State.Replace("IN", "Indiana"); lst["Indiana"].Add(person); }
            if (person.State.Contains("MA")) { person.State = person.State.Replace("MA", "Massachusetts"); lst["Massachusetts"].Add(person); }
            if (person.State.Contains("OK")) { person.State = person.State.Replace("OK", "Oklahoma"); lst["Oklahoma"].Add(person); }
            if (person.State.Contains("PA")) { person.State = person.State.Replace("PA", "Pennsylvania"); lst["Pennsylvania"].Add(person); }
            if (person.State.Contains("VA")) { person.State = person.State.Replace("VA", "Virginia"); lst["Virginia"].Add(person); }
        }
        public static string AddresBookStringBuilder (Dictionary<string, List<Person>> lst)
        {
            string result = "";
            foreach (var element in lst.Keys.ToList())
            {
                if (lst[element].Count != 0 && lst[element] != null)
                {
                    if (result == "")
                        result += String.Format("{0}\n", element);
                    else
                        result += String.Format(" {0}\n", element);
                    foreach (var person in lst[element])
                        result += String.Format("..... {1}{2}{3}\n", element, person.Name, person.Street, person.State);
                }
            }
            return result.Substring(0, result.Length - 1);
        }
    }
    public class Person
    {
        public string Name { get; set; }
        public string Street { get; set; }
        public string State { get; set; }
        public Person (string[] person_info)
        {
            if (person_info.Length == 3)
            {
                Name = person_info[0];
                Street = person_info[1];
                State = person_info[2];
            }
        }
        public override string ToString()
        {
            return $"{Name}{Street}{State}\n";
        }
    }
}
