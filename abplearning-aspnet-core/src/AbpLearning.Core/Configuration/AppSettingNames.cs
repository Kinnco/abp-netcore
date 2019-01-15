namespace AbpLearning.Core.Configuration
{
    using Abp.Configuration;

    /// <summary>
    /// App Setting Names
    /// <see cref="AppSettingProvider"/> for setting definitions.
    /// <see cref="SettingScopes"/> for setting scopes
    /// </summary>
    public static class AppSettingNames
    {
        public const string UiTheme = "App.UiTheme";

        /// <summary>
        /// Application Settings
        /// </summary>
        public static class Application
        {
            /// <summary>
            /// �Ƿ�����ע���⻧
            /// </summary>
            public const string IsTenantRegister = "IsTenantRegister";

            /// <summary>
            /// �Ƿ��������⻧Ĭ�ϼ���
            /// </summary>
            public const string IsDefaultActivationForNewTenant = "IsDefaultActivationForNewTenant";
        }

        public static class Tenant
        {

        }

        public static class User
        {

        }
        
        public static class All
        {

        }

    }
}
