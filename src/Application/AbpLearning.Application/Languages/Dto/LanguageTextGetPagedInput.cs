namespace AbpLearning.Application.Languages.Dto
{
    using System.ComponentModel.DataAnnotations;
    using Abp.Extensions;
    using Abp.Localization;
    using AbpLearning.Application.Base;

    /// <summary>
    /// �����ı���ҳ ����ģ��
    /// </summary>
    public class LanguageTextGetPagedInput : PagedFilteringDtoBase
    {
        /// <summary>
        /// ���ػ�
        /// </summary>
        [Required]
        [MaxLength(ApplicationLanguageText.MaxSourceNameLength)]
        public string SourceName { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        [Required]
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
        public TargetValueFilterEnum TargetValueFilter { get; set; }

        public override void Normalize()
        {
            if (Sorting.IsNullOrEmpty())
            {
                Sorting = "Key ASC";
            }
        }

        /// <summary>
        /// ֵ���� ����
        /// </summary>
        public enum TargetValueFilterEnum
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
