﻿using NetCore.Core.Utils;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NetCore.Core.Caching.Interface
{
    public interface ICacheAppService
    {
        T Execute<T>(Expression<Func<T>> func, int cachedInMinutes, params object[] args);
        Task<T> ExecuteAsync<T>(Expression<Func<Task<T>>> func, int cachedInMinutes = -1, params object[] args);
        void Remove<T>(Expression<Func<T>> func, params object[] args);
        Task RemoveAsync<T>(Expression<Func<T>> func, params object[] args);
    }
}