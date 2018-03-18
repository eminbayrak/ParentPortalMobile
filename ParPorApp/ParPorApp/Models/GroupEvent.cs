using System;
using System.Collections.Generic;
using System.Text;

namespace ParPorApp.Models
{
    public class GroupEvent
    {
        public int GroupId { get; set; }
        public Group Group { get; set; }
        public int EventId { get; set; }
        public Event Event { get; set; }
    }
}
