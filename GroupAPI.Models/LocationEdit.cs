using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupAPI.Models
{
    public class LocationEdit
    {
        public int LocationId { get; set; }
        public string LocationStart { get; set; }
        public string LocationEnd { get; set; }
        public string City { get; set; }
        public string State { get; set; }
    }
}
