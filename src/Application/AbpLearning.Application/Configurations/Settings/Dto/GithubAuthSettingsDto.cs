using System.ComponentModel.DataAnnotations;

namespace AbpLearning.Application.Configurations.Settings.Dto
{
    public class GithubAuthSettingsDto
    {
        /// <summary>
        /// GitHub��Ȩ�Ƿ�����
        /// </summary>
        [Required]
        public bool IsEnabled { get; set; }

        /// <summary>
        /// GitHub��ȨClient Id
        /// </summary>
        public string ClientId { get; set; }

        /// <summary>
        /// GitHub��ȨClient Secret
        /// </summary>
        public string ClientSecret { get; set; }

        /// <summary>
        /// GitHub��Ȩ��ַ
        /// </summary>
        [DataType(DataType.Url)]
        public string AuthorizeUrl { get; set; }

        /// <summary>
        /// GitHub��Ȩ��ȡAccess Token
        /// </summary>
        [DataType(DataType.Url)]
        public string AccessTokenUrl { get; set; }

        /// <summary>
        /// GitHub��Ȩ��ȡ�û���Ϣ��ַ
        /// </summary>
        [DataType(DataType.Url)]
        public string UserinfoUrl { get; set; }
    }
}
