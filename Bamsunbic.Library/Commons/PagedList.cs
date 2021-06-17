using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bamsunbic.Library.Commons
{
    /// <summary>
    /// 페이징 클래스
    /// </summary>
    public class PagedList<T> : List<T>
    {
        public PagedList(List<T> items, int count, int currentPage, int pageSize)
        {
            var endPage = (int)(Math.Ceiling(decimal.Divide(currentPage, pageSize)) * pageSize);
            var startPage = (endPage - pageSize) + 1;

            var totalPage = (int)Math.Ceiling(decimal.Divide(count, pageSize));
            if (endPage > totalPage)
            {
                endPage = totalPage;
            }

            StartPage = startPage;
            EndPage = endPage;
            TotalCount = count;
            PageSize = pageSize;
            CurrentPage = currentPage;
            PagedData = items;
        }

        /// <summary>
        /// 게시글의 총 개수
        /// </summary>
        public int TotalCount { get; }

        /// <summary>
        /// 한 페이지당 보여질 게시글의 개수
        /// </summary>
        public int PageSize { get; }

        /// <summary>
        /// 현재 페이지 번호
        /// </summary>
        public int CurrentPage { get; }

        /// <summary>
        /// 시작 페이지 번호
        /// </summary>
        public int StartPage { get; }

        /// <summary>
        /// 마지막 페이지 번호
        /// </summary>
        public int EndPage { get; }

        /// <summary>
        /// 하단 페이지 번호 총 개수
        /// </summary>
        public int TotalPages => (int)Math.Ceiling(decimal.Divide(TotalCount, PageSize));

        /// <summary>
        /// 현재 페이지가 첫번째 페이지인지 유무 판단
        /// </summary>
        public bool IsShowPrevious => CurrentPage > 1;

        /// <summary>
        /// 현재 페이지가 마지막 페이지인지 유무 판단
        /// </summary>
        public bool IsShowLast => CurrentPage != TotalPages;

        /// <summary>
        /// 현재 페이지가 총 페이지 수보다 적으면 다음 버튼 노출
        /// </summary>
        public bool IsShowNext => CurrentPage < TotalPages;

        /// <summary>
        /// 현재 페이지가 첫번째 페이지가 아니면 처음 버튼 노출
        /// </summary>
        public bool IsShowFirst => CurrentPage != 1;

        /// <summary>
        /// 페이징된 게시글의 목록
        /// </summary>
        public List<T> PagedData { get; }
    }
}
