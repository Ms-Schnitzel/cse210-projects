public class MathAssignment : Assignment
{
  private string _textbookSection;
  private string _problems;

  public MathAssignment(string name, string topic, string textbook, string problems) : base(name, topic)
  {
    _textbookSection = textbook;
    _problems = problems;
  }

  public string GetHomeworkList()
  {
    return $"{_textbookSection} Problems {_problems}";
  }
}