﻿using System;

namespace CMP1903_A1_2324
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Testing NewTest = new Testing(); // Instantiates a new Testing object.
            NewTest.StartTests(); // Calls the StartTests() method to run tests on the other classes and assert error messages if any discrepancies are found.

            do
            {
                Game NewGame = new Game(); // Instantiates a new Game object.
                Console.WriteLine(NewGame.RollDice()); // Outputs the values of the dice and their total to the console.
            }
            while (Console.ReadLine() == "") ; // Halts execution until the user presses [Enter]. If the user inputs nothing, the game repeats, else it terminates the program.
        }
    }
}
