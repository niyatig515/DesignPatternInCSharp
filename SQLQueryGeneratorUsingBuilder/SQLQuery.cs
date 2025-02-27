using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class SQLQuery
    {
        public string Table { get; set; }
        public List<string> Columns { get; set; } = new List<string>();
        public List<string> Conditions { get; set; } = new List<string>();
        public string OrderByColumn { get; set; }
        public string OrderByDirection { get; set; }
        public int? Limit { get; set; }


    }

}