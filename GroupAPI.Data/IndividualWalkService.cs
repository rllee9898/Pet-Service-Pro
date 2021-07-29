using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupAPI.Data
{
    public class IndividualWalkService
    {
        [Key]
        public int ServiceId { get; set; }

        //public string ServiceName { get; set; }
        public int WalkLength { get; set; }
        //public int LocationId { get; set; }
      
        public string ServiceName { get; set; }

       [ForeignKey(nameof(Location))]
        public int LocationId { get; set; }
        public virtual Location Location { get; set; }

        public Decimal Price { get; set; }
    }
}