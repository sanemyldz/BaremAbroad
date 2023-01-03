using BaremAbroad.Core.Services;
using BaremAbroad.Repository.AbstractRepositories;
using BaremAbroad.Repository.Entities;
using System.Transactions;

namespace BaremAbroad.Service.Services
{
    public class FaqService : IFaqService
    {
        private readonly IGenericRepository<Faq> _genericRepository;

        public FaqService(IGenericRepository<Faq> genericRepository)
        {
            _genericRepository = genericRepository;
        }
        public async Task<Faq> AddFaqAsync(Faq faq)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                try
                {
                    await _genericRepository.AddAsync(faq);
                    scope.Complete();
                }
                catch (Exception)
                {
                    scope.Dispose();
                }
            }

            return faq;
        }

        public async Task<List<Faq>> GetAllFaqsAsync()
        {
            return _genericRepository.GetAll().ToList();
        }

        public async Task<Faq> GetFaqByIdAsync(int Id)
        {
            return await _genericRepository.GetByIdAsync(Id);
        }

        public async Task<Faq> RemoveFaqByIdAsync(int Id)
        {
            var faq = await _genericRepository.GetByIdAsync(Id);
            _genericRepository.Remove(faq);
            return faq;
        }

        public async Task<Faq> UpdateFaqByIdAsync(Faq faq)
        {
            _genericRepository.Update(faq);
            return faq;
        }
    }
}
