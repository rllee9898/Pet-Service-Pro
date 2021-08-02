using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupAPI.Data
{
    public class ScheduledWalks
    {
        [Key]
        public int EventId { get; set; }

        [Required]
        public string EventName { get; set; }

        [ForeignKey(nameof(IndividualWalkService))]
        public int ServiceId { get; set; }
        public virtual IndividualWalkService IndividualWalkService { get; set; }

        [ForeignKey(nameof(Walker))]
        public int WalkerId { get; set; }
        public virtual Walker Walker { get; set; }

        [ForeignKey(nameof(Pet))]
        public int PetId { get; set; }
        public virtual Pet Pet { get; set; }

        public decimal Price { get; set; }

    }
}
