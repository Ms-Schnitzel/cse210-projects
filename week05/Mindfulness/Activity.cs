public class Activity
{
  private string _name;
  private string _description;
  protected int _duration;

  public Activity(string name, string description)
  {
    _name = name;
    _description = description;
  }


  public void DisplayWelcomeMessage()
  {
    Console.WriteLine($"Welcome to the {_name} Activity. \n\n{_description}\n");
    GetDuration();
    Console.WriteLine("Get ready...");
    DisplayAnimation(4);
  }
  public void GetDuration()
  {
    Console.WriteLine("How long (in seconds) would you like for this activity?");
    _duration = int.Parse(Console.ReadLine());
  }

  public void DisplayEndMessage()
  {
    Console.WriteLine("Good work! \n");
    Thread.Sleep(3000);
    Console.WriteLine($"You have completed another {_duration} seconds of the {_name} Activity.");
    DisplayAnimation(10);
  }

  public void DisplayAnimation(int len)
  {
    List<string> animation = new List<string>();
    animation.Add("-");
    animation.Add("\\");
    animation.Add("|");
    animation.Add("/");

    DateTime start = DateTime.Now;
    DateTime end = start.AddSeconds(len);

    int i = 0;
    while (DateTime.Now < end)
    {
      string a = animation[i];
      Console.Write(a);
      Thread.Sleep(300);
      Console.Write("\b \b");

      i++;
      if (i >= animation.Count)
      {
        i = 0;
      }
    }
  }

  public int setWellness()
  {
    return _duration;
  }
}