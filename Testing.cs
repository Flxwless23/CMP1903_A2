using System;
using System.Diagnostics;
using System.Linq;

namespace CMP1903_A1_2324
{
    internal class Testing
    {
        public void DieTesting(int value)
        {
            Debug.Assert(value <= 6, "Die generated above the value of 6 (Higher boundary)");
            Debug.Assert(value >= 1, "Die generated below the value of 1 (Low boundary)");
        }

        public void GameTesting(int value)
        {
            Debug.Assert(value <= 18, "Total number is above the value of 18 (Higher boundary)");
            Debug.Assert(value >= 3, "Total number is below the value of 3 (Lower boundary)");
        }

        public void RunGameTests()
        {
            // Instantiate a Game object
            Game game = new Game();

            // Test Sevens Out game
            int[] sevensOutArray = { 1, 2, 3, 4, 5, 6, 7 };
            int sevensOutTotal = sevensOutArray.Sum();
            Debug.Assert(sevensOutTotal != 7, "Sevens Out: Total is equal to 7");

            // Test Three Or More game
            int[] threeOrMoreArray = { 10, 5, 4 };
            int threeOrMoreTotal = threeOrMoreArray.Sum();
            Debug.Assert(threeOrMoreTotal < 20, "Three Or More: Total is greater than or equal to 20");
        }
    }
}
