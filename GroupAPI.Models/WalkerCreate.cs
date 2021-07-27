using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupAPI.Models
{
    class WalkerCreate
    {
        //[Key]
        //[Required]
        public int WalkerId { get; set; }
        public string WalkerName { get; set; }
    }
}
