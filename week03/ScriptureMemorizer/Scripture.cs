public class Scripture
{
  private List<Word> _words;
  private int _length;
  private Reference _reference;

  public Scripture(Reference reference, string text)
  {
    _reference = reference;
    string[] textArray = text.Split(" ");
    List<Word> words = new List<Word>();
    for (int i = 0; i < textArray.Length; i++)
    {
      Word nextWord = new Word(textArray[i]);
      words.Add(nextWord);
    }
    _words = words;
    _length = words.Count;
  }

  public string GetDisplayText()
  {
    Console.Clear();
    string displayText = _reference.GetRef();
    foreach (Word word in _words)
    {
      displayText += " ";
      displayText += word.Show();
    }
    Console.WriteLine(displayText);
    return displayText;
  }

  public void HideText()
  {
    int count = 0;
    Random randomGen = new Random();
    int index;
    do
    {
      index = randomGen.Next(0, _length);
      if (IsComplete() == true)
      {
        return;
      }
      else if (_words[index].IsHidden() == false)
      {
        _words[index].Hide();
        count++;
      }
    } while (count < 3);
  }

  public bool IsComplete()
  {
    if (_words.All(word => word.IsHidden() == true))
    {
      return true;
    }
    else
    {
      return false;
    }
  }
}