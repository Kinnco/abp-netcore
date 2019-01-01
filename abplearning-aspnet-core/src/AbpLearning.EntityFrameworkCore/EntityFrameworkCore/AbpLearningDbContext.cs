namespace AbpLearning.EntityFrameworkCore.EntityFrameworkCore
{
    using Abp.Zero.EntityFrameworkCore;
    using Core.Authorization.Roles;
    using Core.Authorization.Users;
    using Core.CloudBookList.BookLiseCells;
    using Core.CloudBookList.BookLists;
    using Core.CloudBookList.Books;
    using Core.CloudBookList.BookTags;
    using Core.MultiTenancy;
    using Microsoft.EntityFrameworkCore;

    public class AbpLearningDbContext : AbpZeroDbContext<Tenant, Role, User, AbpLearningDbContext>
    {
        public AbpLearningDbContext(DbContextOptions<AbpLearningDbContext> options)
            : base(options)
        {
        }

        /* Define a DbSet for each entity of the application ����ע�� */

        #region ���鵥

        public DbSet<BookTag> BookTag { get; set; }

        public DbSet<Book> Book { get; set; }

        public DbSet<BookListCell> BookListCell { get; set; }

        public DbSet<BookList> BookList { get; set; }

        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // ���Abp��Ĭ�ϱ�ǰ׺
            modelBuilder.ChangeAbpTablePrefix<Tenant, Role, User>("");

            base.OnModelCreating(modelBuilder);
        }
    }
}
