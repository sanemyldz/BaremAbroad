using BaremAbroad.Repository.Entities;

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
