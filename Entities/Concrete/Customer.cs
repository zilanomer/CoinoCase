﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Customer:IEntitiy
    {

        public string CustomerId { get; set; }
        public string ContactName { get; set; }
        public string CompanytName { get; set; }
        public string City { get; set; }
    }
}
