﻿using System;

namespace _05MonthPrinter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //05. Month Printer
            //Create a program that receives an integer and prints the matching month.
            //If the number is more than 12 or less than 1, print "Error!".
            //You will receive a single integer on a single line.
            //Output
            // If the number is within the boundaries, print the corresponding month,
            // otherwise print "Error!".

            //Solution 2
            //--------------------------------------------------------------------//

            int month = int.Parse(Console.ReadLine());

            MonthPrinter(month);

            static void MonthPrinter(int month)

            {
                switch (month)
                {
                    case 1:
                        Console.WriteLine("January");
                        break;
                    case 2:
                        Console.WriteLine("February");
                        break;
                    case 3:
                        Console.WriteLine("March");
                        break;
                    case 4:
                        Console.WriteLine("April");
                        break;
                    case 5:
                        Console.WriteLine("May");
                        break;
                    case 6:
                        Console.WriteLine("June");
                        break;
                    case 7:
                        Console.WriteLine("July");
                        break;
                    case 8:
                        Console.WriteLine("August");
                        break;
                    case 9:
                        Console.WriteLine("September");
                        break;
                    case 10:
                        Console.WriteLine("October");
                        break;
                    case 11:
                        Console.WriteLine("November");
                        break;
                    case 12:
                        Console.WriteLine("December");
                        break;

                    default:
                        Console.WriteLine("Error!");
                        break;
                }
            }


            //Solution 1
            //--------------------------------------------------------------------//

            //        int month = int.Parse(Console.ReadLine());

            //switch (month)
            //{
            //    case 1: Console.WriteLine("January");
            //        break;
            //    case 2: Console.WriteLine("February");
            //        break;
            //    case 3: Console.WriteLine("March");
            //        break;
            //    case 4: Console.WriteLine("April");
            //        break;
            //    case 5: Console.WriteLine("May");
            //        break;
            //    case 6: Console.WriteLine("June");
            //        break;
            //    case 7: Console.WriteLine("July");
            //        break;
            //    case 8: Console.WriteLine("August");
            //        break;
            //    case 9: Console.WriteLine("September");
            //        break;
            //    case 10: Console.WriteLine("October");
            //        break;
            //    case 11: Console.WriteLine("November");
            //        break;
            //    case 12: Console.WriteLine("December");
            //        break;

            //    default:
            //        Console.WriteLine("Error!");
            //        break;
        }
    }
}
