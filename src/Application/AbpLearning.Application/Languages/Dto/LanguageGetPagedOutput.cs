namespace AbpLearning.Application.Languages.Dto
{
    using Abp.Application.Services.Dto;

    public class LanguageGetPagedOutput : ListResultDto<LanguagePagedDto>
    {
        /// <summary>
        /// Ĭ������
        /// </summary>
        public string DefaultLanguageName { get; set; }
    }
}
