using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupAPI.Models
{
    public class WalkerEdit
    {
        [Display(Name = "Walker Id")]
        public int WalkerId { get; set; }

        [Display(Name = "Walk Length")]
        public string WalkerName { get; set; }
    }
}

