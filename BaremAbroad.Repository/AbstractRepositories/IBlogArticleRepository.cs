using BaremAbroad.Core.Repositories;
using BaremAbroad.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaremAbroad.Repository.AbstractRepositories
{
    public interface IBlogArticleRepository: IGenericRepository<BlogArticle>
    {
        Task<int> UpVotesCount(int blogArticleId);
        Task<int> DownVotesCount(int blogArticleId);

    }
}
