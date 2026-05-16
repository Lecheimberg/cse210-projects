using System.Text;

public class Journal

{

    private List<Entry> _entries = new List<Entry>();

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

    public void SaveToFile(string file)

    {

        using (StreamWriter output = new StreamWriter(file))

        {
            output.WriteLine($"Saved On: {DateTime.Now}");
            output.WriteLine("--------------------------");

            foreach (Entry entry in _entries)

            {

                output.WriteLine($"{entry._date}~|~{entry._promptText}~|~{entry._entryText}");

            }

        }

        Console.WriteLine("Journal saved successfully.");

    }

    public void LoadFromFile(string file)

    {
        if (!File.Exists(file))
        {

        Console.WriteLine("Error: File does not exist.");

        return;

    }

        _entries.Clear();

        string[] lines = File.ReadAllLines(file);

        foreach (string line in lines)

        {
            if (line.StartsWith("Saved On:") || line.StartsWith("---"))

        {

            continue;

        }

            string[] parts = line.Split("~|~");

            if (parts.Length == 3)

            {

                Entry entry = new Entry();

                entry._date = parts[0];

                entry._promptText = parts[1];

                entry._entryText = parts[2];

                _entries.Add(entry);

            }

        }
        
        Console.WriteLine("Journal loaded successfully.");

    }

}