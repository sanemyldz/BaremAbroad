using BaremAbroad.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaremAbroad.Core.Services
{
    public interface IContentDetailService
    {
        Task<ContentDetail> GetContentDetailByIdAsync(int Id);
        Task<ContentDetail> RemoveContentDetailByIdAsync(int Id);
        Task<ContentDetail> UpdateContentDetailByIdAsync(ContentDetail contentDetail);
        Task<ContentDetail> AddContentDetailAsync(ContentDetail contentDetail);
        Task<List<ContentDetail>> GetAllContentDetailsAsync();
    }
}
