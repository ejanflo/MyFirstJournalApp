using System;

namespace MyFirstJournalApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get dummy data from JournalEntry class
            JournalEntry entry = new JournalEntry
            {
                Id = 1,
                Title = "My First Entry",
                Content = "This is the content of my first journal entry.",
                Timestamp = DateTime.Now
            };

            //Display the entry details
            Console.WriteLine($"Entry ID: {entry.Id}");

            //Display GetSummary method from JournalEntry class
            Console.WriteLine("Summary: ");
            entry.GetSummary();
        }
    }
}