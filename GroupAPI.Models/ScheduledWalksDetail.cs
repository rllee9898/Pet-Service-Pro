using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupAPI.Models
{
    public class ScheduledWalksDetail
    {
        public int EventId { get; set; }
        public string EventName { get; set; }
        public int ServiceId { get; set; }
        public int WalkerId { get; set; }
        public int PetId { get; set; }
        public decimal Price { get; set; }

        //Extra Walker POCOs
        public string WalkerName { get; set; }

        //Extra pet poco
        public string PetType { get; set; }
        public string PetName { get; set; }

        //Extra individualwalkservice
        public string ServiceName { get; set; }
        public int WalkLength { get; set; }      
        public int LocationId { get; set; }

    }
}
