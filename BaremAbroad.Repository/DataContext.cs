using BaremAbroad.Repository.Entities;
using Microsoft.EntityFrameworkCore;

namespace BaremAbroad.Repository
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<BlogCategory> BlogCategories { get; set; }
        public DbSet<Program> Programs { get; set; }
        public DbSet<School> Schools { get; set; }
        public DbSet<UserComment> UserComments { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Follow> Follows { get; set; }
        public DbSet<BlogArticle> BlogArticles { get; set; }
        public DbSet<UserPassword> UserPasswords { get; set; }
        public DbSet<ContentDetail> ContentDetails { get; set; }
        public DbSet<UserCommentLog> UserCommentLogs { get; set; }
        public DbSet<Faq> Faqs { get; set; }
        public DbSet<BlockedWord> BlockedWords { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserComment>()
            .HasOne(e => e.User)
            .WithMany()
            .HasForeignKey(e => e.UserId)
            .OnDelete(DeleteBehavior.NoAction);
        }
        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var entries = this.ChangeTracker.Entries()
                                   .Where(x => x.State == EntityState.Added)
                                   .Select(x => x.Entity);

            foreach (var entityEntry in entries)
            {
                var auditableEntity = entityEntry as BaseEntity;

                if (auditableEntity != null)
                {
                    auditableEntity.CreateDate = DateTime.Now;
                }
            }

            var modifiedEntries = this.ChangeTracker.Entries()
                       .Where(x => x.State == EntityState.Modified)
                       .Select(x => x.Entity);

            foreach (var modifiedEntry in modifiedEntries)
            {
                var auditableEntity = modifiedEntry as BaseEntity;
                if (auditableEntity != null)
                {
                    auditableEntity.UpdateDate = DateTime.Now;
                }
            }

            return base.SaveChangesAsync();
        }
    }

}
