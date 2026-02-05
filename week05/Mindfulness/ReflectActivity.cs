// Name
// Description
// Ask and Set Duration in Seconds
// Prepare to Begin, pause 
// 
// Good Job, pause
// Restate activity completed and length of time, pause
// Finish activity
// Pause shows animation

public class ReflectActivity : Activity
{
  private List<string> _prompts = new List<string>
  {
    "Think of a time when you raised someone who was down.",
    "Think of a time when you did something truly selfless.",
    "Think of a time when you did something really difficult.",
    "Think of a time when you stood up for someone else.",
    "Think of a time when you helped someone in need."
  };
  private List<string> _questions = new List<string>
  {
    "Have you ever done anything like this before?",
    "Why was this experience meaningful to you?",
    "What did you learn about yourself through this experience?",
    "How did you get started?",
    "What made this time different than other times when you were not as successful?",
    "What could you learn from this experience that applies to other situations?",
    "How can you keep this experience in mind in the future?",
    "How did you feel when it was complete?",
    "What is your favorite thing about this experience?"
  };

  public ReflectActivity(string name, string description) : base(name, description)
  {  }

  public void Run()
  {
    DisplayWelcomeMessage();
    DateTime start = DateTime.Now;
    DateTime end = start.AddSeconds(_duration);
    DisplayPrompt();
    while (DateTime.Now < end)
    {
      DisplayQuestions();
      DisplayAnimation(10);
    }
    DisplayEndMessage();
  }

  public void DisplayPrompt()
  {
    Random randomGen = new Random();
    int promptNum = randomGen.Next(0, _prompts.Count);
    Console.WriteLine($"{_prompts[promptNum]}\n");
  }

  public void DisplayQuestions()
  {
    Random randomGen = new Random();
    int questionNum = randomGen.Next(0, _questions.Count);
    Console.WriteLine($"{_questions[questionNum]} ");
  }
}