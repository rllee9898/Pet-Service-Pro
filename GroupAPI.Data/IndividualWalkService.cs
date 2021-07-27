using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupAPI.Data
{
    class IndividualWalkService
    {
        public int ServiceId { get; set; }
        public string ServiceName { get; set; }
        public int WalkLength { get; set; }
        public int LocationId { get; set; }
        public Decimal Price { get; set; }
    }
}
