using BaremAbroad.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaremAbroad.Core.Services
{
    public interface IFaqService
    {
        Task<Faq> GetFaqByIdAsync(int Id);
        Task<Faq> RemoveFaqByIdAsync(int Id);
        Task<Faq> UpdateFaqByIdAsync(Faq faq);
        Task<Faq> AddFaqAsync(Faq faq);
        Task<List<Faq>> GetAllFaqsAsync();
    }
}
