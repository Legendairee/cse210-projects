using System.Text.Json; 

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }
    public void SaveToFile(string filename)
    {
        JsonSerializerOptions options = new JsonSerializerOptions
        {
            WriteIndented = true,
            IncludeFields = true
        };

        string jsonString = JsonSerializer.Serialize(_entries, options);
        File.WriteAllText(filename, jsonString);
    }
    public void LoadFromFile(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        string jsonString = File.ReadAllText(filename);

        JsonSerializerOptions options = new JsonSerializerOptions
        {
            IncludeFields = true
        };

        _entries = JsonSerializer.Deserialize<List<Entry>>(jsonString, options);

        if (_entries == null)
        {
            _entries = new List<Entry>();
        }
    }
}