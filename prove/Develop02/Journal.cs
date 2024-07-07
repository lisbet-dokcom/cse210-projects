public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void DisplayMethod()
    {
        foreach (var entry in _entries)
        {
            Console.WriteLine($"Date: {entry._date} - Prompt: {entry._promptText}");
            Console.WriteLine(entry._entryText);
            Console.WriteLine("");
        }
    }

    public void SaveToFile(string filename, List<Entry> journal)
    {
        string[] lines = new string[journal.Count];
        for (int i = 0; i < journal.Count; i++)
        {
            Entry entry = journal[i];
            lines[i] = ($"{entry._date}, {entry._promptText}, {entry._entryText}");
        }
        System.IO.File.WriteAllLines(filename, lines);
    }

    public void LoadFrom(string filename)
    {
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split(",");
            
            string dateText = parts[0];
            string promptText = parts[1];
            string entryText = parts[2];
            AddEntry(new Entry{_date = dateText, _promptText = promptText, _entryText = entryText});
        }
    }
}
