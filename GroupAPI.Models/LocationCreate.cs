using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupAPI.Models
{
    public class LocationCreate
    {
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
