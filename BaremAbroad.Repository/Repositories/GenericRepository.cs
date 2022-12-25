using BaremAbroad.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BaremAbroad.Repository.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly DataContext _dataContext;
        protected readonly DbSet<T> _dbSet;

        public GenericRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
            _dbSet = dataContext.Set<T>();
        }

        public async Task<T> AddAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
            await _dataContext.SaveChangesAsync();
            return entity;
        }

        public IQueryable<T> GetAll()
        {
            return _dbSet.AsNoTracking().AsQueryable();
        }

        public async Task<T> GetByIdAsync(int Id)
        {
            return await _dbSet.FindAsync(Id);
        }

        public void Remove(T entity)
        {
            _dbSet.Remove(entity);
            _dataContext.SaveChanges();

        }

        public void Update(T entity)
        {
            _dbSet.Update(entity);
            _dataContext.SaveChanges();

        }

        public IQueryable<T> Where(Expression<Func<T, bool>> expression)
        {
            return _dbSet.Where(expression);
        }
    }
}
