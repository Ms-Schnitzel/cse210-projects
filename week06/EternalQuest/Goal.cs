public abstract class Goal
{
  private string _name;
  private string _description;
  private int _points;

  public Goal(string name, string description, int points)
  {
    _name = name;
    _description = description;
    _points = points;
  }




  public virtual int RecordEvent()
  {
    return _points;
  }

  public virtual bool IsComplete()
  {
    return false;
  }

  public string GetNameString()
  {
    return _name;
  }

  public virtual string GetDetailString()
  {
    string status = " ";
    if (IsComplete() == true)
    {
      status = "X";
    }
    return $"[{status}] {_name}: {_description}";
  }

  public virtual string GetStringRep()
  {
    return "";
  }

  public virtual void ExtendGoal(int a, int b)
  { }
  
  // public string DisplayDetails()
  // {
  //   return $"{_name}, {_description}, {_points}";
  // }
}