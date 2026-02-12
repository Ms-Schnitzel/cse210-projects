public class ChecklistGoal : Goal
{
  private int _count;
  private int _countGoal;
  private int _bonus;

  public ChecklistGoal(string name, string details, int points, int countGoal, int bonus) : base(name, details, points)
  {
    _countGoal = countGoal;
    _bonus = bonus;
    _count = 0;
  }

  public override void RecordEvent()
  { }

  public override bool IsComplete()
  {
    return false;
  }

  public override string GetDetailString()
  {
    return "";
  }
  
  public override string GetDetailRep()
  {
    return "";
  }
}