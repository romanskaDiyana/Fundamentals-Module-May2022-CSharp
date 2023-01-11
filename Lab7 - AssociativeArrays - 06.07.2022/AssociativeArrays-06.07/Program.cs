using System;
using System.Collections.Generic;
using System.Linq;

namespace AssociativeArrays_06._07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Associative Arrays
            //01.Dictionary - C#, Map, HashMap, Associative Arrays - Java Script, HashTable - Java;
            //02.Асоциативни масиви - колекция от ключове и стойности;
            //03.Всяка една клетка има ключ и стойност;
            //04.Синтаксис - Dictionary<key,value>, ключа и стойността, могат да бъдат от всеки тип данни,
            //могат да бъдат и методи,класове,масиви,листи и т.н;
            //САМО в C# Dictionary пази ключовете в реда в който сме ги въвели!!!!;


            //Dictionary 1
            //---------------------------------------------------//

            //Dictionary<string,float> studentDictionary = new Dictionary<string, float>();

            //studentDictionary.Add("Pesho", 3.99f);
            //studentDictionary.Add("Miti", 2.99f); 
            //studentDictionary.Add("Maria", 5);

            //Console.WriteLine(string.Join(",", studentDictionary)); //за печат на всички;
            //Console.WriteLine(studentDictionary["Pesho"]); //печат на конкретен ключ със стойност;


            //Dictionary 2
            //---------------------------------------------------//
            //Dictionary<double,List<string>> studentGrades = new Dictionary<double,List<string>>();

            //studentGrades.Add(2, new List<string>()); //превръщаме ключа 2 в лист и добаваме
            //studentGrades[2].Add("Pesho");
            //studentGrades[2].Add("Gosho"); //пълнене на ключа 2 с лист от имена на студенти
            //studentGrades[2].Add("Kiro");

            //Console.WriteLine(string.Join(",", studentGrades[2])); //достъпваме листа с ключ 2


            //Dictionary 3 - Manipulation
            //---------------------------------------------------//

            //Dictionary<string, decimal> productPrices = new Dictionary<string, decimal>()

            //{
            //    { "kiwi", 10}, //задаване на стойности предварително
            //    { "apple", 20}
            //};
            //Console.WriteLine("Before new values");
            //Console.WriteLine(string.Join(",", productPrices));
            //Console.WriteLine("------------------");

            //productPrices["kiwi"] = 100; // промяна на стойности
            //productPrices["apple"] = 5;

            //Console.WriteLine("After new values");
            //Console.WriteLine(string.Join(",", productPrices));
            //Console.WriteLine("------------------");

            //productPrices.Add("bannana", 5.99m);
            //productPrices.Add("pineapple", 3.89m); //добавяне на нови стойности

            //Console.WriteLine("After new values");
            //Console.WriteLine(string.Join(",", productPrices));
            //Console.WriteLine("------------------");

            //productPrices.Remove("kiwi"); //премахване на стойности

            //Console.WriteLine("After removing value");
            //Console.WriteLine(string.Join(",", productPrices));
            //Console.WriteLine("------------------");

            //string key = Console.ReadLine();          
            //bool result = productPrices.ContainsKey(key); //проверка за наличие на такъв ключ

            //Console.WriteLine("Checking if dictionary contains a certain key");
            //Console.WriteLine($"Contains key {key}  - > {productPrices.ContainsKey(key)}"); //връща true или false
            //Console.WriteLine("------------------");
            //if (result == true)
            //{
            //    productPrices.Remove(key);
            //}

            //Console.WriteLine("Removing a certain key");
            //Console.WriteLine(string.Join(",", productPrices));
            //Console.WriteLine("------------------");


            //Dictionary 4 - Sorting
            //---------------------------------------------------//

            //    SortedDictionary<int, string> studentNames = new SortedDictionary<int, string>(new IntComparer());

            //    studentNames.Add(5, "Ilian");
            //    studentNames.Add(3, "Marian");
            //    studentNames.Add(2, "Gosho");
            //    studentNames.Add(4, "Pesho");
            //    studentNames.Add(6, "Krasimir");

            //    foreach (var item in studentNames)
            //    {
            //        Console.WriteLine($"{item.Key} -> {item.Value}"); //печат на ключ и стойност
            //    }
            //}


            //class IntComparer : IComparer<int>

            //{
            //    public int Compare(int x, int y)
            //    {
            //        return y - x; // result < 0 - ако x > y, 0, ако са равни, >0, ако y е по-голям от x
            //        //descending order
            //    }

            //}


            //Lambda Expressions 
            //---------------------------------------------------//

            //List<int> ints = new List<int>()
            //{ 1, 2, 3, 4, 5};

            //ints = ints.Where(x => x % 2 == 0).ToList(); //съкратен запис на метод 
            ////казва - приема число х и връща резултат от х % 2 == 0? 
            ////Where го вика за всеки един елемент и проверява;

            //Console.WriteLine(String.Join(" ", ints));

            //---------------------------------------------------//
            //static bool isEven(int x)
            //{
            //    return x % 2 == 0; //може да се напише с Lambda
            //}

            //LINQ
            //---------------------------------------------------//
            //библиотека за работа с колекции


            //List<int> list = new List<int>()
            //{ 1, 2, 3, 4, 5};

            //Console.WriteLine(list.Max());

            //Select().- mapping от една колекция към друга, взима един тип данни и го прави на друг тип данни;

            //List<string> stringList = list.Select(x => x.ToString()).ToList(); //превръчаще на лист от числа
            //в лист от стрингове;

            //---------------------------------------------------//
            //List<int> list = new List<int>()
            //{ 1, 2, 3, 4, 5};

            //List<char> charList = list.Select(NumberToChar).ToList();

            //static char NumberToChar(int number)
            //{
            //    return (char) number;     
            //}

            //Console.WriteLine(string.Join(" ", charList));
            //---------------------------------------------------//

            //List<int> list = new List<int>()
            //{ 1, 2, 3, 4, 5};
            //List<char> charList = list.Select((x,index) => { return (char)x; }).ToList(); //друг начин


            //---------------------------------------------------//
            //List<int> list = new List<int>()
            //{ 1, 2, 3, 4, 5};
            //List<char> charList = list.Select((x, index) => 
            //{
            //    Console.WriteLine("Index: " + index);
            //    Console.WriteLine("Selected number: " + x);
            //    return (char)x;

            //}).ToList(); //друг начин
            ////може да се получи и индекса на самата lambda;


            //Where
            //----------------------------------------------------------//

            //List<int> list = new List<int>()
            //{ 1, 2, 3, 4, 5, 6, 7, 9, 8, 2};

            //list = list.Where(x => x % 2 == 0).ToList(); //LINQ никога не променя колекция, създава нова;
            ////Where връща булеви израз, true или false; 
            //Console.WriteLine(string.Join(" ", list));


            //Random
            //---------------------------------------------------------//
            //List<int> list2 = new List<int>()
            //{ 1, 2, 3, 4, 5, 6, 7, 9, 8, 2};

            //Random random = new Random();

            //list2 = list2.Where(x => random.Next() % 2 == 0).ToList(); //LINQ никога не променя колекция, създава нова;
            ////Where връща булеви израз, true или false; 
            //Console.WriteLine(string.Join(" ", list2));


            //Take(n) - взима, колкото прецени
            //---------------------//
            //Skip(n) - пропуска, колкото напишем 
            //---------------------//


            //Pagination 
            //------------------------------------------------------------//
            //List<int> list2 = Enumerable.Range(0,100).ToList();

            //int page = int.Parse(Console.ReadLine());
            //int count = 10;

            //list2 = list2
            //    .Skip(page*count)
            //    .Take(count)
            //    .ToList();  

            //Console.WriteLine(String.Join(" ", list2));
            //------------------------------------------------------------//

            //Dictionary Order By
            //------------------------------------------------------------//


            //Dictionary<string, List<string>> countryAndCities = new Dictionary<string, List<string>>();

            //countryAndCities.Add("Bulgaria", new List<string>());
            //countryAndCities.Add("Croatia", new List<string>());
            //countryAndCities.Add("USA", new List<string>());

            //countryAndCities["Bulgaria"].Add("Sofia");
            //countryAndCities["Bulgaria"].Add("Plovdiv");
            //countryAndCities["Bulgaria"].Add("Varna");

            //countryAndCities["USA"].Add("Los Angelis");
            //countryAndCities["USA"].Add("New York");
            //countryAndCities["USA"].Add("Santa Monica");

            //countryAndCities = countryAndCities
            //    .OrderBy(c => c.Key) // c=> c.Value.Count - по големина на стойността
            //    .ThenByDescending(c => c.Key)                                     
            //    .ToDictionary(c => c.Key, c => c.Value);

            //foreach (var country in countryAndCities)
            //{
            //    Console.WriteLine($"{country.Key} -> { string.Join("", country.Value)}");
            //}


            //-----------------------------------//
            //Задача TOP 3

            List<int> list = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .OrderByDescending(x => x)
                .Take(3)
                .ToList();

            Console.WriteLine(String.Join(" ", list));
        }
    }
}


