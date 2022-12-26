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
    public class FaqService : IFaqService
    {
        private readonly IGenericRepository<Faq> _genericRepository;
        public FaqService(IGenericRepository<Faq> genericRepository)
        {
            _genericRepository = genericRepository;
        }
        public async Task<Faq> AddFaqAsync(Faq faq)
        {
            await _genericRepository.AddAsync(faq);
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
