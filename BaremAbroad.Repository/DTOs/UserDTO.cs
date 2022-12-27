using BaremAbroad.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaremAbroad.Repository.DTOs
{
    public class UserDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string LoginName { get; set; }
        public string AdminLevel { get; set; }
        public string SocialRef { get; set; }
        public string Sub { get; set; }
        public UserPasswordDTO UserPassword { get; set; }

    }
}
