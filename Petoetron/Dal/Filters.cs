using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petoetron.Dal
{
    public class FilterValue
    {
        public string Code { get; set; }
        public object Value { get; set; }

        public FilterValue(string code, object value)
        {
            Code = code;
            Value = value;
        }
    }
    
    public class Filter
    {
        private string code;
        private List<FilterValue> filters = new List<FilterValue>();

        public void AddFilter(FilterValue filter)
        {
            filters.Add(filter);
        }

        public Filter(string code)
        {
            this.code = code;
        }
        
        public string Code
        {
            get { return code ?? ""; }
            set { code = value; }
        }
        
        public List<FilterValue> Filters
        {
            get { return filters; }
            protected set { filters = value; }
        }
    }
}
