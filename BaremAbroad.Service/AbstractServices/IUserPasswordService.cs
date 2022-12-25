using BaremAbroad.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaremAbroad.Core.Services
{
    public interface IUserPasswordService
    {
        Task<UserPassword> GetUserPasswordByIdAsync(int userId);
        Task<UserPassword> UpdateUserPasswordByIdAsync(UserPassword userPassword);
        Task<UserPassword> AddUserPasswordAsync(UserPassword userPassword);
    }
}
