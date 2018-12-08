﻿namespace AbpLearning.Application.CloudBookList.Book
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Dynamic.Core;
    using System.Threading.Tasks;
    using Abp.Application.Services.Dto;
    using Abp.Authorization;
    using Abp.AutoMapper;
    using Abp.Extensions;
    using Abp.Linq.Extensions;
    using AbpLearning.Core.CloudBookList.Books.DomainService;
    using AbpLearning.Core.CloudBookList.Relationships.DomainService;
    using Core;
    using Microsoft.EntityFrameworkCore;
    using Model;

    /// <summary>
    /// 书籍 应用服务
    /// </summary>
    [AbpAuthorize(AbpLearningPermissions.BOOK_NODE)]
    public class BookAppService : AbpLearningAppServiceBase, IBookAppService
    {
        private readonly IBookDomainService _bookDomainService;

        private readonly IBookAndBookTagRelationshipDomainService _bookAndBookTagRelationshipDomainService;

        private readonly IBookListAndBookRelationshipDomainService _bookListAndBookRelationshipDomainService;

        public BookAppService(
            IBookDomainService bookDomainService,
            IBookAndBookTagRelationshipDomainService bookAndBookTagRelationshipDomainService,
            IBookListAndBookRelationshipDomainService bookListAndBookRelationshipDomainService)
        {
            _bookDomainService = bookDomainService;
            _bookAndBookTagRelationshipDomainService = bookAndBookTagRelationshipDomainService;
            _bookListAndBookRelationshipDomainService = bookListAndBookRelationshipDomainService;
        }

        [AbpAuthorize(AbpLearningPermissions.BOOK_NODE + AbpLearningPermissions.BATCHD_DELETE)]
        public async Task BatchDeleteAsync(List<long> bookIds)
        {
            await _bookAndBookTagRelationshipDomainService.DeleteByBookIdAsync(bookIds);
            await _bookListAndBookRelationshipDomainService.DeleteByBookIdAsync(bookIds);
            await _bookDomainService.BatchDeleteAsync(bookIds);
        }

        public Task CreateOrUpdateAsync(BookEditModel entity)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteAsync(EntityDto<long> entity)
        {
            throw new System.NotImplementedException();
        }

        public Task<BookViewModel> GetAsync(EntityDto<long> model)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 分页
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        [AbpAuthorize(AbpLearningPermissions.BOOK_NODE + AbpLearningPermissions.QUERY)]
        public async Task<PagedResultDto<BookPagedModel>> GetPagedAsync(BookPagedFilterAndSortedModel filter)
        {
            var query = _bookDomainService.GetAll()
                .WhereIf(!filter.Name.IsNullOrWhiteSpace(), m => m.Name.Contains(filter.Name));

            var count = await query.CountAsync();

            var entityList = await query.OrderBy(filter.Sorting).PageBy(filter).ToListAsync();

            var entityListDto = entityList.MapTo<List<BookPagedModel>>();

            // 租户数据过滤
            if (!AbpSession.TenantId.HasValue)
            {

            }

            return new PagedResultDto<BookPagedModel>(count, entityListDto);
        }
    }
}