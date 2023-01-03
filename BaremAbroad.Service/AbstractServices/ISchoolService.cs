using BaremAbroad.Repository.Entities;

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
