using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Filter
    {
        public Filter(string field, string value)
        {
            Field = field;
            Value = value;
        }

        public string Field { get; set; }
        public string Value { get; set; }
    }
}
