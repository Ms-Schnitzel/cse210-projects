public class Running : Activity
{
  private int _duration;
  private double _tracking;

  public Running(int duration, double tracking) : base(duration, tracking)
  {
    _duration = duration;
    _tracking = tracking;
  }

  public override double GetDistance()
  {
    return _tracking;
  }
  public override double GetSpeed()
  {
    double speed = ((_tracking * 60) / _duration);
    speed = Math.Round(speed, 2);
    return speed;
  }
  public override double GetPace()
  {
    double pace = _duration / _tracking;
    return pace;
  }
}