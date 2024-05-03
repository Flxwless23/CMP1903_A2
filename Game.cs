using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Game
    {

        public void DiceGame()
        {
            Die dieOne = new Die();
            int dieOneValue = dieOne.Roll();

            Die dieTwo = new Die();
            int dieTwoValue = dieTwo.Roll();

            Die dieThree = new Die();
            int dieThreeValue = dieThree.Roll();

            Console.WriteLine($"The roll of Die 1 is: {dieOneValue}");
            Console.WriteLine($"The roll of Die 2 is: {dieTwoValue}");
            Console.WriteLine($"The roll of Die 3 is: {dieThreeValue}");

            int total = dieOneValue + dieTwoValue + dieThreeValue;
            Console.WriteLine($"The total sum of the three rolled dice is: {total}");
            Console.ReadLine();
        }

        /*
         * The Game class should create three die objects, roll them, sum and report the total of the three dice rolls.
         *
         * EXTRA: For extra requirements (these aren't required though), the dice rolls could be managed so that the
         * rolls could be continuous, and the totals and other statistics could be summarized for example.
         */

        //Methods

    }

    // SevensOut class
    class SevensOut
    {
        public static void SortAndDisplay(int[] array)
        {
            Console.WriteLine("Playing Sevens Out Game...");

            Random random = new Random();
            int total = 0;
            int rollCount = 0;

            do
            {
                int diceOne = random.Next(1, 7);
                int diceTwo = random.Next(1, 7);
                int rollTotal = diceOne + diceTwo;
                rollCount++;

                if (rollTotal == 7)
                {
                    Console.WriteLine($"You rolled {diceOne} and {diceTwo}, total is 7. Game Over!");
                    break;
                }
                else
                {
                    total += rollTotal;
                    if (diceOne == diceTwo)
                    {
                        Console.WriteLine($"You rolled double {diceOne}, doubling the total.");
                        total *= 2;
                    }
                    else
                    {
                        Console.WriteLine($"You rolled {diceOne} and {diceTwo}, total is {total}.");
                    }
                }
            } while (true);

            Console.WriteLine($"Total rolls: {rollCount}, Total score: {total}");
        }
    }

    // ThreeOrMore class
    class ThreeOrMore
    {
        public static void SortAndDisplay(int[] array)
        {
            Console.WriteLine("Playing Three Or More Game...");

            Random random = new Random();
            int total = 0;
            int rollCount = 0;

            do
            {
                int[] diceRolls = new int[5];
                for (int i = 0; i < diceRolls.Length; i++)
                {
                    diceRolls[i] = random.Next(1, 7);
                }
                rollCount++;

                Array.Sort(diceRolls);

                if (diceRolls[0] == diceRolls[4])
                {
                    total += 12;
                    Console.WriteLine($"You rolled five of a kind: {diceRolls[0]} - scoring 12 points.");
                    break;
                }
                else if (diceRolls[0] == diceRolls[3] || diceRolls[1] == diceRolls[4])
                {
                    total += 6;
                    Console.WriteLine($"You rolled four of a kind: {diceRolls[1]} - scoring 6 points.");
                }
                else if (diceRolls[0] == diceRolls[2] || diceRolls[1] == diceRolls[3] || diceRolls[2] == diceRolls[4])
                {
                    total += 3;
                    Console.WriteLine($"You rolled three of a kind: {diceRolls[2]} - scoring 3 points.");
                }

                Console.WriteLine($"Dice rolls: {string.Join(", ", diceRolls)}");
                Console.WriteLine($"Total score: {total}");
                Console.WriteLine();
            } while (total < 20);

            Console.WriteLine($"Total rolls: {rollCount}, Total score: {total}");
        }
    }
}