using System;

public class Entry
{

    // Create instances of the properties that will be in the Entry class
    public string _entryText;
    public string _date;

    // A constructor to allow new Entry class instances to be created, and require them to have the right properties passed in
    public Entry (string date, string entryText) {
        _date = date;
        _entryText = entryText;
    }

    // Provide a display string for individual entries to be displayed with the entry and the date
    public void Display()
    {
        Console.WriteLine($"Date: {_date}: Entry: {_entryText}");
    }
    
}