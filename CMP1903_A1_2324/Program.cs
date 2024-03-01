using System;

namespace CMP1903_A1_2324 {
  internal class Program {
    /// <summary>
    /// Main method which runs when the program runs.
    /// </summary>
    static void Main(string[] args) {
      Testing newTest = new Testing(); // Instantiates a new Testing object.
      newTest.StartTests(); // Calls the StartTests() method to run tests on the other classes and assert error messages if any discrepancies are found.
      do {
        Game newGame = new Game(); // Instantiates a new Game object.
        Console.WriteLine(newGame.RollDice()); // Outputs the values of the dice and their total to the console.
      }
      while (Console.ReadLine() == "") ; // Halts execution until the user presses [Enter]. If the user inputs nothing, the game repeats, else it terminates the program.
    }
  }
}