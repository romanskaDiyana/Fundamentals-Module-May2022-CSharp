using System;
using System.Collections.Generic;
using System.Linq;

namespace _5.Decrypting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //5. Decrypting Messages
            //You will receive a key (integer) and n characters afterward. Add the key to each of the characters and append them to a message. At the end print the message, which you decrypted. 

            int stepTo = int.Parse(Console.ReadLine());
            int numberOfChars = int.Parse(Console.ReadLine());
            
            List<int> intList = new List<int>();

            for (int i = 0; i < numberOfChars; i++)
            {
                char charRepresentation = char.Parse(Console.ReadLine());
                int intRepresentation = charRepresentation + stepTo;
                
                intList.Add(intRepresentation);
            }

            foreach (int intRepresentation in intList)
            {
                char charRepresentation = Convert.ToChar(intRepresentation);
                
                Console.Write(string.Join(" ", charRepresentation));
            }
        }
    }
}
