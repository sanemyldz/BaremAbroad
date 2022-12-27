﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaremAbroad.Repository.Entities
{
    public class Country : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Lang { get; set; }
        public ICollection<School>? Schools { get; set; }
    }
}
