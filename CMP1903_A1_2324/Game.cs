namespace CMP1903_A1_2324
{
    internal class Game
    {
        public (int, int, int, int) RollDice() // Public method to instantiate three dice and roll them. Returns the first dice's value, then second, then third, and the sum of the values, all in a tuple.
        {
            // Instantiates a new Die object and declares an int to store the value returned from the call to the Roll() method.
            Die FirstDice = new Die();
            int FirstValue = FirstDice.Roll();

            // Instantiates a new Die object and declares an int to store the value returned from the call to the Roll() method.
            Die SecondDice = new Die();
            int SecondValue = SecondDice.Roll();

            // Instantiates a new Die object and declares an int to store the value returned from the call to the Roll() method.
            Die ThirdDice = new Die();
            int ThirdValue = ThirdDice.Roll();

            int Total = FirstValue + SecondValue + ThirdValue; // Declares a new int to store the sum of the Roll() values added together.
            return (FirstValue, SecondValue, ThirdValue, Total); // Constructs a tuple to return all the int values together.
        }
    }
}
