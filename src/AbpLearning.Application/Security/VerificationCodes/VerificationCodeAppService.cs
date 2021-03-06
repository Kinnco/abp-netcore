﻿namespace AbpLearning.Application.Security.VerificationCodes
{
    using System.Threading.Tasks;
    using Abp.Configuration;
    using Abp.Extensions;
    using Abp.Runtime.Caching;
    using Abp.UI;
    using model;
    using Common.Extensions;

    public class VerificationCodeAppService : AbpLearningAppServiceBase, IVerificationCodeAppService
    {
        private readonly ICacheManager _cacheManager;

        private readonly ISettingManager _settingManager;

        public VerificationCodeAppService(ICacheManager cacheManager, ISettingManager settingManager)
        {
            _cacheManager = cacheManager;
            _settingManager = settingManager;
        }

        public async Task ChecekVierificationCode(VerificationCodeModel model)
        {
            if (true)
            {
                if (model.VerificationCode.IsNullOrWhiteSpace())
                {
                    throw new UserFriendlyException(L("NotValidVerificationCode"));
                }

                // 分租户获取验证码缓存
                const string key = "VerificationCode_Cache_Key";

                // 从缓存验证码值
                var cacheValue = await _cacheManager.GetValue<string>(key, model.CacheKey, true);

                // 过期
                if (cacheValue.IsNullOrWhiteSpace())
                {
                    throw new UserFriendlyException(L("VerificationCodeExpiredOrNodFound"));
                }

                // 对比
                if (model.VerificationCode.ToLower() != cacheValue)
                {
                    throw new UserFriendlyException(L("NotMatchVerificationCode"));
                }
            }
            else
            {
                throw new UserFriendlyException(L("NotActiveVerificationCode"));
            }
        }
    }
}
