using System;
using System.Collections.Generic;
using System.Linq;

namespace _07OrderByAge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //07. Order by Age
            //You will receive an unknown number of lines. On each line you will receive an array with 3 elements:
            //    • The first element is a string -the name of the person
            //    • The second element a string -the ID of the person
            //    • The third element is an integer - the age of the person
            //If you get a person whose ID you have already received before,
            //update the name and age for that ID with that of the new person.
            //When you receive the command "End", print all of the people, ordered by age.




            string[] command = Console.ReadLine().Split();

            var listOfPeopleInformation = new List<PersonInformation>();

            while (command[0] != "End")
            {
                var person = new PersonInformation(command[0], command[1], int.Parse(command[2]));

                listOfPeopleInformation.Add(person);

                command = Console.ReadLine().Split();
            }

            //listOfPeopleInformation.OrderBy(x => x.Age).ToList().ForEach(x => Console.WriteLine(x));

            foreach (var person in listOfPeopleInformation.OrderBy(x => x.Age))
            {
                Console.WriteLine(person);
            }
        }
    }

    class PersonInformation
    {
        public PersonInformation(string name, string iD, int age)
        {
            Name = name;
            ID = iD;
            Age = age;
        }

        public string Name { get; set; }

        public string ID { get; set; }

        public int Age { get; set; }

        public override string ToString() => $"{Name} with ID: {ID } is {Age} years old.";
        
    }
}
