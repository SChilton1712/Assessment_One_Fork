using System.Diagnostics;

namespace CMP1903_A1_2324 {
  internal class Testing {
    /// <summary>
    /// Testing class which instantiates other classes and tests them.
    /// </summary>
    
    public Testing() { // Public constructor that runs when the class is instantiated as an object.
      // Runs the tests from a separate method.
      StartTests();
    }
    public void StartTests() { // Public method to instantiate a Game object and test all of its outputs.
      Game newGame = new Game(); // Instantiates the Game object.
      for (int index = 0; index < 100; index++) { // Starts a loop that runs 100 times to ensure tests are sufficient.
        (int, int, int, int) gameValues = newGame.RollDice(); // Declares an int tuple to store the results from the rolls, and gets the values for it from a call to the RollDice() method.
        (bool, bool, bool, bool) checks = CheckAllValues(gameValues); // Declares a bool tuple to store the results from the checks, and gets those results from the CheckAllValues() method. GameValues is passed as an argument.
        
        // Calls Debug.Assert() with each of the Checks values, and outputs error messages if any of them are false.
        Debug.Assert(checks.Item1, $"Error: the first dice roll returned a value of {gameValues.Item1}!");
        Debug.Assert(checks.Item2, $"Error: the second dice roll returned a value of {gameValues.Item2}!");
        Debug.Assert(checks.Item3, $"Error: the third dice roll returned a value of {gameValues.Item3}!");
        Debug.Assert(checks.Item4, $"Error: the sum of the dice rolls returned a value of {gameValues.Item4}!");

        // Outputs error message if any checks failed.
        if (!checks.Item1 || !checks.Item2 || !checks.Item3 || !checks.Item4)
        { Debug.WriteLine($"Testing iteration {index} found errors. See above error messages.\n"); }
      }
    }
    public bool CheckRollValue(int rollValue) { // Boolean method that checks if the value from a dice roll is within the expected bounds.
      if (rollValue < 1 || rollValue > 6) { return false; } // Returns false if the value is higher than six or lower than one.
      else { return true; } // Returns true if the value is between six and one.
    }
    public bool CheckTotalValue((int, int, int, int) gameValues) { // Boolean method that checks if the sum of three dice rolls is within the expected bounds and that the total is correct based on the values of the three rolls.
      if (gameValues.Item1 + gameValues.Item2 + gameValues.Item3 != gameValues.Item4 || gameValues.Item4 < 3 || gameValues.Item4 > 18) { return false; } // Returns false if the value is higher than eighteen or lower than three or if the provided total is not the same as the sum of the three values.
      else { return true; } // Returns true if the value is within the expected bounds and is the product of the three roll values.
    }
    public (bool, bool, bool, bool) CheckAllValues((int, int, int, int) gameValues) { // Method that checks each roll value and the total by calling different methods and returns a tuple of bools with the results.
      // Instantiates local variables and assigns the returned values from the tests for each rolled value.
      bool firstRoll = CheckRollValue(gameValues.Item1);
      bool secondRoll = CheckRollValue(gameValues.Item2);
      bool thirdRoll = CheckRollValue(gameValues.Item3);
      
      // Instantiates a local variable and assigns the returned values from the test for the sum of the roll values.
      bool game = CheckTotalValue(gameValues);
      
      return (firstRoll, secondRoll, thirdRoll, game); // Returns all the local variables in a tuple.
    }
  }
}
