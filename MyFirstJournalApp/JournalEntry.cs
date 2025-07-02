using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstJournalApp
{
    public class JournalEntry
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime Timestamp { get; set; }

        //Method to get the summary of the content
        public void GetSummary()
        {
            //Returns the exact first 10 characters of the content
            Console.WriteLine(Content.Substring(0, Math.Min(10, Content.Length)));
        }
    }
}
