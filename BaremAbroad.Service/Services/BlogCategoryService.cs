﻿using BaremAbroad.Core.Repositories;
using BaremAbroad.Core.Services;
using BaremAbroad.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaremAbroad.Service.Services
{
    public class BlogCategoryService : IBlogCategoryService
    {
        private readonly IGenericRepository<BlogCategory> _genericRepository;

        public BlogCategoryService(IGenericRepository<BlogCategory> genericRepository)
        {
            _genericRepository = genericRepository;
        }

        public Task<BlogCategory> AddBlogCategoryAsync(BlogCategory blogCategory)
        {
            throw new NotImplementedException();
        }

        public async Task<List<BlogCategory>> GetAllBlogCategoriesAsync()
        {
            return _genericRepository.GetAll().ToList();
        }

        public async Task<BlogCategory> GetBlogCategoryByIdAsync(int Id)
        {
            return await _genericRepository.GetByIdAsync(Id);
        }

        public Task<BlogCategory> RemoveBlogCategoryByIdAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<BlogCategory> UpdateBlogCategoryByIdAsync(BlogCategory blogCategory)
        {
            throw new NotImplementedException();
        }
    }
}
