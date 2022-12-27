using BaremAbroad.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaremAbroad.Core.Services
{
    public interface IBlogCategoryService
    {
        Task<BlogCategory> GetBlogCategoryByIdAsync(int Id);
        Task<BlogCategory> RemoveBlogCategoryByIdAsync(int Id);
        Task<BlogCategory> UpdateBlogCategoryByIdAsync(BlogCategory blogCategory);
        Task<BlogCategory> AddBlogCategoryAsync(BlogCategory blogCategory);
        Task<List<BlogCategory>> GetAllBlogCategoriesAsync();
    }
}
