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
            
        }

        /// <summary>
        /// Tenant Settings
        /// </summary>
        public static class Tenant
        {
            /// <summary>
            /// �Ƿ�����ע���⻧
            /// </summary>
            public const string IsTenantRegister = "IsTenantRegister";

            /// <summary>
            /// �Ƿ��������⻧Ĭ�ϼ���
            /// </summary>
            public const string IsDefaultActivationForNewTenant = "IsDefaultActivationForNewTenant";

            /// <summary>
            /// ע��ʱ����֤������
            /// <see cref=""/>
            /// </summary>
            public const string VerificationCodeTypeAtRegistration = "VerificationCodeTypeAtRegistration";
        }

        /// <summary>
        /// User Settings
        /// </summary>
        public static class User
        {

        }

        /// <summary>
        /// All Settings
        /// </summary>
        public static class All
        {

        }

    }
}
