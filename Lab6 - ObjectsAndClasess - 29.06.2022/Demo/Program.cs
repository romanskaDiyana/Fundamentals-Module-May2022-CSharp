using System;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog firstDog = new Dog();

            firstDog.Name = "John";
            firstDog.Breed = "Corgy";
            firstDog.Age = 7;
            firstDog.Weight = 5.3;

            firstDog.DogSayHello();
            firstDog.DogSayName();
            firstDog.DogInformation();
            firstDog.DogSayBye();
            Console.WriteLine(firstDog.DogSaySeeYouAgain());

            Console.WriteLine("---------------------------");

            Dog secondDog = new Dog()
            {
                Name = "Dalaya",
                Breed = "Schepard",
                Age = 7,
                Weight = 50.5
            };          
            secondDog.DogSayHello();
            secondDog.DogSayName();
            secondDog.DogInformation();
            secondDog.DogSayBye();
            Console.WriteLine(secondDog.DogSaySeeYouAgain());
        }
    }

    class Dog

    {
        public string Name { get; set; }

        public string Breed { get; set; }

        public int Age { get; set; }

        public double Weight { get; set; }
  

        public void DogSayHello()
        {
            Console.WriteLine("Hello from me!");
        }

        public void DogSayName()
        {
            Console.WriteLine(this.Name);
        }

        public void DogInformation()
        {
            Console.WriteLine($"My name is: {this.Name}, my breed is {this.Breed}, I am {this.Age}, years old, " +
                $"and my weight is {this.Weight}kg.!");
        }

        public void DogSayBye()
        {
            Console.WriteLine("Bye from me!");
        }     

        public string DogSaySeeYouAgain()
        {
            return "See you again!";
        }     
    }
}
