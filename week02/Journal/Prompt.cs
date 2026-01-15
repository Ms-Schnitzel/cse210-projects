public class Prompt
{
  public List<string> _prompts = new List<string>();
  string[] promptFile = File.ReadAllLines("newPrompts.csv");


  public string GetPrompt()
  {
    Random random = new Random();
    int index = random.Next(10);
    return promptFile[index];
  }
}