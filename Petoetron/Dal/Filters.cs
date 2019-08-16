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

    public class FilterPool
    {
        public static Filter Create(string code)
        {
            return new Filter(code);
        }

        public static Filter Create(string code, string valueName, object value)
        {
            Filter filter = Create(code);
            filter.AddFilter(new FilterValue(valueName, value));
            return filter;
        }

        public static Filter ByIdFilter(long id)
        {
            return Create("ById", "id", id);
        }

        public static Filter BetweenFilter(DateTime from, DateTime till)
        {
            Filter filter = Create("Between");
            filter.AddFilter(new FilterValue("fromDate", from));
            filter.AddFilter(new FilterValue("tillDate", till));
            return filter;
        }

        public static Filter ModifiedAfterFilter(DateTime after)
        {
            Filter filter = Create("ModifiedAfter");
            filter.AddFilter(new FilterValue("lastUpdate", after));
            return filter;
        }

        public static Filter DeletedAfterFilter(DateTime after)
        {
            Filter filter = Create("DeletedAfter");
            filter.AddFilter(new FilterValue("deletedAfter", after));
            return filter;
        }

        public static Filter LimitFilter(int limit)
        {
            return Create("Limit", "count", limit);
        }

        public static Filter FindRegistrations(long jobOperationId)
        {
            return Create("FindRegistrations", "id", jobOperationId);
        }

        public static Filter FindJobInputValues(long jobOperationId)
        {
            return Create("FindJobInputValues", "id", jobOperationId);
        }

        public static Filter FindJobOperations(DateTime fromDate, DateTime tillDate)
        {
            Filter filter = Create("FindJobOperations");
            filter.AddFilter(new FilterValue("fromDate", fromDate));
            filter.AddFilter(new FilterValue("tillDate", tillDate));
            // TODO other stuff
            return filter;
        }

        public static Filter FindJobOperations(List<long> ids)
        {
            Filter filter = Create("ByJobIds");

            string values = string.Join(",", ids);

            filter.AddFilter(new FilterValue("jobIds", values));
            return filter;
        }

        public static Filter MessageState(long id)
        {
            return Create("GetState", "mId", id);
        }
    }
}
