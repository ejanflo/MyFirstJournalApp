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

        void GetSummary()
        {
            //Returns the exact first 100 characters of the content
            if (Content.Length <= 100)
            {
                Console.WriteLine(Content);
            }
            else
            {
                Console.WriteLine(Content.Substring(0, 100));
            }
        }
    }
}
