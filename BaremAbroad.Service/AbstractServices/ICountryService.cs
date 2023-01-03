using BaremAbroad.Repository.Entities;

namespace BaremAbroad.Core.Services
{
    public interface ICountryService
    {
        Task<Country> GetCountryByIdAsync(int Id);
        Task<Country> RemoveCountryByIdAsync(int Id);
        Task<Country> UpdateCountryByIdAsync(Country country);
        Task<Country> AddCountryAsync(Country country);
        Task<List<Country>> GetAllCountriesAsync();
    }
}
