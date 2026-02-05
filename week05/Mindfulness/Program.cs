// The extra creativity that I have included in my program today is that of an overall counter that keeps track of how long the user has spent in mindfulness activities in this session.  It uses the method setWellness() to add value to the counter variable and display it after each activity.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");
        BreathActivity breath = new BreathActivity("Breathing", "This activity will aid you in relaxing by walking through rhythmic breathing with you.  Clear your mind and focus on your breathing.");

        ReflectActivity reflect = new ReflectActivity("Reflecting", "This activity is to help you reflect on times in your life where you have shown strength and resilience so you can better recognize the power you have and how you can apply it in other aspects of your life.");

        ListActivity list = new ListActivity("Listing", "This activity is to help you realize the good in your life by reflecting on and listing as many answers as you can to the prompt");

        string answer = "";
        int time = 0;
        do
        {
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");
            answer = Console.ReadLine();
            if (answer == "1")
            {
                breath.Run();
                time += breath.setWellness();
                Console.WriteLine($"Your total time spent being mindful today is {time} seconds!\n");
            }
            else if (answer == "2")
            {
                reflect.Run();
                time += reflect.setWellness();
                Console.WriteLine($"Your total time spent being mindful today is {time} seconds!\n");
            }
            else if (answer == "3")
            {
                list.Run();
                time += list.setWellness();
                Console.WriteLine($"Your total time spent being mindful today is {time} seconds!\n");
            }
            else if (answer == "4")
            {
                return;
            }
        } while (answer != "4");
    }
}