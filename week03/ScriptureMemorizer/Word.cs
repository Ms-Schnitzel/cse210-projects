public class Word
{
  private string _text;
  private bool _hidden;

  public Word(string text)
  {
    _text = text;
    _hidden = false;
  }

  public void Hide()
  {
    if (_hidden == false)
    {
      int length = _text.Length;
      char[] textArray = _text.ToCharArray();
      for (int i = 0; i < length; i++)
      {
        textArray[i] = '_';
      }
      _text = new string(textArray);
      _hidden = true;
    }
  }

  public string Show()
  {
    return _text;
  }

  public bool IsHidden()
  {
    return _hidden;
  }
}