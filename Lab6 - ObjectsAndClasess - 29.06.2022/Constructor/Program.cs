using System;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] student= Console.ReadLine().Split();

            string firstName = student[0];
            string lastName = student[1];
            int age = int.Parse(student[2]);


            Student student1 = new Student(firstName,lastName,age);
            
            Console.WriteLine(string.Join(" ", firstName, lastName, age));
        }
    }

    class Student
    {
        public Student(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        public string FirstName { get; set; }    

        public string LastName { get; set; } 

        public int Age { get; set; } 
        

    }
}
