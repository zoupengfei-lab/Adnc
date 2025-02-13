﻿using Adnc.Infra.Entities;
using System;
using System.Linq.Expressions;

namespace Adnc.Infra.IRepositories
{
    public static class RepositoryExtentions
    {
        public static Expression<Func<TEntity, object>>[] GetExpressions<TEntity>(this IEfRepository<TEntity> _, params Expression<Func<TEntity, object>>[] expressions)
        where TEntity : EfEntity
            => expressions;
    }
}