public class EternalGoal : Goal
{

  public EternalGoal(string name, string details, int points) : base(name, details, points)
  {}

  public override void RecordEvent()
  { }

  public override bool IsComplete()
  {
    return false;
  }
  
  public override string GetDetailRep()
  {
    return "";
  }
}