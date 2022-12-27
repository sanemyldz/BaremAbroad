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
    public class ContentDetailService : IContentDetailService
    {
        private readonly IGenericRepository<ContentDetail> _genericRepository;

        public ContentDetailService(IGenericRepository<ContentDetail> genericRepository)
        {
            _genericRepository = genericRepository;
        }

        public async Task<ContentDetail> AddContentDetailAsync(ContentDetail contentDetail)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ContentDetail>> GetAllContentDetailsAsync()
        {
            return _genericRepository.GetAll().ToList();
        }

        public async Task<ContentDetail> GetContentDetailByIdAsync(int Id)
        {
            return await _genericRepository.GetByIdAsync(Id);
        }

        public async Task<ContentDetail> RemoveContentDetailByIdAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task<ContentDetail> UpdateContentDetailByIdAsync(ContentDetail contentDetail)
        {
            throw new NotImplementedException();
        }
    }
}
