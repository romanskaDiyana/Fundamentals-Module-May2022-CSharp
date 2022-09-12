using System;

namespace _09GreaterOfTwoValues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //09. Greater of Two Values
            //You are given an input of two values of the same type.
            //The values can be of type int, char or string. Create methods called GetMax(),
            //which can compare int, char or string and returns the biggest of the two values.

            string type = Console.ReadLine();

            string a = Console.ReadLine();
            string b = Console.ReadLine();

            if (type == "string")
            {
                Console.WriteLine(GetMaxString(a,b));
            }
            else if (type == "int")
            {
                Console.WriteLine(GetMaxInt(int.Parse(a), int.Parse(b)));
            }
            else if (type == "char")
            {
                Console.WriteLine(GetMaxChar(char.Parse(a), char.Parse(b)));
            }

            static int GetMaxInt(int a, int b)
            {
                if (a < b) return b;
                else return a; 
            }

            static char GetMaxChar(char a, char b)
            {
                if (a < b) return b;
                else return a;
            }

            static string GetMaxString(string a, string b)
            {
                if (a.CompareTo(b) > 0) return a;
                else return b;
            }
        }
    }
}
