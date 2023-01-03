using BaremAbroad.Repository.Entities;

namespace BaremAbroad.Core.Services
{
    public interface IProgramService
    {
        Task<Program> GetProgramByIdAsync(int Id);
        Task<Program> RemoveProgramByIdAsync(int Id);
        Task<Program> UpdateProgramByIdAsync(Program program);
        Task<Program> AddProgramAsync(Program program);
        Task<List<Program>> GetAllProgramsAsync();
    }
}
