using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaremAbroad.Repository.Entities
{
    public class Faq : BaseEntity
    {
        public string Question { get; set; }
        public string Description { get; set; }
        public string Lang { get; set; }
    }
}
