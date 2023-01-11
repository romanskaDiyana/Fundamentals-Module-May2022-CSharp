using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectsAndClasess_29._06
{
    internal class Dog
    {
        public string Name { get; set; }
        public string Breed { get; set; }
        public int Age { get; set; } //properties


        public void DogSayHello()
        {
            Console.WriteLine("Hello from dog!");

        }

        public void DogInformation()

        {
            Console.WriteLine($"My name is: {Name}, my breed is {Breed}, and I am {Age} years old");

        }

        public void DogSayBye()
        {
            Console.WriteLine("Bye!");
        }

        //Constructor
        public Dog(string name, string breed, int age)
        {
            Name = name;
            Breed = breed;
            Age = age;
        }
    }
 }
