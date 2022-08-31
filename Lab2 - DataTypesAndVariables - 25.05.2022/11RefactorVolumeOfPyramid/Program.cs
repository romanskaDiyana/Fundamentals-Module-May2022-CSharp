using System;

namespace _11RefactorVolumeOfPyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //11. Refactor Volume of Pyramid
            //You are given a working code that finds the volume of a pyramid.
            //However, you should consider that the variables exceed their optimum span and have improper naming. Also, search for variables that have multiple purposes.
            //     Hints
            //    • Reduce the span of the variables by declaring
            //    them at the moment they receive a value, not before
            //    • Rename your variables to represent their real
            //    purpose(example: "dul" should become length, etc.)
            //    • Search for variables that have multiple purposes.
            //    If you find any, introduce a new variable.

            Console.Write("Length: ");
            double lenght = double.Parse(Console.ReadLine());

            Console.Write("Width: ");
            double width = double.Parse(Console.ReadLine());

            Console.Write("Height: ");
            double height = double.Parse(Console.ReadLine());


            double volume = (lenght * width * height) / 3;

            Console.WriteLine($"Pyramid Volume: {volume:f2}");
        }
    }
}
