using System.Collections.Generic;

namespace Microservice.Core.Models.Response
{
    public class Pagination<T>
    {
        public Pagination(List<T> items, int totalRecord)
        {
            Items = items;
            TotalRecord = totalRecord;
        }
        public Pagination()
        {

        }
        public List<T> Items { get; set; }
        public int TotalRecord { get; set; }
    }

}
