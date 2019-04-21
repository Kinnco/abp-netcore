namespace AbpLearning.Core.Configuration.ApplicationScopes.ThirdPartyAuthorizationConfiguration
{
    public class GitHubAuthConfig
    {
        /// <summary>
        /// �Ƿ�����
        /// </summary>
        public const bool IS_ENABLED = true;

        /// <summary>
        /// ��Ȩ����
        /// </summary>
        public const string AUTHORIZATION_TYPE = "Github";

        /// <summary>
        /// Client Id
        /// </summary>
        public const string CLIENT_ID = "9381792e7265342f63e8";

        /// <summary>
        /// Client Secret
        /// </summary>
        public const string CLIENT_SECRET = "9098720cabe90cdb78d83876214c532767728a64";

        /// <summary>
        /// ��Ȩ��ַ
        /// </summary>
        public const string AUTHORIZATIO_NENDPOINT = "https://github.com/login/oauth/authorize";

        /// <summary>
        /// ��ȡAccess Token
        /// </summary>
        public const string TOKEN_ENDPOINT = "https://github.com/login/oauth/access_token";

        /// <summary>
        /// ��ȡ�û���Ϣ��ַ
        /// </summary>
        public const string USERINFO_ENDPOINT = "https://api.github.com/user";
    }
}
