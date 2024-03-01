using System.Diagnostics;

namespace CMP1903_A1_2324
{
    internal class Testing
    {
        public void StartTests() // Public method to instantiate a Game object and test all of its outputs.
        {
            Game NewGame = new Game(); // Instantiates the Game object.
            for (int Index = 0; Index < 100; Index++) // Starts a loop that runs 100 times to ensure tests are sufficient.
            {
                (int, int, int, int) GameValues = NewGame.RollDice(); // Declares an int tuple to store the results from the rolls, and gets the values for it from a call to the RollDice() method.
                (bool, bool, bool, bool) Checks = CheckAllValues(GameValues); // Declares a bool tuple to store the results from the checks, and gets those results from the CheckAllValues() method. GameValues is passed as an argument.

                // Calls Debug.Assert() with each of the Checks values, and outputs error messages if any of them are false.
                Debug.Assert(Checks.Item1, $"Error: the first dice roll returned a value of {GameValues.Item1}!");
                Debug.Assert(Checks.Item2, $"Error: the second dice roll returned a value of {GameValues.Item2}!");
                Debug.Assert(Checks.Item3, $"Error: the third dice roll returned a value of {GameValues.Item3}!");
                Debug.Assert(Checks.Item4, $"Error: the sum of the dice rolls returned a value of {GameValues.Item4}!");

                // Outputs error message if any checks failed.
                if (!Checks.Item1 || !Checks.Item2 || !Checks.Item3 || !Checks.Item4)
                { Debug.WriteLine($"Testing iteration {Index} found errors. See above error messages.\n"); }
            }
        }
        public bool CheckRollValue(int RollValue) // Boolean method that checks if the value from a dice roll is within the expected bounds.
        {
            if (RollValue < 1 || RollValue > 6) return false; // Returns false if the value is higher than six or lower than one.
            else return true; // Returns true if the value is between six and one.
        }
        public bool CheckTotalValue((int, int, int, int) GameValues) // Boolean method that checks if the sum of three dice rolls is within the expected bounds and that the total is correct based on the values of the three rolls.
        {
            if (GameValues.Item1 + GameValues.Item2 + GameValues.Item3 != GameValues.Item4 || GameValues.Item4 < 3 || GameValues.Item4 > 18) return false; // Returns false if the value is higher than eighteen or lower than three or if the provided total is not the same as the sum of the three values.
            else return true; // Returns true if the value is within the expected bounds and is the product of the three roll values.
        }
        public (bool, bool, bool, bool) CheckAllValues((int, int, int, int) GameValues) // Method that checks each roll value and the total by calling different methods and returns a tuple of bools with the results.
        {
            // Instantiates local variables and assigns the returned values from the tests for each rolled value.
            bool FirstRoll = CheckRollValue(GameValues.Item1);
            bool SecondRoll = CheckRollValue(GameValues.Item2);
            bool ThirdRoll = CheckRollValue(GameValues.Item3);

            // Instantiates a local variable and assigns the returned values from the test for the sum of the roll values.
            bool Game = CheckTotalValue(GameValues);

            return (FirstRoll, SecondRoll, ThirdRoll, Game); // Returns all the local variables in a tuple.
        }
    }
}
