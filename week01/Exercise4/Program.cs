using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the Exercise4 Project.");
        Console.WriteLine("Enter a list of numbmers, type 0 when finished.");
        string response;
        List<int> numList = new List<int>();
        do
        {
            response = Console.ReadLine();
            int number = int.Parse(response);
            if (number != 0)
            {
                numList.Add(number);
            }

        } while (response != "0");

        float total = 0;
        float average;
        int max = 0;
        numList.Sort();
        int pos = numList[numList.Count - 1];
        foreach (int num in numList)
        {
            // Console.WriteLine(num);
            total += num;
        }
        average = total / numList.Count;
        foreach (int num in numList)
        {
            if (num > max)
            {
                max = num;
            }
        }
        foreach (int num in numList)
        {
            if (num > 0 && num < pos)
            {
                pos = num;
            }
        }

        Console.WriteLine("Your sorted list is: ");
        foreach (int num in numList)
        {
            Console.WriteLine($"{num}  ");
        }
        Console.WriteLine($"Your total is {total}.");
        Console.WriteLine($"Your average is {average}.");
        Console.WriteLine($"Your largest number is {max}.");
        if (pos > 0)
        {
            Console.WriteLine($"Your smallest positive number is {pos}.");
        }
        else
        {
            Console.WriteLine("You didn't have any positive numbers.");
        }
    }
}