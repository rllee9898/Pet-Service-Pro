using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupAPI.Models
{
    public class LocationCreate
    {
        [Display(Name = "Location ID")]
        public int LocationId { get; set; }

        [Display(Name = "Location Start")]
        public string LocationStart { get; set; }

        [Display(Name = "Location End")]
        public string LocationEnd { get; set; }

        [Display(Name = "City")]
        public string City { get; set; }

        [Display(Name = "State")]
        public string State { get; set; }
    }
}
