namespace AbpLearning.Core.Authorization.Users
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Abp.Authorization.Users;
    using Abp.Extensions;

    public class User : AbpUser<User>
    {
        public const string DefaultPassword = "123qwe";

        /// <summary>
        /// ͷ��
        /// </summary>
        public string AvatarUrl { get; set; }

        [Obsolete("Name�����Ѿ�����ʹ�ã���ʹ��UserName")]
        [Required(AllowEmptyStrings = true)]
        private new string Name { get; set; }

        [Obsolete("Surname�����Ѿ�����ʹ�ã���ʹ��UserName")]
        [NotMapped]
        [Required(AllowEmptyStrings = true)]
        private new string Surname { get; set; }

        public static string CreateRandomPassword()
        {
            return Guid.NewGuid().ToString("N").Truncate(16);
        }

        public static User CreateTenantAdminUser(int tenantId, string emailAddress)
        {
            var user = new User
            {
                TenantId = tenantId,
                UserName = AdminUserName,
                EmailAddress = emailAddress
            };

            user.SetNormalizedNames();

            return user;
        }
    }
}
