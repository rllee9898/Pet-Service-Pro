using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupAPI.Models
{
    public class ScheduledWalksDetail
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


        //Extra Walker POCOs
        [Display(Name = "Walker Name")]
        public string WalkerName { get; set; }

        //Extra pet poco
        [Display(Name = "Pet Type")]
        public string PetType { get; set; }

        [Display(Name = "Pet Name")]
        public string PetName { get; set; }

        //Extra individualwalkservice

        [Display(Name = "Service Name")]
        public string ServiceName { get; set; }

        [Display(Name = "Walk Length")]
        public int WalkLength { get; set; }

        [Display(Name = "Location ID")]
        public int LocationId { get; set; }

    }
}
