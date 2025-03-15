using System;

class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;


    public List<Entry> _entries = new List<Entry>();

    public void Display()
    {
        Console.WriteLine($"On {_date}, I {_entryText} for {_promptText}.");

    }
}