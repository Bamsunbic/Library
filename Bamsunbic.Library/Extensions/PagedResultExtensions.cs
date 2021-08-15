using Bamsunbic.Library.Commons;
using Microsoft.EntityFrameworkCore;
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
            var result = new PagedResult<T>();
            result.CurrentPage = page;
            result.PageSize = pageSize;
            result.RowCount = query.Count();

            var endPage = (int)(Math.Ceiling(decimal.Divide(page, pageSize)) * pageSize);
            var startPage = (endPage - pageSize) + 1;
            result.StartPage = startPage;
            result.EndPage = endPage;

            var pageCount = (int)Math.Ceiling(decimal.Divide(query.Count(), pageSize));
            result.PageCount = pageCount;

            if (endPage > pageCount) 
            {
                result.EndPage = pageCount;
            }

            var skip = (page - 1) * pageSize;
            result.Results = query.Skip(skip).Take(pageSize).ToList();

            return result;
        }

        public static async Task<PagedResult<T>> GetPagedAsync<T>(this IQueryable<T> query, int page, int pageSize) where T : class
        {
            var result = new PagedResult<T>();
            result.CurrentPage = page;
            result.PageSize = pageSize;
            result.RowCount = query.Count();

            var endPage = (int)(Math.Ceiling(decimal.Divide(page, pageSize)) * pageSize);
            var startPage = (endPage - pageSize) + 1;
            result.StartPage = startPage;
            result.EndPage = endPage;

            var pageCount = (int)Math.Ceiling(decimal.Divide(query.Count(), pageSize));
            result.PageCount = pageCount;

            if (endPage > pageCount)
            {
                result.EndPage = pageCount;
            }

            var skip = (page - 1) * pageSize;
            result.Results = await query.Skip(skip).Take(pageSize).ToListAsync();

            return result;
        }
    }
}
