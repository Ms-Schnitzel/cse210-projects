// Video
// 
// _title: string
// _author: string
// _length: int
// _comments: List<Comment>
// 
// displayVideo: void

public class Video
{
  private string _title;
  private string _author;
  private int _length;
  private List<Comment> _comments;

  public Video(string title, string author, int length, List<Comment> comments)
  {
    _title = title;
    _author = author;
    _length = length;
    _comments = comments;
  }

  public void displayVideo()
  {
    Console.WriteLine($" Title: {_title}");
    Console.WriteLine($"  Author: {_author}");
    Console.WriteLine($"  Video duration: {_length} seconds");
    int comLen = _comments.Count;
    Console.WriteLine($"  Comments: {comLen}");
    foreach (Comment comment in _comments)
    {
      comment.displayComment();
    }
  }
}








