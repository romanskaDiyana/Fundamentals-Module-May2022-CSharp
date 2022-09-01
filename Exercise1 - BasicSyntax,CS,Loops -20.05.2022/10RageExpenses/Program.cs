using System;

namespace _10RageExpenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //10. Rage Expenses
            ////As a MOBA challenger player, Petar has the bad habit to trash his PC when he loses a game and rage quits. His gaming setup consists of a headset, mouse, keyboard, and display. You will receive Petar's lost games count. 
            //Every second lost game, Petar trashes his headset.
            //    Every third lost game, Petar trashes his mouse.
            //    When Petar trashes both his mouse and headset in the same lost game, he also trashes his keyboard.
            //    Every second time, when he trashes his keyboard, he also trashes his display.
            //    You will receive the price of each item in his gaming setup.Calculate his rage expenses for renewing his gaming equipment.
            //        Input / Constraints
            //    • On the first input line - lost games count – integer in the range[0, 1000].
            //    • On the second line – headset price - the floating - point number in the range[0, 1000].
            //    • On the third line – mouse price - the floating - point number in the range[0, 1000].
            //    • On the fourth line – keyboard price - the floating - point number in the range[0, 1000].
            //    • On the fifth line – display price - the floating - point number in the range[0, 1000].
            //    Output
            //    • As output you must print Petar's total expenses: "Rage expenses: {expenses} lv."
            //    • Allowed working time / memory: 100ms / 16MB.


            int lostGamesCount = int.Parse(Console.ReadLine());

            double headSetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());
            int trashedHeadset = 0;
            int trashedMouse = 0;
            int trashedKeyboard = 0;
            int trashedDisplay = 0;
            double totalPrice = 0;

            for (int i = 1; i <= lostGamesCount; i++)
            {
                if (i % 3 == 0 && i % 2 == 0)
                {
                    trashedKeyboard++;
                    totalPrice += keyboardPrice;
                    if (trashedKeyboard % 2 == 0)
                    {
                        trashedDisplay++;
                        totalPrice += displayPrice;
                    }
                }
                if (i % 2 == 0)
                {
                    trashedHeadset++;
                    totalPrice += headSetPrice;
                }
                if (i % 3 == 0)
                {
                    trashedMouse++;
                    totalPrice += mousePrice;
                }
            }

            Console.WriteLine($"Rage expenses: {totalPrice:f2} lv.");
        }
    }
}
