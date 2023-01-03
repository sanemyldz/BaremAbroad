using BaremAbroad.Core.Services;
using BaremAbroad.Repository.AbstractRepositories;
using BaremAbroad.Repository.Entities;

namespace BaremAbroad.Service.Services
{
    public class CountryService : ICountryService
    {
        private readonly IGenericRepository<Country> _genericRepository;

        public CountryService(IGenericRepository<Country> genericRepository)
        {
            _genericRepository = genericRepository;
        }

        public async Task<Country> AddCountryAsync(Country country)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Country>> GetAllCountriesAsync()
        {
            return _genericRepository.GetAll().ToList();
        }

        public async Task<Country> GetCountryByIdAsync(int Id)
        {
            return await _genericRepository.GetByIdAsync(Id);
        }

        public async Task<Country> RemoveCountryByIdAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task<Country> UpdateCountryByIdAsync(Country country)
        {
            throw new NotImplementedException();
        }
    }
}
