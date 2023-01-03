using BaremAbroad.Repository.Entities;

namespace BaremAbroad.Repository.AbstractRepositories
{
    public interface IBlogArticleRepository : IGenericRepository<BlogArticle>
    {
        Task<int> UpVotesCount(int blogArticleId);
        Task<int> DownVotesCount(int blogArticleId);
    }
}
