using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupAPI.Data
{
    class Walker
    {
        [Key]
        public int WalkerId { get; set; }
         
        public string WalkerName { get; set; }
    }
}
