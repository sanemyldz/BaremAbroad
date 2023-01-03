using BaremAbroad.Repository.Entities;

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
