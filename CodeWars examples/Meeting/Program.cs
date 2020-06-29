using System;
using System.Collections.Generic;
using System.Linq;

namespace Meeting
{
    class Program
    {
        static void Main(string[] args)
        {
            string friends_list = "Alex:Arno;Alissa:Cornwell;Sarah:Bell;Andrew:Dorries;Ann:Kern;Haley:Arno;Paul:Dorny;Madison:Kern";
            Console.WriteLine(Meeting(friends_list));
            Console.ReadLine();
        }
        public static string Meeting(string s)
        {
            string result = "";
            List<Person> people = new List<Person>();
            foreach (var element in s.Split(';'))
                people.Add(new Person(element.Split(':')));
            people = people.OrderBy(person => person.Surname)
                           .ThenBy(person => person.Name)
                           .ToList();
            foreach (var person in people)
                result += String.Format("({0}, {1})", person.Surname, person.Name);
            return result;
        }
    }
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public Person (string[] person_info)
        {
            if (person_info.Length == 2)
            {
                Name = person_info[0].ToUpper();
                Surname = person_info[1].ToUpper();
            }
        }
    }
}
