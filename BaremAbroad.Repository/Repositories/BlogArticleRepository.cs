using BaremAbroad.Repository.AbstractRepositories;
using BaremAbroad.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaremAbroad.Repository.Repositories
{
    public class BlogArticleRepository: GenericRepository<BlogArticle>, IBlogArticleRepository
    {
        public BlogArticleRepository(DataContext DataContext) : base(DataContext)
        {

        }
        public async Task<int> DownVotesCount(int blogArticleId)
        {
            return _dbSet.FirstOrDefault(e => e.Id.Equals(blogArticleId)).DownVotes;
        }

        public async Task<int> UpVotesCount(int blogArticleId)
        {
            return _dbSet.FirstOrDefault(e => e.Id.Equals(blogArticleId)).UpVotes;
        }
    }
}
