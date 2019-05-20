namespace AbpLearning.Application.Languages.Dto
{
    using System.ComponentModel.DataAnnotations;
    using Abp.Extensions;
    using Abp.Localization;
    using AbpLearning.Application.Base;
    using AbpLearning.Core;

    /// <summary>
    /// �����ı���ҳ ����ģ��
    /// </summary>
    public class LanguageTextGetPagedInput : PagedFilteringDtoBase
    {
        /// <summary>
        /// ���ػ�
        /// </summary>
        [MaxLength(ApplicationLanguageText.MaxSourceNameLength)]
        public string SourceName { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        [StringLength(maximumLength:ApplicationLanguage.MaxNameLength)]
        public string LanguageName { get; set; }

        /// <summary>
        /// �Ա�����
        /// </summary>
        [StringLength(maximumLength: ApplicationLanguage.MaxNameLength)]
        public string ContrastLanguageName { get; set; }

        /// <summary>
        /// ֵ���� ����
        /// </summary>
        public LanguageTextFilterTypeEnum LanguageTextFilterType { get; set; }

        public override void Normalize()
        {
            if (Sorting.IsNullOrEmpty())
            {
                Sorting = "Key ASC";
            }

            if (SourceName.IsNullOrEmpty())
            {
                SourceName = AbpLearningCoreConfig.LOCALIZATION_SOURCE_NAME;
            }

            if (LanguageName.IsNullOrEmpty())
            {
                LanguageName = "zh-Hans";
            }

            if (ContrastLanguageName.IsNullOrEmpty())
            {
                ContrastLanguageName = "en";
            }
        }

        /// <summary>
        /// ֵ���� ����
        /// </summary>
        public enum LanguageTextFilterTypeEnum
        {
            /// <summary>
            /// ȫ��
            /// </summary>
            All = 1,

            /// <summary>
            /// Ϊ��
            /// </summary>
            Empty
        }
    }
}
