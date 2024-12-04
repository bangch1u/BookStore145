using System;
using System.Collections.Generic;
using System.Linq;

namespace BookData.ViewModels
{
    public class PaginatedList<T> : List<T>
    {
        public int PageIndex { get; private set; }
        public int TotalPages { get; private set; }
        public int PageSize { get; private set; }
        public int TotalCount { get; private set; }

       
        public PaginatedList(List<T> items, int count, int pageIndex, int pageSize)
        {
            TotalCount = count;
            PageSize = pageSize;
            TotalPages = (int)Math.Ceiling(count / (double)pageSize);
            PageIndex = (pageIndex < 1 || pageIndex > TotalPages) ? 1 : pageIndex; 
            AddRange(items);
        }

       
        public static PaginatedList<T> Create(IList<T> source, int pageIndex, int pageSize)
        {
            var count = source.Count();
       
            pageIndex = (pageIndex < 1 || pageIndex > (int)Math.Ceiling(count / (double)pageSize)) ? 1 : pageIndex;

           
            var items = source.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();

            return new PaginatedList<T>(items, count, pageIndex, pageSize);
        }
    }
}
