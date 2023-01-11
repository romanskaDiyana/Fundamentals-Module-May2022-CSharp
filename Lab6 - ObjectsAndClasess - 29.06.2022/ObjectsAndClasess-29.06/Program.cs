using System;
using System.Collections.Generic;

namespace ObjectsAndClasess_29._06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Objects and Clasess
            //Classes:
            //1.Създаване на наш тип данни,темплейти(таблици) които пазят няколко типа данни с променливи;
            //2.Променлива от типа на нашите данни: 
            //пример - Student(тип данни) , firstStudent(име на промелива) = new Student();
            //Разлика между обект и клас - класа е типа данни, в който се съдържа цялата информация (темплейта)
            //всички типове данни, обекта е конкретния обект, който е в таблицата;
            //Обектите са конкретна информация, която се съдържа в темплейта;
            //Properties трябва да бъдат Private;
            //Properties трябва да са с главна буква;

            //----------------------------------------------------------//
            //class Student
            //---------------------------------------------------------//

            //Student studentInformation = new Student();

            //studentInformation.name = "Diyana";
            //studentInformation.age = 25;
            //studentInformation.grades = new List<double>() { 2, 3, 3 };

            //PrintStudent(studentInformation);


            //static void PrintStudent(Student studentInformation)
            //{
            //    Console.WriteLine(studentInformation.name);
            //}

            //-------------------------------------------------------//
            //class Dog
            //-------------------------------------------------------//

            //Dog dogInformation = new Dog();

            //dogInformation.Name = "Moly";
            //dogInformation.Breed = "Dogo Argentino";
            //dogInformation.Age = 4;

            //dogInformation.DogSayHello();
            //dogInformation.DogInformation();
            //dogInformation.DogSayBye();

            //Dog dogInformation2 = new Dog();

            //dogInformation2.Name = "Alisa";
            //dogInformation2.Breed = "Corgy";
            //dogInformation2.Age = 2;

            //dogInformation2.DogSayHello();
            //dogInformation2.DogInformation();
            //dogInformation2.DogSayBye();


            //Constructor
            //Dog dogInformation3 = new Dog("Sharo", "Corgy", 5);
            //-------------------------------------------------------//


            //-------------------------------------------------------//
            //Get and Set
            //-------------------------------------------------------//

            //Person person = new Person();

            //Console.WriteLine(person.GetFirstName());

            //person.SetFirstName("Pesho");

            //Console.WriteLine(person.GetFirstName());
        }
    }
}
