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

        //Fix GetSummary method to add check for the length of the content if it is less than or equal to 10 characters. This method should return the first 10 characters of the content .
        public string GetSummary()
        {
            if (Content.Length <= 10)
            {
                return Content;
            }
            return Content.Substring(0, 10) + "...";
        }
    }
}
