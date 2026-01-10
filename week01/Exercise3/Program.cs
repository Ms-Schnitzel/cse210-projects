using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the Exercise3 Project.");
        Console.Write("What is the magic number?  ");
        Random randomGenerator = new Random();
        int magic = randomGenerator.Next(1, 101);
        int count = 0;
        string again = "yes";

        int guess;
        do
        {
            string guessStr = Console.ReadLine();
            guess = int.Parse(guessStr);



            if (guess == magic)
            {
                Console.WriteLine("Congratulations!  You've guessed the magic number!");
                Console.WriteLine($"You guessed the number with only {count} guesses!");
                Console.Write("Do you want to play again? (yes/no)  ");
                again = Console.ReadLine();
                magic = randomGenerator.Next(1, 101);
                count = 0;
                Console.Write("What is the magic number?  ");
            }
            else if (guess > magic)
            {
                Console.WriteLine("Good guess, but you are too high.");
                count += 1;
            }
            else if (guess < magic)
            {
                Console.WriteLine("Good guess, but you are too low.");
                count += 1;
            }
        } while ((guess != magic) && (again == "yes"));
    }
}