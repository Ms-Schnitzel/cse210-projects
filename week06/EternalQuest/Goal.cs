public abstract class Goal
{
  private string _name;
  private string _details;
  private int _points;

  public Goal(string name, string details, int points)
  {
    _name = name;
    _details = details;
    _points = points;
  }




  public virtual void RecordEvent()
  { }

  public virtual bool IsComplete()
  {
    return false;
  }

  public virtual string GetDetailString()
  {
    return _details;
  }
  
  public virtual string GetDetailRep()
  {
    return "";
  }
}