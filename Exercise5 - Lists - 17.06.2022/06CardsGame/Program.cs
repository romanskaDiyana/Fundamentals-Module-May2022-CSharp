using System;
using System.Linq;

namespace _06CardsGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //06. Cards Game
            //You will be given two hands of cards, which will be represented by integers.
            //Assume each one is held by a different player. You have to find which one has
            //the winning deck. You start from the beginning of both hands of cards.
            //Compare the cards from the first deck to the cards from the second deck.
            //The player, who holds the more powerful card on the current iteration,
            //takes both cards and puts them at the back of his hand -
            //the second player's card is placed last and the first person's
            //card (the winning one) comes after it (second to last).
            //If both players' cards have the same values - no one wins and the
            //two cards must be removed from both hands. The game is over only
            //when one of the decks is left without any cards. You have to display
            //the result on the console and the sum of the remaining cards:
            //"{First/Second} player wins! Sum: {sum}".


            var firstPlayer = Console.ReadLine().Split().Select(int.Parse).ToList();
            var secondPlayer = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (firstPlayer.Count > 0 && secondPlayer.Count > 0)
            {
                if (firstPlayer[0] > secondPlayer[0])
                {
                    firstPlayer.Add(firstPlayer[0]);
                    firstPlayer.Add(secondPlayer[0]);
                }
                else if (firstPlayer[0] < secondPlayer[0])
                {
                    secondPlayer.Add(secondPlayer[0]);
                    secondPlayer.Add(firstPlayer[0]);
                }

                firstPlayer.Remove(firstPlayer[0]);
                secondPlayer.Remove(secondPlayer[0]);

                if (firstPlayer.Count == 0)
                {
                    int sum = secondPlayer.Sum();
                    Console.WriteLine($"Second player wins! Sum: {sum}");
                    break;
                }
                if (secondPlayer.Count == 0)
                {
                    int sum = firstPlayer.Sum();
                    Console.WriteLine($"First player wins! Sum: {sum}");
                    break;
                }
            }
        }
    }
}
