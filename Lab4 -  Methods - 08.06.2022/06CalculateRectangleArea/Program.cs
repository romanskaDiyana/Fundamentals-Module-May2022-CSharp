using System;

namespace _06CalculateRectangleArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //06. Calculate Rectangle Area 
            //Create a method that calculates and returns the area of a rectangle. 


            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            Console.WriteLine(CalculateArea(width,height));

            static int CalculateArea(int width, int height) 
            {
                return width * height;
            }

            
        }
    }
}
