using BaremAbroad.Core.Repositories;
using BaremAbroad.Core.Services;
using BaremAbroad.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaremAbroad.Service.Services
{
    public class SchoolService : ISchoolService
    {
        private readonly IGenericRepository<School> _genericRepository;

        public SchoolService(IGenericRepository<School> genericRepository)
        {
            _genericRepository = genericRepository;
        }

        public async Task<School> AddSchoolAsync(School school)
        {
            await _genericRepository.AddAsync(school);
            return school;
        }

        public async Task<List<School>> GetAllSchoolsAsync()
        {
            return _genericRepository.GetAll().ToList();
        }

        public async Task<School> GetSchoolByIdAsync(int Id)
        {
            return await _genericRepository.GetByIdAsync(Id);
        }

        public async Task<School> RemoveSchoolByIdAsync(int Id)
        {
            var school = await _genericRepository.GetByIdAsync(Id);
            _genericRepository.Remove(school);
            return school;
        }

        public async Task<School> UpdateSchoolByIdAsync(School school)
        {
            _genericRepository.Update(school);
            return school;
        }
    }
}
