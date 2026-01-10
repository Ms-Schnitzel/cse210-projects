using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the Exercise5 Project.");
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }
        static string PromptUserName()
        {
            Console.Write("What is your name?  ");
            string name = Console.ReadLine();
            return name;
        }
        static int PromptUserNumber()
        {
            Console.Write("What is your favorite number?  ");
            // string answer = Console.ReadLine();
            // int num = int.Parse(answer);
            int num = int.Parse(Console.ReadLine());
            return num;
        }
        static int SquareNumber(int toSquare)
        {
            int numSquared = toSquare * toSquare;
            return numSquared;
        }
        static void DisplayResult(string name, int numSquared)
        {
            Console.WriteLine($"{name}, the square of your number is {numSquared}");
        }

        DisplayWelcome();
        string userName = PromptUserName();
        int userNum = PromptUserNumber();
        int userSquare = SquareNumber(userNum);
        DisplayResult(userName, userSquare);
    }
}