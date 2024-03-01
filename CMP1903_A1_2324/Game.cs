namespace CMP1903_A1_2324 {
  internal class Game {
    /// <summary>
    /// Used to instantiate Die and roll them.
    /// </summary>
    public (int, int, int, int) RollDice() { // Public method to instantiate three dice and roll them. Returns the values of the dice and the sum of the values in a tuple.
      // Instantiates a new Die object and declares an int to store the value returned from the call to the Roll() method.
      Die firstDice = new Die();
      int firstValue = firstDice.Roll();
      
      // Instantiates a new Die object and declares an int to store the value returned from the call to the Roll() method.
      Die secondDice = new Die();
      int secondValue = secondDice.Roll();
      
      // Instantiates a new Die object and declares an int to store the value returned from the call to the Roll() method.
      Die thirdDice = new Die();
      int thirdValue = thirdDice.Roll();
      
      int Total = firstValue + secondValue + thirdValue; // Declares a new int to store the sum of the Roll() values added together.
      return (firstValue, secondValue, thirdValue, Total); // Constructs a tuple to return all the int values together.
    }
  }
}