using System;
using System.Text;

namespace _07StringExplosion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //07.String Explosion
            //Explosions are marked with '>'. Immediately after the mark, there will be an integer, which signifies the strength of the explosion.
            //            You should remove x characters(where x is the strength of the explosion), starting after the punched character('>').
            //If you find another explosion mark('>') while you're deleting characters, you should add the strength to your previous explosion.
            //When all characters are processed, print the string without the deleted characters.
            //You should not delete the explosion character – '>', but you should delete the integers, which represent the strength.
            //Input
            //You will receive a single line with the string.
            //Output
            //Print what is left from the string after the explosions.
            //Constraints
            //    • You will always receive strength for the punches.
            //    • The path will consist only of letters from the Latin alphabet, integers and the char '>'.
            //    • The strength of the punches will be in the interval[0…9].

            string stringField = Console.ReadLine();

            StringBuilder stringBuilderField = new StringBuilder();
            stringBuilderField.AppendLine(stringField);

            int remainingPower = 0;

            for (int i = 0; i < stringBuilderField.Length; i++)
            {
                if (stringBuilderField[i] == '>')
                {
                    int strength = int.Parse(stringBuilderField[i + 1].ToString()) + remainingPower;

                    for (int j = 0; j < strength; j++)
                    {
                        if (i + 1 >= stringBuilderField.Length) break;;

                        if (stringBuilderField[i + 1] == '>')
                        {
                            remainingPower += strength - j;
                            break;
                        }
                        stringBuilderField.Remove(i + 1, 1);
                        remainingPower = 0;
                    }
                }
            }
            Console.WriteLine(stringBuilderField);
        }
    }
}
