public class ListActivity : Activity
{
  private int _count;
  private List<string> _prompts = new List<string>
  {
    "Who are people that you appreciate?",
    "Who are people that you have helped this week?",
    "Who are some of your personal heroes?",
    "What are personal strengths of yours?",
    "When have you felt the Holy Ghost this month?"
  };

  public ListActivity(string name, string description) : base(name, description)
  {  }

  public void Run()
  {
    DisplayWelcomeMessage();
    DateTime start = DateTime.Now;
    DateTime end = start.AddSeconds(_duration);
    DisplayPrompt();
    Console.WriteLine("Think for a moment \n");
    DisplayAnimation(10);
    while (DateTime.Now < end)
    {
      GetCount();
    }
    Console.WriteLine($"You were able to name {_count} answers!");
    DisplayEndMessage();
  }

  public void DisplayPrompt()
  {
    Random randomGen = new Random();
    int promptNum = randomGen.Next(0, _prompts.Count);
    Console.WriteLine($"{_prompts[promptNum]}\n");
  }

  public int GetCount()
  {
    Console.ReadLine();
    _count++;
    return _count;
  }
}