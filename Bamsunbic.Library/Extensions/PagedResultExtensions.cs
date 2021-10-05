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
            var endPage = (int)(Math.Ceiling(decimal.Divide(page, pageSize)) * pageSize);
            var startPage = (endPage - pageSize) + 1;
            var pageCount = (int)Math.Ceiling(decimal.Divide(query.Count(), pageSize));
            var skip = (page - 1) * pageSize;

            var result = new PagedResult<T>
            {
                CurrentPage = page,
                PageSize = pageSize,
                PageCount = pageCount,
                RowCount = query.Count(),
                RowNumber = (query.Count() - ((page - 1) * pageSize)),
                StartPage = startPage,
                EndPage = endPage,
                Results = query.Skip(skip).Take(pageSize).ToList()
            };

            if (endPage > pageCount)
            {
                result.EndPage = pageCount;
            }

            return result;
        }

        public static async Task<PagedResult<T>> GetPagedAsync<T>(this IQueryable<T> query, int page, int pageSize) where T : class
        {
            var endPage = (int)(Math.Ceiling(decimal.Divide(page, pageSize)) * pageSize);
            var startPage = (endPage - pageSize) + 1;
            var pageCount = (int)Math.Ceiling(decimal.Divide(query.Count(), pageSize));
            var skip = (page - 1) * pageSize;

            var result = new PagedResult<T>
            {
                CurrentPage = page,
                PageSize = pageSize,
                PageCount = pageCount,
                RowCount = query.Count(),
                RowNumber = (query.Count() - ((page - 1) * pageSize)),
                StartPage = startPage,
                EndPage = endPage,
                Results = await query.Skip(skip).Take(pageSize).ToListAsync()
            };

            if (endPage > pageCount)
            {
                result.EndPage = pageCount;
            }

            return result;
        }
    }
}
