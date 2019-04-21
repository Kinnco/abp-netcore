namespace AbpLearning.Core.Configuration.ApplicationScopes
{
    public static class ApplicationSettingNames
    {
        public const string SETTING_NAME = "Application";

        /// <summary>
        /// ��������Ȩ
        /// </summary>
        public static class ThirdPartyAuth
        {
            public const string SETTING_NAME = ApplicationSettingNames.SETTING_NAME + ".ThirdPartyAuth";

            public const string IS_ENABLED_THIRD_AUTH = SETTING_NAME + ".IsEnabled";

            /// <summary>
            /// GitHub ��Ȩ
            /// </summary>
            public static class GitHubAuth
            {
                public const string SETTING_NAME = ThirdPartyAuth.SETTING_NAME + ".GitHub";
                /// <summary>
                /// �Ƿ�����
                /// </summary>
                public const string IS_ENABLED = SETTING_NAME + ".IsEnabled";

                /// <summary>
                /// ��Ȩ����
                /// </summary>
                public const string AUTHORIZATION_TYPE = SETTING_NAME + ".AuthorizationType";

                /// <summary>
                /// Client Id
                /// </summary>
                public const string CLIENT_ID = SETTING_NAME + ".ClientId";

                /// <summary>
                /// Client Secret
                /// </summary>
                public const string CLIENT_SECRET = SETTING_NAME + ".ClientSecret";

                /// <summary>
                /// ��Ȩ��ַ
                /// </summary>
                public const string AUTHORIZATION_NENDPOINT = SETTING_NAME + ".AuthorizationEndpoint";

                /// <summary>
                /// ��ȡAccess Token
                /// </summary>
                public const string TOKEN_ENDPOINT = SETTING_NAME + ".TokenEndpoint";

                /// <summary>
                /// ��ȡ�û���Ϣ��ַ
                /// </summary>
                public const string USERINFO_ENDPOINT = SETTING_NAME + ".UserinfoEndpoint";
            }
        }
    }
}
