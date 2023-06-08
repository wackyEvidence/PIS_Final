using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Sort
    {
        public Sort(string field, SortOrder order)
        {
            Field = field; 
            Order = order;
        }

        public string Field { get; set; }
        public SortOrder Order { get; set; }
    }
}
