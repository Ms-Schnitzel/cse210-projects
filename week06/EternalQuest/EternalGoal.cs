public class EternalGoal : Goal
{
  private string _name;
  private string _description;
  private int _points;
  private int _count;

  public EternalGoal(string name, string description, int points) : base(name, description, points)
  {
    _name = name;
    _description = description;
    _points = points;
    _count = 0;
  }

  public override int RecordEvent()
  {
    _count++;
    return _points;
  }

  // public override bool IsComplete()
  // {
  //   return false;
  // }
  
  public override string GetStringRep()
  {
    return $"Eternal:{_name},{_description},{_points},{_count}";
  }
}