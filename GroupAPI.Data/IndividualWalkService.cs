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
<<<<<<< HEAD
        //public string ServiceName { get; set; }
        public int WalkLength { get; set; }
        //public int LocationId { get; set; }
=======
      
        public string ServiceName { get; set; }

        public int WalkLength { get; set; }

        [ForeignKey(nameof(Location))]
        public int LocationId { get; set; }
        public virtual Location Location { get; set; }

>>>>>>> 1c12dd10caf25f070eabeb452f0474e8675e224d
        public Decimal Price { get; set; }
    }
}