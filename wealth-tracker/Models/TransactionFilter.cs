using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wealth_tracker.Models
{
    public class TransactionFilter
    {
        public string? SearchText { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public TransactionType? Type { get; set; }

        public TransactionFilter() { }

        public TransactionFilter (string? searchText = null, DateTime? dateFrom = null, DateTime? dateTo = null, TransactionType? type = null)
        {
            SearchText = searchText;
            DateFrom = dateFrom;
            DateTo = dateTo;
            Type = type;
        }
    }
}
