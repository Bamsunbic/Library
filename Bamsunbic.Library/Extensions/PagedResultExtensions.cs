using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using Bamsunbic.Library.Models.Paged;

namespace Bamsunbic.Library.Extensions;

/// <summary>
/// 페이징 확장 클래스
/// </summary>
public static class PagedResultExtensions
{
    public static PagedResult<T> GetPaged<T>(this IQueryable<T> query, int page, int pageSize) where T : class
    {
        if (page < 0)
        {
            throw new Exception("page 번호는 0보다 커야 됩니다.");
        }

        var endPage = (int)(Math.Ceiling(decimal.Divide(page, pageSize)) * pageSize);
        var startPage = (endPage - pageSize) + 1;
        var pageCount = (int)Math.Ceiling(decimal.Divide(query.Count(), pageSize));
        var skip = (page - 1) * pageSize;

        var rowCount = query.Count();
        var rowNumber = rowCount - ((page - 1) * pageSize);
        if (rowNumber < 1)
        {
            rowNumber = 0;
        }

        var pagedOption = new PagedOption
        {
            CurrentPage = page,
            PageSize = pageSize,
            PageCount = pageCount,
            RowCount = rowCount,
            RowNumber = rowNumber,
            StartPage = startPage,
            EndPage = endPage
        };

        var result = new PagedResult<T>
        {
            PagedOption = pagedOption,
            PagedResults = query.Skip(skip).Take(pageSize).ToList()
        };

        if (endPage > pageCount)
        {
            result.PagedOption.EndPage = pageCount;
        }

        return result;
    }

    public static async Task<PagedResult<T>> GetPagedAsync<T>(this IQueryable<T> query, int page, int pageSize)
        where T : class
    {
        if (page < 0)
        {
            throw new Exception("page 번호는 0보다 커야 됩니다.");
        }
        
        var endPage = (int)(Math.Ceiling(decimal.Divide(page, pageSize)) * pageSize);
        var startPage = (endPage - pageSize) + 1;
        var pageCount = (int)Math.Ceiling(decimal.Divide(query.Count(), pageSize));
        var skip = (page - 1) * pageSize;

        var rowCount = query.Count();
        var rowNumber = rowCount - ((page - 1) * pageSize);
        if (rowNumber < 1)
        {
            rowNumber = 0;
        }

        var pagedOption = new PagedOption
        {
            CurrentPage = page,
            PageSize = pageSize,
            PageCount = pageCount,
            RowCount = rowCount,
            RowNumber = rowNumber,
            StartPage = startPage,
            EndPage = endPage
        };

        var result = new PagedResult<T>
        {
            PagedOption = pagedOption,
            PagedResults = await query.Skip(skip).Take(pageSize).ToListAsync()
        };

        if (endPage > pageCount)
        {
            result.PagedOption.EndPage = pageCount;
        }

        return result;
    }
}