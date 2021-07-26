using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupAPI.Models
{
    public class PetListItem
    {        
        public int PetId { get; set; }
        public Guid OwnerId { get; set; }
        public string PetType { get; set; }
        public string PetName { get; set; }
    }
}