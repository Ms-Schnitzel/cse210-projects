// exercise

// date
// length in minutes
// activity-specific tracking
  // running - distance
  // cycling - speed
  // swimming - num of laps (length of lap is 50 meters)

// get distance
// get speed (mph)
// get pace (min per mile)
// summary
  


// Math Hints:
// Distance (km) = swimming laps * 50 / 1000
// Distance (miles) = swimming laps * 50 / 1000 * 0.62
// Speed (mph or kph) = (distance / minutes) * 60
// Pace (min per mile or min per km)= minutes / distance
// Speed = 60 / pace
// Pace = 60 / speed

public abstract class Activity
{
  private string _date;
  private int _duration;
  private double _tracking;
  private string _activity;

  public Activity(int duration, double tracking)
  {
    DateTime date = DateTime.Now;
    _date = date.ToString("dd MMM yyyy");
    _duration = duration;
    _tracking = tracking;
    _activity = "";
  }

  public abstract double GetDistance();
  public abstract double GetSpeed();
  public abstract double GetPace();
  public string GetSummary()
  {
    return $"{_date} {_activity} ({_duration} min) - {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile";
  }
  
}




























