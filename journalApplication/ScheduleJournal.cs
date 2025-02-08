public class ScheduleJournal
{
    //Create a list of Entries to be able to hold all new entries to be moved around later.
     public List<Entry> _entries = new List<Entry>();
        // Method to add entries to the new _entries list of Entries
        public void AddEntry(Entry entry)
        {
            _entries.Add(entry);
        }
        // Method to show all of the entries in the journal from the txt file
        public void DisplayAll()
        {
            // Choose the file name that the information will be written to and read from
            string filename = "journal.txt";
            // Look at all of the lines from the file
            string[] lines = System.IO.File.ReadAllLines(filename);
            // For every line in the txt file, something will be done
            foreach (string line in lines)
            {
                // Use a "|" to split the lines up. Entries are divided into two parts, a date and an entry. These are both held on the same line to differenciate them from other entries
                string[] parts = line.Split("|");
                // The line is put into an array at the divding mark, and each index is used to separate the date and the entry
                string date = parts[0];
                string entry = parts[1];
                // Dates and Entries are written to the console for viewing
                Console.WriteLine($"Date: {date}");
                Console.WriteLine($"Entry: {entry}");
                Console.WriteLine("");
            }
        }

        public void SaveToFile(string date, string entry)
        {
            using (StreamWriter outputFile = new StreamWriter("journal.txt", true))
            {
                outputFile.WriteLine($"{date}|{entry}");
            }
        }
}