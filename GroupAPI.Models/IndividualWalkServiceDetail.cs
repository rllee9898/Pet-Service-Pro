﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupAPI.Models
{
    public class IndividualWalkServiceDetail
    {
        public int ServiceId { get; set; }
        public string ServiceName { get; set; }
        public int WalkLength { get; set; }
        public int LocationId { get; set; }
        public Decimal Price { get; set; }

        //Extra Location ref  
        public string LocationStart { get; set; }
        public string LocationEnd { get; set; }
        public string City { get; set; }
        public string State { get; set; }
    }
}
