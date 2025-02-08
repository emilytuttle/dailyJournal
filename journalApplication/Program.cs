using System;

class Program
{
    static void Main(string[] args)
    {
        // Use the DateTime class to get the current time, then change the format to mm/dd/yyy
        DateTime theCurrentTime = DateTime.Now;
        string currentDate = theCurrentTime.ToShortDateString();

        // Create a new instance of journal to pass all new entries to
        ScheduleJournal journal = new ScheduleJournal();


        // Create a low decision that does not equal 3 so the while loop will run
        int userDecision = -10000;

        // Use a while loop to run the program. Quit is typing 3 when the options to write an entry, view entries, or quit are options
        while (userDecision !=3)
        {
            // Provide all of the options in separate lines so they are easy to read, and include a blank line for spacing.
            Console.WriteLine("");
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Write an entry of your schedule for the day");
            Console.WriteLine("2. View my schedule journal entries");
            Console.WriteLine("3. Quit");

            // Prompt the user to choose an item from the list
            Console.Write("What would you like to do?: ");

            //Create a new variable to hold the user's answer, which will be read from the console so the value can be passed
            string userDecisionString = Console.ReadLine();
            // Parse the string from the user's decision into an integer so it can be compared to numbers easily
            userDecision = int.Parse(userDecisionString);

            // Using conditionals to determine what the program does and when. Different choices from the user's decision above determine what will show. This is done based off of numbers and comparing their equivalency
            if (userDecision == 1)
            {
                // Provides a place for a new entry to be written, and includes a label so it is clear what the user should do.
                Console.Clear();
                Console.WriteLine("Write your entry here:");
                string currentEntry = Console.ReadLine();
                
                // Check the entry text to make sure it is not empty, then pass it on. If there is no text, the entry will not be saved.
                string entryText;
                if (currentEntry == "")
                {
                    entryText = "no entry";
                }
                else
                {
                    // Make the entry text equal the current entry from the user
                    entryText = currentEntry;
                    // Rewrite the entry under a description of what is being displayed
                    Console.Clear();
                    Console.WriteLine("Your new entry is:");
                    Console.WriteLine(currentEntry);
                    // Create a new instance of the entry class to pass the date and text in
                    Entry entry = new Entry(currentDate, entryText);
                    // Add the new entry into the list of entries in the Journal class
                    journal.AddEntry(entry);
                    // Write the new line to the txt file through a method created in the Journal class
                    journal.SaveToFile(currentDate, entryText);
                }
            }
            // If the user chooses 2, they will be shown all of the entries in the Journal. This is done through a method in the Journal class
            else if (userDecision == 2)
            {
                Console.Clear();
                journal.DisplayAll();
            }
            
        }
    }
}





