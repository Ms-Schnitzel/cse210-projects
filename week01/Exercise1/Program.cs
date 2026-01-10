using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the Exercise1 Project.");
        Console.Write("What is your first name?  ");
        string firstname;
        firstname = Console.ReadLine();
        // Console.WriteLine($"{firstname}");
        Console.Write("What is your last name?  ");
        string lastname;
        lastname = Console.ReadLine();
        // Console.WriteLine($"{lastname}");
        Console.WriteLine($"Your name is {lastname}, {firstname} {lastname}");
    }
}