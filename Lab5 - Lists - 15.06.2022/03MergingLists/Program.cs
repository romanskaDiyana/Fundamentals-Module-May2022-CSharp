using System;
using System.Collections.Generic;
using System.Linq;

namespace _03MergingLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //03.Marging Lists
            //You are going to receive two lists of numbers.
            //Create a list that contains the numbers from both of the lists.
            //The first element should be from the first list, the second from
            //the second list, and so on. If the length of the two lists is not equal,
            //just add the remaining elements at the end of the list.

            List<int> list1 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> list2 = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> mergedList = new List<int>();

            int biggerListCount = list1.Count;
            if (biggerListCount < list2.Count)
            {
                biggerListCount = list2.Count;
            }
            //int biggerListCount = Math.Max(list1.Count, list2.Count); 

            for (int i = 0; i < biggerListCount; i++)
            {
                if (list1.Count > i)
                {
                    mergedList.Add(list1[i]);
                }
                if (list2.Count > i)
                {
                    mergedList.Add(list2[i]);
                }            
            }
            Console.WriteLine(String.Join(" ", mergedList));
        }
    }
}
