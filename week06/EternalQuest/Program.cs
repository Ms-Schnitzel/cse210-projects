// The extra feature that I have added is a menu option to allow the user to extend a checklist goal by times to complete and bonus amount to raise.  It will check the list of goals for checklist goal types, and then the user will input the extras they would like to add and update the object.

using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the EternalQuest Project.");
        // create new goal  -  choose type of goal, questions to set parameters, has a checkbox [ ] to represent not completed
        // list goals
        // save goals
        // load goals
        // record event
        // quit

        GoalManager program = new GoalManager();
        // testGoal.CreateGoal();
        // testGoal.LoadGoals();
        program.Start();
    }
}