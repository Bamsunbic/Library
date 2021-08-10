using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bamsunbic.Library.Commons
{
    public class PagedResult<T> : PagedResultBase where T : class
    {
        public PagedResult()
        {
            Results = new List<T>();
        }

        public IList<T> Results { get; set; }
    }

    public abstract class PagedResultBase
    {
        /// <summary>
        /// 현재 페이지 번호
        /// </summary>
        public int CurrentPage { get; set; }

        /// <summary>
        /// 시작 페이지 번호
        /// </summary>
        public int StartPage { get; set; }

        /// <summary>
        /// 마지막 페이지 번호
        /// </summary>
        public int EndPage { get; set; }

        public int PageCount { get; set; }

        /// <summary>
        /// 한 페이지당 보여질 게시글의 개수
        /// </summary>
        public int PageSize { get; set; }

        /// <summary>
        /// 총 개수
        /// </summary>
        public int RowCount { get; set; }

        /// <summary>
        /// 현재 페이지가 첫번째 페이지인지 유무 판단
        /// </summary>
        public bool IsShowPrevious => CurrentPage > 1;

        /// <summary>
        /// 현재 페이지가 마지막 페이지인지 유무 판단
        /// </summary>
        public bool IsShowLast => CurrentPage != RowCount;

        /// <summary>
        /// 현재 페이지가 총 페이지 수보다 적으면 다음 버튼 노출
        /// </summary>
        public bool IsShowNext => CurrentPage < RowCount;

        /// <summary>
        /// 현재 페이지가 첫번째 페이지가 아니면 처음 버튼 노출
        /// </summary>
        public bool IsShowFirst => CurrentPage != 1;
    }
}
