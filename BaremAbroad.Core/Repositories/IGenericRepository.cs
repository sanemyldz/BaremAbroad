﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BaremAbroad.Core.Repositories
{
    public interface IGenericRepository<T> where T :class
    {
        IQueryable<T> GetAll();

        Task<T> GetByIdAsync(int Id);

        IQueryable<T> Where(Expression<Func<T, bool>> expression);

        Task<T> AddAsync(T entity);

        void Remove(T entity);

        void Update(T entity);
    }
}
