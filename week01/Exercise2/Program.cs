using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the Exercise2 Project.");
        Console.Write("What is your grade percentage?  ");
        string percentStr = Console.ReadLine();
        int percentInt = int.Parse(percentStr);
        string letter;

        if (percentInt >= 90)
        {
            letter = "A";
        }
        else if (percentInt >= 80)
        {
            letter = "B";
        }
        else if (percentInt >= 70)
        {
            letter = "C";
        }
        else if (percentInt >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        if ((percentInt % 10 >= 7) && (percentInt < 90) && (letter != "F"))
        {
            letter += "+";
        }
        else if ((percentInt % 10 < 3) && (letter != "F"))
        {
            letter += "-";
        }

        Console.WriteLine($"You finished this class with a letter grade of {letter}");

        if (percentInt >= 70)
        {
            Console.WriteLine("Congratulations!  You passed the class!");
        }
        else
        {
            Console.WriteLine("Sorry, you did not pass this time, keep trying!");
        }
    }
}