using System;
using System.Collections.Generic;
using System.Text;

namespace AllieEntity
{
    public class Journal
    {
        public int Id { get; set; }
        public string JournalName { get; set; }
        public DateTime JournalPeriod { get; set; }
        public string Description { get; set; }
        public int LedgerId { get; set; }
    }
}
