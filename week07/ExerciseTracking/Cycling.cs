public class Cycling : Activity
{
  private int _duration;
  private double _tracking;

  public Cycling(int duration, double tracking) : base(duration, tracking)
  {
    _duration = duration;
    _tracking = tracking;
  }

  public override double GetDistance()
  {
    double hours = ((double)_duration / 60);
    double distance = ((double)_tracking * hours);
    distance = Math.Round(distance, 2);
    return distance;
  }
  public override double GetSpeed()
  {
    return _tracking;
  }
  public override double GetPace()
  {
    double pace = _tracking / 60;
    return pace;
  }
}