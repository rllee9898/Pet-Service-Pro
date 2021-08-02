using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupAPI.Data
{
    public class Location
    {
        [Key]
        public int LocationId { get; set; }


        public string LocationStart { get; set; }

        public string LocationEnd { get; set; }

        [Required]
        public string City { get; set; }

        
        public string State { get; set; }
    }
}