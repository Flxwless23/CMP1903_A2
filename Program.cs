using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CMP1903_A1_2324
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Welcome to the Game Menu:");
                Console.WriteLine("1. Play Dice Game");
                Console.WriteLine("2. Instantiate Sevens Out Game");
                Console.WriteLine("3. Instantiate Three Or More Game");
                Console.WriteLine("4. View Statistics Data");
                Console.WriteLine("5. Perform Tests");

                Console.Write("Enter your choice (1-5): ");
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    PlayDiceGame();
                }
                else if (choice == "2")
                {
                    InstantiateSevensOutGame();
                }
                else if (choice == "3")
                {
                    InstantiateThreeOrMoreGame();
                }
                else if (choice == "4")
                {
                    ViewStatisticsData();
                }
                else if (choice == "5")
                {
                    PerformTests();
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                }

                bool validInput = false;
                while (!validInput)
                {
                    Console.WriteLine("Do you want to continue? (y/n)");
                    string continueChoice = Console.ReadLine().ToLower();
                    if (continueChoice == "y")
                    {
                        validInput = true;
                    }
                    else if (continueChoice == "n")
                    {
                        validInput = true;
                        exit = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter 'y' or 'n'.");
                    }
                }
            }
        }

        static void PlayDiceGame()
        {
            Console.WriteLine("Dice Game Section");
            Game game = new Game();
            game.DiceGame();
        }

        static void InstantiateSevensOutGame()
        {
            Console.WriteLine("Sevens Out Game Section");
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            SevensOut.SortAndDisplay(array);
        }

        static void InstantiateThreeOrMoreGame()
        {
            Console.WriteLine("Three Or More Game Section");
            int[] array = { 123, 456, 789, 1000 };
            ThreeOrMore.SortAndDisplay(array);
        }

        static void ViewStatisticsData()
        {
            Console.WriteLine("Statistics Data Section");
            Testing test = new Testing();
            test.DieTesting(6);
            test.GameTesting(18);
        }

        static void PerformTests()
        {
            Console.WriteLine("Perform Tests Section");
            Testing test = new Testing();
            // Call any testing methods here
        }
    }
}
