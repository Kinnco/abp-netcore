namespace AbpLearning.EntityFrameworkCore.EntityFrameworkCore
{
    using Abp.Zero.EntityFrameworkCore;
    using Core.Authorization.Roles;
    using Core.Authorization.Users;
    using Core.MultiTenancy;
    using Microsoft.EntityFrameworkCore;

    public class AbpLearningDbContext : AbpZeroDbContext<Tenant, Role, User, AbpLearningDbContext>
    {
        public AbpLearningDbContext(DbContextOptions<AbpLearningDbContext> options)
            : base(options)
        {
        }

        /* Define a DbSet for each entity of the application ����ע�� */

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // ���ʹ��Mysql���ݿ⣬�������ӿ��ԣ�����������������ʧ�ܣ�������Ҫע�͵���
            // Unable to connect to any of the specified MySQL hosts.
            // ���Abp��Ĭ�ϱ�ǰ׺ 
            // modelBuilder.ChangeAbpTablePrefix<Tenant, Role, User>("", "Abp");

            base.OnModelCreating(modelBuilder);
        }
    }
}
