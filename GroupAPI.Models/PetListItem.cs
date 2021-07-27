using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupAPI.Models
{
    public class PetListItem
    {
        [Display(Name = "Pet ID")]
        public int PetId { get; set; }

        [Display(Name = "Owner ID")]
        public Guid OwnerId { get; set; }

        [Display(Name = "Pet Type")]
        public string PetType { get; set; }

        [Display(Name = "Pet Name")]
        public string PetName { get; set; }
    }
}