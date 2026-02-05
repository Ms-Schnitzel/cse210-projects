// Name
// Description
// Ask and Set Duration in Seconds
// Prepare to Begin, pause 
// 
// Good Job, pause
// Restate activity completed and length of time, pause
// Finish activity
// Pause shows animation

public class BreathActivity : Activity
{
  public BreathActivity(string name, string description) : base(name, description)
  { }



  public void Run()
  {
    DisplayWelcomeMessage();
    DateTime start = DateTime.Now;
    DateTime end = start.AddSeconds(_duration);
    int i = 4;
    // int j = 4;
    while (DateTime.Now < end)
    {
      Console.Write("\nBreath in...");
      while (i > 0)
      {
        Console.Write($"{i}");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        i--;
      }
      i = 4;
      Console.Write("\nBreath out...");
      while (i >= 1)
      {
        Console.Write($"{i}");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        i--;
      }
      Console.WriteLine("");
      i = 4;
    };
    DisplayEndMessage();
  }
}