// Comment
// 
// _name
// _text
// 
// displayComment: void;
// 
// 

public class Comment
{
  private string _name;
  private string _text;

  public Comment(string name, string text)
  {
    _name = name;
    _text = text;
  }

  public void displayComment()
  {
    Console.WriteLine($"  Username: {_name}");
    Console.WriteLine($"  \" {_text} \"");
  }
}





