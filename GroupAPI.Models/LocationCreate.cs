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

        /// <summary>
        /// LocationId which is automatically generated
        /// </summary>
        public int LocationId { get; set; }
        /// <summary>
        /// The location of the start of the walk
        /// </summary>
        public string LocationStart { get; set; }
        /// <summary>
        /// The location of the end of the walk
        /// </summary>
        public string LocationEnd { get; set; }
        /// <summary>
        /// The City in which the walk takes place
        /// </summary>
        public string City { get; set; }
        /// <summary>
        /// The state in which the walk takes place
        /// </summary>

        public string State { get; set; }
    }
}
