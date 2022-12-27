using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaremAbroad.Repository.DTOs
{
    public class ProgramDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int? SchoolId { get; set; }
        public string Lang { get; set; }
    }
}
