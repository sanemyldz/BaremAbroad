using BaremAbroad.Repository.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaremAbroad.Repository.DTOs
{
    public class UserPasswordDTO
    {
        public string HashedPassword { get; set; }
        public string PasswordSalt { get; set; }   
    }
}
