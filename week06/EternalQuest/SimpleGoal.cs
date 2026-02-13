public class SimpleGoal : Goal
{
  private string _name;
  private string _description;
  private int _points;
  private bool _status;


  public SimpleGoal(string name, string description, int points) : base(name, description, points)
  {
    _name = name;
    _description = description;
    _points = points;
    _status = false;
  }

  public override int RecordEvent()
  {
    _status = true;
    return _points;
  }

  public override bool IsComplete()
  {
    return _status;
  }
  
  public override string GetStringRep()
  {
    return $"Simple:{_name},{_description},{_points},{_status.ToString()}";
  }
}