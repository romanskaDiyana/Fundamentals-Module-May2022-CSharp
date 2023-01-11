using System;
using System.Text;

namespace _05MultiplyBigNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //05.Multiply Big Number
            //You are given two lines – the first one can be a really big number (0 to 1050). The second one will be a single-digit number (0 to 9). Your task is to display the product of these numbers.

            string bigNumber = Console.ReadLine();
            int multiplier = int.Parse(Console.ReadLine());


            StringBuilder stringFinalProduct = new StringBuilder();
            int reminder = 0;

            if (bigNumber == "0" || multiplier == 0)
            {
                Console.WriteLine("0");
                return;
            }

            for (int i = bigNumber.Length -1; i >= 0; i--)
            {
                int currentDigit = int.Parse(bigNumber[i].ToString());
                int product = currentDigit * multiplier + reminder;

                int result = product % 10;
                reminder = product / 10;

                stringFinalProduct.Insert(0,result);             
            }

            if (reminder > 0)
            {
                stringFinalProduct.Insert(0,reminder);
            }

            Console.WriteLine(stringFinalProduct);
        }
    }
}
