namespace AbpLearning.EntityFrameworkCore.EntityFrameworkCore
{
    using Abp.Zero.EntityFrameworkCore;
    using AbpLearning.Core.Files;
    using Core;
    using Core.Authorization.Roles;
    using Core.Authorization.Users;
    using Core.CloudBookLists.BookListCells;
    using Core.CloudBookLists.BookLists;
    using Core.CloudBookLists.Books;
    using Core.CloudBookLists.BookTags;
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

        /// <summary>
        /// ��ǩ
        /// </summary>
        public DbSet<BookTag> BookTag { get; set; }

        /// <summary>
        /// �鼮
        /// </summary>
        public DbSet<Book> Book { get; set; }

        /// <summary>
        /// �鵥���ӣ�1����/�飩
        /// </summary>
        public DbSet<BookListCell> BookListCell { get; set; }

        /// <summary>
        /// �鵥
        /// </summary>
        public DbSet<BookList> BookList { get; set; }

        #endregion

        #region File

        public DbSet<UploadFile> UploadFiles { get; set; }

        public DbSet<FileType> FileTypes { get; set; }

        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // ���Abp��Ĭ�ϱ�ǰ׺
            modelBuilder.ChangeAbpTablePrefix<Tenant, Role, User>(AbpLearningConsts.TablePreFixName.ABP, AbpLearningConsts.TableSchemaName.ABP);

            base.OnModelCreating(modelBuilder);
        }
    }
}
