namespace AbpLearning.Core.Authorization
{
    using Abp.Authorization;
    using Abp.Localization;
    using Abp.MultiTenancy;

    public class AbpLearningAuthorizationProvider : AuthorizationProvider
    {
        public override void SetPermissions(IPermissionDefinitionContext context)
        {
            // pages
            var pages = context.CreatePermission(AbpLearningPermissions.Pages, L("Pages"), L("Pages Description"));

            #region system

            var system = pages.CreateChildPermission(AbpLearningPermissions.System, L("System"), L("System Description"));

            var user = system.CreateChildPermission(AbpLearningPermissions.User, L("User"), L("User Description"));
            user.CreateChildPermission(AbpLearningPermissions.User + AbpLearningPermissions.Action.Query, L("User Query"), L("User Query Description"));
            user.CreateChildPermission(AbpLearningPermissions.User + AbpLearningPermissions.Action.Create, L("User Create"), L("User Create Description"));
            user.CreateChildPermission(AbpLearningPermissions.User + AbpLearningPermissions.Action.Update, L("User Update"), L("User Update Description"));
            user.CreateChildPermission(AbpLearningPermissions.User + AbpLearningPermissions.Action.Delete, L("User Delete"), L("User Delete Description"));
            user.CreateChildPermission(AbpLearningPermissions.User + AbpLearningPermissions.Action.BatchdDelete, L("User BatchDelete"), L("User BatchDelete Description"));

            var role = system.CreateChildPermission(AbpLearningPermissions.Role, L("Role"));
            role.CreateChildPermission(AbpLearningPermissions.Role + AbpLearningPermissions.Action.Query, L("Role Query"), L("User Query Description"));
            role.CreateChildPermission(AbpLearningPermissions.Role + AbpLearningPermissions.Action.Create, L("Role Create"), L("User Create Description"));
            role.CreateChildPermission(AbpLearningPermissions.Role + AbpLearningPermissions.Action.Update, L("Role Update"), L("User Update Description"));
            role.CreateChildPermission(AbpLearningPermissions.Role + AbpLearningPermissions.Action.Delete, L("Role Delete"), L("User Delete Description"));
            role.CreateChildPermission(AbpLearningPermissions.Role + AbpLearningPermissions.Action.BatchdDelete, L("Role BatchDelete"), L("User BatchDelete Description"));

            var tenant = system.CreateChildPermission(AbpLearningPermissions.Tenant, L("Tenant"), L("Tenant Description"), multiTenancySides: MultiTenancySides.Host);

            var auditlog = system.CreateChildPermission(AbpLearningPermissions.AuditLog, L("AuditLog"), L("AuditLog Description"));

            #endregion
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, AbpLearningConsts.LocalizationSourceName);
        }
    }
}
