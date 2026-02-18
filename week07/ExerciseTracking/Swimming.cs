public class Swimming : Activity
{
  private int _duration;
  private double _tracking;

  public Swimming(int duration, double tracking) : base(duration, tracking)
  {
    _duration = duration;
    _tracking = tracking;
  }

  public override double GetDistance()
  {
    double distance = ((_tracking * 50) / 1000) * 0.62;
    return distance;
  }
  public override double GetSpeed()
  {
    double speed = (GetDistance() / _duration) * 60;
    return speed;
  }
  public override double GetPace()
  {
    double pace = 60 / GetSpeed();
    pace = Math.Round(pace, 2);
    return pace;
  }
}