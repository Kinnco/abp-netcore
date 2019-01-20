namespace AbpLearning.Application.Roles
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Abp.Application.Services;
    using Abp.Application.Services.Dto;
    using Model;

    public interface IRoleAppService<TPrimaryKey> : IApplicationService
    where TPrimaryKey: struct
    {
        /// <summary>
        /// ����Ȩ��
        /// </summary>
        /// <returns></returns>
        Task<ListResultDto<PermissionViewModel>> GetAllPermissions();

        /// <summary>
        /// ��ҳ
        /// </summary>
        /// <param name="filter">��ҳ����ģ��</param>
        /// <returns></returns>
        Task<PagedResultDto<RolePagedModel>> GetPaged(RolePagedFilteringModel filter);

        /// <summary>
        /// ��ȡ����
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<RoleEditModel> GetEdit(NullableIdDto<TPrimaryKey> entity);

        /// <summary>
        /// ����
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task Create(RoleEditModel input);

        /// <summary>
        /// ����
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task Update(RoleEditModel input);

        /// <summary>
        /// ���½�ɫȨ��
        /// </summary>
        /// <returns></returns>
        Task UpdatePermissionsForRole(PermissionEditModel model);

        /// <summary>
        /// ɾ��
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task Delete(EntityDto<TPrimaryKey> input);

        /// <summary>
        /// ����ɾ��
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        Task BatchDelete(List<EntityDto<TPrimaryKey>> entities);
    }
}
