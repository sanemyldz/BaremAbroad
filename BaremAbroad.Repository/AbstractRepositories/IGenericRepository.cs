﻿using System.Linq.Expressions;

namespace BaremAbroad.Repository.AbstractRepositories
{
    public interface IGenericRepository<T> where T : class
    {
        IQueryable<T> GetAll();

        Task<T> GetByIdAsync(int Id);

        IQueryable<T> Where(Expression<Func<T, bool>> expression);

        Task<T> AddAsync(T entity);

        void Remove(T entity);

        void Update(T entity);
    }
}
