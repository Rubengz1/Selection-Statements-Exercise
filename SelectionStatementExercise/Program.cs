namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var favNumber = 23;
            
            Console.WriteLine("Try to guess my favorite number, 1 through 100");
            var userGuess = int.Parse(Console.ReadLine());

            if(userGuess < favNumber)
            {
                Console.WriteLine("Too Low!");
            }
            else if (userGuess > favNumber)
            {
                Console.WriteLine("Too high.");
            }
            else
            {
                Console.WriteLine("You guessed it!!!");
            }
        }
    }
}
