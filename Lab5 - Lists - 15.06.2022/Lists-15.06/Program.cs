using System;
using System.Collections.Generic;
using System.Linq;

namespace Lists_15._06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Листи
            //1. Динамична големина, без нужда от задаване на размер на листа;
            //2. Вътрешната имплементация на лист е масив;
            //3. Индексацията е отново от 0;
            //4. Изпечатва се с .Count;
            //5. Add - добавя елемент накрая, като последен индекс, индексите се увеличават с 1, Count се увеличава с 1;
            //6. Remove - премахва конкретна стойност, запазена в индекса, всички елементи от дясно, 
            // ще се преместят наляво, последния индекс изчезва и Count намалява с 1;
            //7. RemoveAt - конкретна стойност, на конкретна позиция; 
            //8. Insert - посочва се стойност, на конкретен индекс, всичко от индекса надясно се премества с 1 на дясно,
            //Count се увеличава с 1;

            //Basic Lists
            //-----------------------------------------------------------------//
            //List <int> numbers = new List<int> ();

            //numbers.Add(5);
            //numbers.Add(6);
            //numbers.Add(7);

            //Console.WriteLine($"Count:{numbers.Count}");

            //Console.WriteLine(numbers[numbers.Count - 1]); //стойността запазена в последния индекс;

            //Console.WriteLine(String.Join(",", numbers));

            //for (int i = 0; i < numbers.Count; i++)
            //{
            //    Console.WriteLine($"numbers[{i}] = {numbers[i]}"); //стойността запазена във всеки индекс;
            //}



            //Manipulation lists
            //----------------------------------------------------------------//


            //List<int> list = new List<int> ()
            //{ 23,3,43,3,3,35,21};

            //static void PrintList(List<int> list)
            //{
            //    for (int i = 0; i < list.Count; i++)
            //    {
            //        Console.WriteLine($"list[{i}] = {list[i]}");
            //    }

            //    Console.WriteLine("\n----------------\n");
            //}
            //PrintList(list);



            //list.Add(44); //Add;
            //PrintList(list);

            //list.Remove(43); //Remove; //маха стойност;
            //PrintList(list);

            //list.Insert(1, 155); //Insert;
            //PrintList(list);

            //list.Insert(1, 156); //Insert;
            //PrintList(list);

            //list.Insert(1, 157); //Insert;
            //PrintList(list);

            //list.RemoveAt(0); //RemoveAt; маха индекса; 
            //PrintList(list);

            //list.Remove(-1); //Remove - дава резултат, true Или false;
            //PrintList(list);

            //Console.WriteLine($"{list.Contains(23)}"); //Contains - проверка дали се съдържа,
            //                                           //конкретната стойност;
            //                                           //връща true или false;


            //при наличие на няколко еднакви стойности и зиползване на Remove, ще се премахне първия индекс 
            //със стойността;

            //list.RemoveAll(x=> x == 3); - премахване на всички 3-ки;


            //Премахване на индекси, като се запазва номера на индекса;
            //--------------------------------------------------------------------//

            //List<int> list = new List <int>()

            //{ 1,2,3,4,6,7,8,9,8,5,6,7,8,9};

            //for (int i = 0; i < list.Count; i++)
            //{
            //    if (list[i] % 2 == 0)
            //    {
            //        list.Remove(list[i]);
            //        i--; //запазване на индекса!
            //    }
            //}

            //Console.WriteLine(String.Join("," , list));




            //Reading Lists from the Console
            //---------------------------------------------------------------------//

            //int sizeOfList = int.Parse(Console.ReadLine());

            //List<int> numbers = new List<int>();

            //for (int i = 0; i < sizeOfList; i++)
            //{
            //    numbers.Add(int.Parse(Console.ReadLine()));
            //}

            //Console.WriteLine(String.Join(",", numbers));
            //Console.WriteLine(numbers.Count);


            //Reading Lists from the Console - single line
            //-------------------------------------------------------------------//


            //string[] input = Console.ReadLine().Split();
            //                                               ||
            //List <int> list = new List<int> ();            ||  
            //                                               ||      на един ред:
            //for (int i = 0; i < input.Length; i++)         ||  
            //{                                              ||       
            //    list.Add(int.Parse(input[i]));             || 
            //}                                              ||

            //List<int> list = input.Select(int.Parse).ToList(); //кастване към Int;

            //List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList(); - на един ред;

            //Console.WriteLine(String.Join(",", input));



            //Sorting Arrays and Lists!!!!!!!!!!!!!!!!!!!!!!!
            //------------------------------------------------------------------//

            //Selection Sort!!!!!!!!!!!!

            //Algorithm:
            //1. Find min element
            //2. Swap min element with first element
            //3. Repeat for next current element


            //ASCENDING ORDER: ВЪЗХОДЯЩ РЕД


            List<int> list = new List<int>()
            {
                44,21,5,33,17,4,13,1
            };

            for (int i = 0; i < list.Count; i++)
            {

                int smallestElementIndex = i;
                for (int j = i; j < list.Count; j++)
                {
                    if (list[j] < list[smallestElementIndex])
                    {
                        smallestElementIndex = j;
                    }
                }

                int swappingElement = list[i];
                list[i] = list[smallestElementIndex];
                list[smallestElementIndex] = swappingElement;
            }

            Console.WriteLine(String.Join(" ", list));


            //DESCENDING ORDER: НИЗХОДЯЩ РЕД

            List<int> descendingList = new List<int>()
            {
                44,21,5,33,17,4,13,1
            };

            for (int currentSection = 0; currentSection < descendingList.Count; currentSection++)
            {

                int biggestElementSection = currentSection; //приемаме, че индекса на най-малката стойност е индекса, който е след сортирания;



                for (int checkingEachElementSection = currentSection; checkingEachElementSection < descendingList.Count; checkingEachElementSection++) //цикъла започва от всеки следващ несортиран индекс
                {
                    if (descendingList[checkingEachElementSection] > descendingList[biggestElementSection])
                    {
                        biggestElementSection = checkingEachElementSection;
                    }
                }

                int swappingElement = descendingList[currentSection]; //избираме елемента, които ще се сменя;
                descendingList[currentSection] = descendingList[biggestElementSection]; //сменяме елемента;
                descendingList[biggestElementSection] = swappingElement; //запазваме в променлива, новата стойност;
            }

            Console.WriteLine(String.Join(" ", descendingList));


























        }
    }
}
