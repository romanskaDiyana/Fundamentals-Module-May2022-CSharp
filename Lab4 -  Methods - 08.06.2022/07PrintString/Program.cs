using System;

namespace _07PrintString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //07.Print String
            //Create a method that receives two parameters:
            //   • A string
            //   • A number n(integer) represents how many times the string will be repeated
            //The method should return a new string, containing the initial one,
            //repeated n times without space. 


            string text = Console.ReadLine();
            int repeatTextTimes = int.Parse(Console.ReadLine());


            Console.WriteLine(RepeatText(text,repeatTextTimes));


            static string RepeatText(string text, int repeatTextTimes)
            {
                string result = "";
                for (int i = 0; i < repeatTextTimes; i++)
                {
                    result += text;
                }

                return result;
            }
        }
    }
}
