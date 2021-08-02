using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupAPI.Models
{
    public class PetDetail
    {
        [Display(Name = "Pet Id")]
        public int PetId { get; set; }

        [Display(Name = "Owner Id")]
        public Guid OwnerId { get; set; }

        [Display(Name = "Pet Type")]
        public string PetType { get; set; }

        [Display(Name = "Pet Name")]
        public string PetName { get; set; }
    }
}