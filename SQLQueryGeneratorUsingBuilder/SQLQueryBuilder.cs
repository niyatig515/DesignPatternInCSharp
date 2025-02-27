using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuilderPattern;

namespace SQLQueryGeneratorUsingBuilder
{
    public class SqlQueryBuilder : IQueryBuilder
    {
        private readonly SQLQuery _query;

        public SqlQueryBuilder()
        {
            _query = new SQLQuery();
        }

        public IQueryBuilder Select(params string[] columns)
        {
            _query.Columns.AddRange(columns);
            return this;
        }

        public IQueryBuilder From(string tableName)
        {
            _query.Table = tableName;
            return this;
        }

        public IQueryBuilder Where(string condition)
        {
            _query.Conditions.Add(condition);
            return this;
        }

        public IQueryBuilder OrderBy(string column, string order = "ASC")
        {
            _query.OrderByColumn = column;
            _query.OrderByDirection = order;
            return this;
        }

        public IQueryBuilder Limit(int count)
        {
            _query.Limit = count;
            return this;
        }

        public string Build()
        {
            if (string.IsNullOrEmpty(_query.Table))
                throw new InvalidOperationException("Table name is required.");

            StringBuilder sql = new StringBuilder();

            // SELECT clause
            string columns = _query.Columns.Count > 0 ? string.Join(", ", _query.Columns) : "*";
            sql.Append($"SELECT {columns} FROM {_query.Table}");

            // WHERE clause
            if (_query.Conditions.Any())
                sql.Append(" WHERE " + string.Join(" AND ", _query.Conditions));

            // ORDER BY clause
            if (!string.IsNullOrEmpty(_query.OrderByColumn))
                sql.Append($" ORDER BY {_query.OrderByColumn} {_query.OrderByDirection}");

            // LIMIT clause
            if (_query.Limit.HasValue)
                sql.Append($" LIMIT {_query.Limit.Value}");

            sql.Append(";"); // End of query

            return sql.ToString();
        }
    }
}
