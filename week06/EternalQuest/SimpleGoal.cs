public class SimpleGoal : Goal
{
  private bool _status;


  public SimpleGoal(string name, string details, int points) : base(name, details, points)
  {  }

  public override void RecordEvent()
  { }

  public override bool IsComplete()
  {
    return _status;
  }
  
  public override string GetDetailRep()
  {
    return "";
  }
}