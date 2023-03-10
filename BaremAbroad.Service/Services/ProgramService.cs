using BaremAbroad.Core.Services;
using BaremAbroad.Repository.AbstractRepositories;
using BaremAbroad.Repository.Entities;

namespace BaremAbroad.Service.Services
{
    public class ProgramService : IProgramService
    {
        private readonly IGenericRepository<Program> _genericRepository;

        public ProgramService(IGenericRepository<Program> genericRepository)
        {
            _genericRepository = genericRepository;
        }

        public async Task<Program> AddProgramAsync(Program program)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Program>> GetAllProgramsAsync()
        {
            return _genericRepository.GetAll().ToList();
        }

        public async Task<Program> GetProgramByIdAsync(int Id)
        {
            return await _genericRepository.GetByIdAsync(Id);
        }

        public async Task<Program> RemoveProgramByIdAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task<Program> UpdateProgramByIdAsync(Program program)
        {
            throw new NotImplementedException();
        }
    }
}
