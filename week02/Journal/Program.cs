using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {

        Journal newJournal = new Journal();
        Console.WriteLine("Welcome to the Journal Program!");
        string answer;
        do
        {
            Prompt newPrompt = new Prompt();
            Entry newEntry = new Entry();
            Console.WriteLine("Please select one of the followig choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do?  ");
            answer = Console.ReadLine();

            if (answer == "1")
            {
                
                string writingPrompt = newPrompt.GetPrompt();
                Console.WriteLine(writingPrompt);
                string userText = Console.ReadLine();

                
                newEntry._date = DateTime.Today.ToString("d");
                newEntry._prompt = writingPrompt;
                newEntry._entry = userText;

                
                // newEntry.Display();
                newJournal.AddEntry(newEntry);
            }
            if (answer == "2")
            {
                newJournal.Display();
            }
            if (answer == "3")
            {
                newJournal.Load("journalEntries.csv");
            }
            if (answer == "4")
            {
                newJournal.Save("journalEntries.csv");
            }

            // Console.WriteLine(answer);

        } while (answer != "5");
    }
}






