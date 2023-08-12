using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terningen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Loops forever until program closes
            while(true)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Press any key to roll a dice");
                Console.ReadKey(true);

                Console.Clear();
                // Rolls the dice
                RollDice();
            }
        }

        /// <summary>
        /// Rolls a 6 sided dice
        /// </summary>
        static void RollDice()
        {
            // Rolls a random number between 1 and 6
            Random rand = new Random();
            ushort dice = (ushort)rand.Next(1, 7);

            // Text output
            Console.ForegroundColor = GetColor(dice);
            Console.WriteLine("You rolled " + TranslateEyes(dice) + "\n");
        }

        /// <summary>
        /// Gets the fitting color for <paramref name="eyesAmount"/>
        /// </summary>
        /// <param name="eyesAmount">the amount of eyes the dice rolled</param>
        /// <returns>The fitting color to <paramref name="eyesAmount"/></returns>
        static ConsoleColor GetColor(ushort eyesAmount)
        {
            ConsoleColor[] arr = new ConsoleColor[] { ConsoleColor.Red, ConsoleColor.DarkMagenta, ConsoleColor.Cyan, ConsoleColor.Blue, ConsoleColor.Yellow, ConsoleColor.Green };
            // Subtracting 1 so that it returns the right color from the array
            return arr[eyesAmount - 1];
        }

        /// <summary>
        /// Translates <paramref name="eyesAmount"/> to a fitting string
        /// </summary>
        /// <param name="eyesAmount">the amount of eyes the dice rolled</param>
        /// <returns>The fitting string to <paramref name="eyesAmount"/></returns>
        static string TranslateEyes(ushort eyesAmount)
        {
            string[] array = new string[] { "one eye", "two eyes", "three eyes", "four eyes", "five eyes", "six eyes"};
            // Subtracting 1 so that it returns the right string from the array
            return array[eyesAmount- 1];
        }
    }
}
