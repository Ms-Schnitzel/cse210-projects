// Journal
// - AddEntry
// - Display
// - Save
// - Load
// --entries

public class Journal
{
  public List<Entry> _entries = new List<Entry>();


  public void AddEntry(Entry newEntry)
  {
    _entries.Add(newEntry); 
  }

  public void Display()
  {
    DateTime today = DateTime.Today;
    int count = 0;
    foreach (Entry entry in _entries)
    {
      entry.Display();
      DateTime entryDate = DateTime.Parse(entry._date);

      if (entryDate.Month == today.Month)
      {
        count += 1;
      }
    }
    if (count > 1)
    {
      Console.WriteLine($"You have written a journal log {count} times this month!");
    }
    if (count == 1)
    {
      Console.WriteLine($"You have your first journal log for the month!");
    }
  }

  public void Save(string file)
  {
    string saveFile = "";
    foreach (Entry entry in _entries)
    {
      saveFile += $"{entry._date}, {entry._prompt}, {entry._entry}\n";
    }
    File.WriteAllText(file, saveFile);
  }

  public void Load(string file)
  {
    string[] loadFile = File.ReadAllLines(file);
    foreach (string line in loadFile)
    {
      string[] prev = line.Split(",");
      Entry prevEntry = new Entry();
      prevEntry._date = prev[0];
      prevEntry._prompt = prev[1];
      prevEntry._entry = prev[2];
      _entries.Add(prevEntry);
    }
  }
}