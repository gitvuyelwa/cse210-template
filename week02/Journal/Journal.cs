using System;

class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public void AddEntry(Entry  entry)
    {
        _entries.Add(entry);
    }
    public void Display()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
        
    }
    public void SaveToFile(file :string)
    {
        
    }
    public void LoadFromFile(File :string)
    {
        
    }
}