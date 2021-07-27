using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupAPI.Data
{
    public class IndividualWalkService
    {
        //[Key]
        //[Required]
        public int ServiceId { get; set; }
        //public string ServiceName { get; set; }
        public int WalkLength { get; set; }
        //public int LocationId { get; set; }
        public Decimal Price { get; set; }
    }
}
