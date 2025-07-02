using System;

namespace MyFirstJournalApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Add a new journal entry
            JournalEntry entry = new JournalEntry
            {
                Id = 1,
                Title = "My First Entry",
                Content = "This is the content of my first journal entry.",
                Timestamp = DateTime.Now
            };

            //Display GetSummary method
            Console.WriteLine("Summary: " + entry.GetSummary());
        }
    }
}