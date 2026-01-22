public class Reference
{
  private string _book;
  private string _chapter;
  private string _verse;
  private string _verseHigh;

  public Reference(string book, string chapter, string verse)
  {
    _book = book;
    _chapter = chapter;
    _verse = verse;
  }
  public Reference(string book, string chapter, string verse, string verseHigh)
  {
    _book = book;
    _chapter = chapter;
    _verse = verse;
    _verseHigh = verseHigh;
  }

  public string GetRef()
  {
    string fullRef;
    if (_verseHigh != null)
    {
      fullRef = $"{_book} {_chapter}:{_verse}-{_verseHigh}";
    }
    else
    {
      fullRef = $"{_book} {_chapter}:{_verse}";
    }
    
    return fullRef;
  }
}