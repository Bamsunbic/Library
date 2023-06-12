namespace Bamsunbic.Library.Models.Paged
{
    public class PagedOption
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

        /// <summary>
        /// 총 페이지 개수
        /// </summary>
        public int PageCount { get; set; }

        /// <summary>
        /// 한 페이지당 보여질 게시글의 개수
        /// </summary>
        public int PageSize { get; set; }

        /// <summary>
        /// 총 행 개수
        /// </summary>
        public int RowCount { get; set; }

        /// <summary>
        /// 행 번호
        /// </summary>
        public int RowNumber { get; set; }

        /// <summary>
        /// 이전 버튼 활성화 유무
        /// </summary>
        public bool IsShowPrevious => CurrentPage > 1;
        
        /// <summary>
        /// 다음 버튼 활성화 유무
        /// </summary>
        public bool IsShowNext => CurrentPage < PageCount;

        /// <summary>
        /// 처음 버튼 활성화 유무
        /// </summary>
        public bool IsShowFirst => CurrentPage > 1;
        
        /// <summary>
        /// 마지막 버튼 활성화 유무
        /// </summary>
        public bool IsShowLast => CurrentPage < PageCount;

    }
}