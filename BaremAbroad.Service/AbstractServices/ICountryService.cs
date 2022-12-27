using BaremAbroad.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
