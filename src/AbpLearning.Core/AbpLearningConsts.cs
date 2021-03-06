namespace AbpLearning.Core
{
    public static class AbpLearningConsts
    {
        public const string LocalizationSourceName = "AbpLearning";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;

        /// <summary>
        /// 分页模型中，返回的默认数量
        /// </summary>
        public const int DefaultResultCount = 10;

        /// <summary>
        /// 分页模型中，返回的最大数量
        /// </summary>
        public const int MaxResultCount = 100;

        /// <summary>
        /// 数据表 Schema Name
        /// </summary>
        public static class TableSchemaName
        {
            public const string ABP = "ABP";

            public const string CloudBookList = "CBL";

            public const string File = "FILE";
        }

        /// <summary>
        /// 数据表 PreFix Name
        /// </summary>
        public static class TablePreFixName
        {
            public const string ABP = "";

            public const string CloudBookList = "";

            public const string File = "";
        }
    }
}
