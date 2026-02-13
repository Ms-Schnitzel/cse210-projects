public class ChecklistGoal : Goal
{
  private string _name;
  private string _description;
  private int _points;
  private int _count;
  private int _countGoal;
  private int _bonus;

  public ChecklistGoal(string name, string description, int points, int countGoal, int bonus) : base(name, description, points)
  {
    _name = name;
    _description = description;
    _points = points;
    _countGoal = countGoal;
    _bonus = bonus;
    _count = 0;
  }

  public override int RecordEvent()
  {
    _count++;
    int tallyPoints = _points;
    if (IsComplete() == true)
    {
      tallyPoints += _bonus;
    }
    return tallyPoints;
  }

  public override bool IsComplete()
  {
    if (_count == _countGoal)
    {
      return true;
    }
    else
    {
      return false;
    }
  }

  public override string GetDetailString()
  {
    string status = " ";
    if (IsComplete() == true)
    {
      status = "X";
    }
    return $"[{status}] {_name}: {_description}  Times Completed: {_count}/{_countGoal}";
  }

  public override string GetStringRep()
  {
    return $"Checklist:{_name},{_description},{_points},{_countGoal},{_bonus},{_count}";
  }
  
  public override void ExtendGoal(int extraCount, int extraBonus)
  {
    _countGoal += extraCount;
    _bonus += extraBonus;
    Console.WriteLine($"Your bonus has now been extended!");
  }
}