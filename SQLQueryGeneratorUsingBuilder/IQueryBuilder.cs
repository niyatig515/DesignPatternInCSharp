using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLQueryGeneratorUsingBuilder
{
    public interface IQueryBuilder
    {
        IQueryBuilder Select(params string[] columns);
        IQueryBuilder From(string tableName);
        IQueryBuilder Where(string condition);
        IQueryBuilder OrderBy(string column, string order = "ASC");
        IQueryBuilder Limit(int count);
        string Build();
    }
}
