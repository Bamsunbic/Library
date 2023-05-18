using System.Collections.Generic;

namespace Bamsunbic.Library.Models.Paged
{
    public class PagedResult<T> 
    {
        public PagedResult()
        {
            PagedResults = new List<T>();
        }
        
        public PagedOption PagedOption { get; set; }
        public IList<T> PagedResults { get; set; }
    }
}