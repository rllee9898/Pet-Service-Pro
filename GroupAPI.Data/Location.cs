using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupAPI.Data
{
    /// <summary>
    /// Represents one specific location
    /// </summary>
    
    public class Location
    {
        /// <summary>
        /// Id of location, which is automatically generated.
        /// </summary>
        [Key]
        public int LocationId { get; set; }
        /// <summary>
        /// Location of the start of the walk.
        /// </summary>
        public string LocationStart { get; set; }
        /// <summary>
        /// Location of the end of a walk.
        /// </summary>
        public string LocationEnd { get; set; }
        /// <summary>
        /// City in which a particular walk takes place.
        /// </summary>
        public string City { get; set; }
        /// <summary>
        /// State in which a particular walk talkes place.
        /// </summary>
        public string State { get; set; }

    }
}
