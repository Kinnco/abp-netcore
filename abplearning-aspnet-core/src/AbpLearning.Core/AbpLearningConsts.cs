namespace AbpLearning.Core
{
    public static class AbpLearningConsts
    {
        public const string LocalizationSourceName = "AbpLearning";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;

        /// <summary>
        /// ��ҳģ���У����ص�Ĭ������
        /// </summary>
        public const int DefaultResultCount = 10;

        /// <summary>
        /// ��ҳģ���У����ص��������
        /// </summary>
        public const int MaxResultCount = 100;

        /// <summary>
        /// ���ݱ� Schema Name
        /// </summary>
        public static class TableSchemaName
        {
            public const string ABP = "ABP";

            public const string CloudBookList = "CBL";
        }

        /// <summary>
        /// ���ݱ� PreFix Name
        /// </summary>
        public static class TablePreFixName
        {
            public const string ABP = "";

            public const string CloudBookList = "";
        }
    }
}
