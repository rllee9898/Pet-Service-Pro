using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupAPI.Models
{
    public class ScheduledWalksCreate
    {
        public int EventId { get; set; }
        public string EventName { get; set; }
        public int ServiceId { get; set; }
        public int WalkerId { get; set; }
        public int PetId { get; set; }
        public decimal Price { get; set; }
    }
}
