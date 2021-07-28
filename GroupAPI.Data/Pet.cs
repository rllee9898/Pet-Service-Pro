using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupAPI.Data
{
    public class Pet
    {
        [Key]
        public int PetId { get; set; }

        public Guid OwnerId { get; set; }
        public string PetType { get; set; }
        public string PetName { get; set; }
    }
}
