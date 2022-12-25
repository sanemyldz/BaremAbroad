using BaremAbroad.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaremAbroad.Core.Services
{
    public interface ISchoolService
    {
        Task<School> GetSchoolByIdAsync(int Id);
        Task<School> RemoveSchoolByIdAsync(int Id);
        Task<School> UpdateSchoolByIdAsync(School school);
        Task<School> AddSchoolAsync(School school);
        Task<List<School>> GetAllSchoolsAsync();
    }
}
