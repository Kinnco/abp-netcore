namespace AbpLearning.Core.Configuration.ApplicationScopes.ThirdPartyAuthorizationConfiguration
{
    public class GithubAuthConfig
    {
        /// <summary>
        /// GitHub��Ȩ�Ƿ�����
        /// </summary>
        public const bool GithubAuthIsEnabled = true;

        /// <summary>
        /// GitHub��ȨClient Id
        /// </summary>
        public const string GithubAuthClientId = "9381792e7265342f63e8";

        /// <summary>
        /// GitHub��ȨClient Secret
        /// </summary>
        public const string GithubAuthClientSecret = "9098720cabe90cdb78d83876214c532767728a64";

        /// <summary>
        /// GitHub��Ȩ��ַ
        /// </summary>
        public const string GithubAuthAuthorizeUrl = "https://github.com/login/oauth/authorize";

        /// <summary>
        /// GitHub��Ȩ��ȡAccess Token
        /// </summary>
        public const string GithubAuthAccessTokenUrl = "https://github.com/login/oauth/access_token";

        /// <summary>
        /// GitHub��Ȩ��ȡ�û���Ϣ��ַ
        /// </summary>
        public const string GithubAuthUserinfoUrl = "https://api.github.com/user";
    }
}
