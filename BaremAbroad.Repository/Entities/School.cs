using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaremAbroad.Repository.Entities
{
    public class School : BaseEntity
    {
        public string Name { get; set; }
        public int? CountryId { get; set; }
        public string Lang { get; set; }
        public ICollection<Program>? Programs { get; set; }
        public Country? Country { get; set; }  
    }
}
