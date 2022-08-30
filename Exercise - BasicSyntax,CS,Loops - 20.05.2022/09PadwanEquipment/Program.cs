using System;
using System.Diagnostics.CodeAnalysis;

namespace _09PadwanEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //09. Padawan Equipment
            //Yoda is starting his newly created Jedi academy. So, he asked master John to buy the needed equipment. The number of items depends on how many students will sign up. The equipment for each Padawan contains:
            //• Lightsaber
            //    • Belt
            //    • Robe
            //    You will be given the amount of money John has, the number of students, and the prices of each item.Calculate does John has enough money to buy equipment for each Padawan, or how much more money he needs.
            //    There are some additional requirements: 
            //    • Lightsabres sometimes break, so John should buy 10 % more(taken from the student's count), rounded up to the next integer
            //    • Every sixth belt is free
            //    Input / Constraints
            //The input data should be read from the console.It will consist of exactly 5 lines:
            //    • The amount of money John has – the floating - point number in the range[0.00…1, 000.00]
            //    • The count of students – integer in the range[0…100]
            //    • The price of lightsabers for a single saber – the floating - point number in the range[0.00…100.00]
            //    • The price of robes for a single robe – the floating - point number in the range[0.00…100.00]
            //    • The price of belts for a single belt – the floating - point number in the range[0.00…100.00]
            //The input data will always be valid.There is no need to check it explicitly.
            //    Output
            //    The output should be printed on the console.
            //    • If the calculated price of the equipment is less or equal to the money John has:
            //    ◦ "The money is enough - it would cost {the cost of the equipment}lv."
            //    • If the calculated price of the equipment is more than the money John has:
            //    ◦  " John will need {neededMoney}lv more."
            //    • All prices must be rounded to two digits after the decimal point.

            double amountOfMoney = double.Parse(Console.ReadLine());
            int countOfStudents = int.Parse(Console.ReadLine());
            double singleLightsaberPrice = double.Parse(Console.ReadLine());
            double singleRobePrice = double.Parse(Console.ReadLine());
            double singleBeltPrice = double.Parse(Console.ReadLine());

            double lightsabersPrice = singleLightsaberPrice * (Math.Ceiling(countOfStudents * 0.10) + countOfStudents);
            double robesPrice = countOfStudents * singleRobePrice;

            double freeBeltCount = countOfStudents / 6;
            double beltsPrice = (countOfStudents - freeBeltCount) * singleBeltPrice;


            double totalPrice = lightsabersPrice + robesPrice + beltsPrice;
            if (totalPrice > amountOfMoney) Console.WriteLine($"John will need {totalPrice - amountOfMoney:f2}lv more.");
            else Console.WriteLine($"The money is enough - it would cost {totalPrice:f2}lv.");
        }
    }
}
