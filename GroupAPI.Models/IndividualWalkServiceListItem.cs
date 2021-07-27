using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupAPI.Models
{
    public class IndividualWalkServiceListItem
    {
        [Display(Name = "Service ID")]
        public int ServiceId { get; set; }
       
        [Display(Name = "Service Name")]
        public string ServiceName { get; set; }
        
        [Display(Name = "Walk Length")]
        public int WalkLength { get; set; }
        
        [Display(Name = "Location ID")]
        public int LocationId { get; set; }
       
        [Display(Name = "Price")]
        public Decimal Price { get; set; }
    }
}
