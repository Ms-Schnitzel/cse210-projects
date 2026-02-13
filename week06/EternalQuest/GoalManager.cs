using System.IO;

public class GoalManager
{
  private List<Goal> _goals;
  private int _points;
  private string _filename;


  public GoalManager()
  {
    _goals = new List<Goal>();
    _points = 0;
    _filename = "goals.csv";
  }


  public void Start()
  {
    string choice = "";
    do
    {
      DisplayPlayerInfo();
      Console.WriteLine("Menu Options:\n  1. Create New Goal\n  2. List Goals\n  3. Save Goals\n  4. Load Goals\n  5. Record Event\n  6. Extend Goal\n  7. Quit");
      choice = Console.ReadLine();
      Console.WriteLine("\n\n");
      if (choice == "1")
      {
        CreateGoal();
        choice = "";
      }
      else if (choice == "2")
      {
        ListGoalDetails();
        choice = "";
      }
      else if (choice == "3")
      {
        if (_goals.Count == 0)
        {
          Console.WriteLine("I'm sorry, but you don't have any goals to save.");
        }
        else
        {
          SaveGoals();
          Console.WriteLine("Your goals have been saved!");
        }
        choice = "";
      }
      else if (choice == "4")
      {
        LoadGoals();
        Console.WriteLine("Your goals have been loaded!");
        choice = "";
      }
      else if (choice == "5")
      {
        Console.WriteLine("Which goal would you like to record an event for?");
        ListGoalNames(_goals);
        int goalPick = int.Parse(Console.ReadLine());
        RecordEvent(goalPick);
        choice = "";
      }
      else if (choice == "6")
      {
        List<Goal> checklistGoals = new List<Goal>();
        foreach (Goal goal in _goals)
        {
          if (goal.GetType() == typeof(ChecklistGoal))
          checklistGoals.Add(goal);
        }
        Console.WriteLine("Which goal would you like to extend?");
        ListGoalNames(checklistGoals);
        int goalPick = int.Parse(Console.ReadLine());
        ExtendChecklist(checklistGoals[goalPick - 1]);
        choice = "";
      }
      else if (choice == "7")
      {
        return;
      }
      Console.WriteLine();
    } while (choice != "1" && choice != "2" && choice != "3" && choice != "4" && choice != "5" && choice != "6" && choice != "7");
  }

  public void DisplayPlayerInfo()
  {
    Console.WriteLine($"\nYour score is currently {_points}.\n");
  }

  public void ListGoalNames(List<Goal> goals)
  {
    int i = 1;
    foreach (Goal goal in goals)
    {
      Console.WriteLine($"{i}. {goal.GetNameString()}");
      i++;
    }
  }

  public void ListGoalDetails()
  {
    int i = 1;
    foreach(Goal goal in _goals)
    {
      Console.WriteLine($"{i}. {goal.GetDetailString()}");
      i++;
    }
  }

  public void CreateGoal()
  {
    string type = "";
    Console.WriteLine("What type of goal will you be starting?\n1. - Simple Goal\n2. - Checklist Goal\n3. - Eternal Goal");
    do
    {
      type = Console.ReadLine();
      if (type == "1")
      {
        Console.WriteLine("Simple Goal");
      }
      else if (type == "2")
      {
        Console.WriteLine("Checklist Goal");
      }
      else if (type == "3")
      {
        Console.WriteLine("Eternal Goal");
      }
      else
      {
        Console.WriteLine("I'm sorry, please choose a valid goal type.");
      }
    } while (type != "1" && type != "2" && type != "3");
    Console.Write("What is the name of your goal?  ");
    string name = Console.ReadLine();
    Console.Write("Give a short description of your goal:  ");
    string description = Console.ReadLine();
    Console.Write("How many points will this goal be worth?  ");
    int points = int.Parse(Console.ReadLine());
    if (type == "1")
    {
      SimpleGoal newSimple = new SimpleGoal(name, description, points);
      _goals.Add(newSimple);
    }
    else if (type == "2")
    {
      Console.Write("How many times will this goal need to be accomplished for a bonus?  ");
      int countGoal = int.Parse(Console.ReadLine());
      Console.Write("How many points will the bonus be worth?  ");
      int bonus = int.Parse(Console.ReadLine());
      ChecklistGoal newChecklist = new ChecklistGoal(name, description, points, countGoal, bonus);
      _goals.Add(newChecklist);
    }
    else if (type == "3")
    {
      EternalGoal newEternal = new EternalGoal(name, description, points);
      _goals.Add(newEternal);
    }
  }

  public void RecordEvent(int index)
  {
    _points += _goals[index - 1].RecordEvent();
    // Console.WriteLine(_goals[index - 1].GetNameString());
  }

  public void SaveGoals()
  {
    using (StreamWriter outputFile = new StreamWriter(_filename, false))
    {
      foreach (Goal goal in _goals)
      {
       outputFile.WriteLine(goal.GetStringRep()); 
      }
    }
  }

  public void LoadGoals()
  {
    _goals.Clear();
    _points = 0;
    string[] lines = File.ReadAllLines(_filename);
    foreach (string line in lines)
    {
      string[] typeSplit = line.Split(":");
      string type = typeSplit[0];

      string[] parts = typeSplit[1].Split(",");
      string name = parts[0];
      string description = parts[1];
      int points = int.Parse(parts[2]);
      if (type == "Simple")
      {
        bool status = bool.Parse(parts[3]);
        SimpleGoal newSimple = new SimpleGoal(name, description, points);
        if (status == true)
        {
          newSimple.RecordEvent();
          _points += points;
        }
        _goals.Add(newSimple);
      }
      else if (type == "Checklist")
      {
        int countGoal = int.Parse(parts[3]);
        int bonus = int.Parse(parts[4]);
        int count = int.Parse(parts[5]);
        ChecklistGoal newChecklist = new ChecklistGoal(name, description, points, countGoal, bonus);
        for (int i = 0; i < count; i++)
        {
          newChecklist.RecordEvent();
        }
        _goals.Add(newChecklist);
        _points += (points * count);
        if (newChecklist.IsComplete())
        {
          _points += bonus;
        }
      }
      else if (type == "Eternal")
      {
        int count = int.Parse(parts[3]);
        EternalGoal newEternal = new EternalGoal(name, description, points);
        for (int i = 0; i < count; i++)
        {
          newEternal.RecordEvent();
        }
        _goals.Add(newEternal);
        _points += (points * count);
      }
    }
    // Console.WriteLine(_goals[0].DisplayDetails());
  }

  public void ExtendChecklist(Goal goal)
  {
    Console.WriteLine("How much do you want to extend this goal by?");
    int extraCount = int.Parse(Console.ReadLine());
    Console.WriteLine("How much do you want to increase the bonus by?");
    int extraBonus = int.Parse(Console.ReadLine());
    goal.ExtendGoal(extraCount, extraBonus);
  }
}