using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using NetCore.Core.Caching.Interface;
using NetCore.Core.Utils;
using NetCore.DataProcess.EntitiFramework;
using NetCore.DataProcess.Infrastructure.Interfaces;
using NetCore.Models;
using NLog.Filters;
using SV.QTHT.Core;
using System.Collections.Generic;
using static NetCore.Core.Utils.Constant;

namespace ATS_QTHT_Service.CRM.Logic
{
    public class DbUserHandler : IDbUserHandler
    {
        private readonly ILogger<DbUserHandler> _logger;

        private readonly LOYALTYContext _dataContext;
        private readonly ICached _cached;
        private readonly IDapperUnitOfWork _dapperUnitOfWork;
        private readonly IDapperReposity _dal;
        public DbUserHandler(ILogger<DbUserHandler> logger, IDapperUnitOfWork dapperUnitOfWork, LOYALTYContext dataContext, ICached cached)
        {
            _logger = logger;
            _dataContext = dataContext;
            _cached = cached;
            _dapperUnitOfWork = dapperUnitOfWork;
            _dal = _dapperUnitOfWork.GetRepository();
        }
        /// <summary>
        /// GetUser
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<Response<List<User>>> GetUser(FilterBase request)
        {
            try
            {
                // lấy ở cache theo param
                var lstUsers = await _cached.GetAsync<List<User>>(NewtonJson.Serialize(request));
                if(lstUsers != null)
                {
                    return new Response<List<User>>(Constant.ErrorCode.SUCCESS_CODE, Constant.ErrorCode.SUCCESS_MESS, lstUsers);
                }
                var data = (from item in _dataContext.Users
                            select new User()
                            {
                                id = item.id,
                                full_name = item.full_name,
                                username = item.username,
                                address = item.address,
                                date_created = item.date_created

                            }); ;
                if (!string.IsNullOrEmpty(request.TextSearch))
                {
                    data.Where(x => x.username.Contains(request.TextSearch) || x.full_name.Contains(request.TextSearch));
                }
                data = data.OrderByField(request.PropertyName, request.Ascending);
                var totalCount = data.Count();
                // Pagination
                if (request.PageSize.HasValue && request.PageNumber.HasValue)
                {
                    if (request.PageSize <= 0)
                    {
                        request.PageSize = NetCore.Core.Utils.Constant.SignatureConstant.QueryFilter.DefaultPageSize;
                    }
                    int excludedRows = (request.PageNumber.Value - 1) * (request.PageSize.Value);
                    if (excludedRows <= 0)
                    {
                        excludedRows = 0;
                    }
                    data = data.Skip(excludedRows).Take(request.PageSize.Value);
                }
                var dataCount = data.Count();
                var lst = await data.ToListAsync();
                int totalPage = (int)Math.Ceiling((decimal)totalCount / request.PageSize.Value);
                await _cached.AddAsync(NewtonJson.Serialize(request), lst);

                return new Response<List<User>>(Constant.ErrorCode.SUCCESS_CODE, Constant.ErrorCode.SUCCESS_MESS, lst, dataCount, totalCount, totalPage, request.PageNumber ?? 0, request.PageSize ?? 0);

            }
            catch (Exception e)
            {
                _logger.LogError(e, e.Message);
                return new Response<List<User>>(Constant.ErrorCode.SUCCESS_CODE, Constant.ErrorCode.SUCCESS_MESS, null);
            }
        }


        public async Task<Response<List<User>>> GetUserByDapper(FilterBase request)
        {
            try
            {
                string sqlQuery = JSONObject.GetQueryFromJSON(SqlDapper.FileName.GetSystemQueryFile(), SqlDapper.Query.System.Users.SUB, SqlDapper.Query.System.Users.GET_ALL);

                var user = await _dal.QueryAsync<User>(sqlQuery);

                return new Response<List<User>>(Constant.ErrorCode.SUCCESS_CODE, Constant.ErrorCode.SUCCESS_MESS, null);

            }
            catch (Exception ex)
            {

                _logger.LogError(ex, ex.Message);
                return new Response<List<User>>(Constant.ErrorCode.SUCCESS_CODE, Constant.ErrorCode.SUCCESS_MESS, null);
            }
        }
    }
}
