﻿using Bamsunbic.Library.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bamsunbic.Library.Extensions
{
    /// <summary>
    /// 페이징 확장 클래스
    /// </summary>
	public static class PagedResultExtensions
	{
        public static PagedResult<T> GetPaged<T>(this IQueryable<T> query, int page, int pageSize) where T : class
        {
            var endPage = (int)(Math.Ceiling(decimal.Divide(page, pageSize)) * pageSize);
            var startPage = (endPage - pageSize) + 1;

            var result = new PagedResult<T>
            {
                CurrentPage = page,
                PageSize = pageSize,
                RowCount = query.Count(),
                StartPage = startPage,
                EndPage = endPage
            };

            var pageCount = (double)result.RowCount / pageSize;
            result.PageCount = (int)Math.Ceiling(pageCount);

            var skip = (page - 1) * pageSize;
            result.Results = query.Skip(skip).Take(pageSize).ToList();

            return result;
        }
    }
}
