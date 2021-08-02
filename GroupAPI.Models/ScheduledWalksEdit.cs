using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupAPI.Models
{
    public class ScheduledWalksEdit
    {
        [Display(Name = "Event Id")]
        public int EventId { get; set; }

        [Display(Name = "Event Name")]
        public string EventName { get; set; }

        [Display(Name = "Service ID")]
        public int ServiceId { get; set; }

        [Display(Name = "Walker Id")]
        public int WalkerId { get; set; }

        [Display(Name = "Pet Id")]
        public int PetId { get; set; }

        [Display(Name = "Price")]
        public decimal Price { get; set; }
    }
}
