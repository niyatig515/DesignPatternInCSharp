using System;
using SQLQueryGeneratorUsingBuilder;

class Program
{
    static void Main()
    {
        IQueryBuilder queryBuilder = new SqlQueryBuilder();

        string query1 = queryBuilder
                        .Select("Id", "Name", "Age")
                        .From("Students")
                        .Where("Age > 18")
                        .OrderBy("Name", "DESC")
                        .Limit(10)
                        .Build();

        Console.WriteLine("Generated SQL Query 1:");
        Console.WriteLine(query1);

        // Another query example
        string query2 = new SqlQueryBuilder()
                        .Select("Name", "Salary")
                        .From("Employees")
                        .Where("Department = 'IT'")
                        .Where("Salary > 50000")
                        .Build();

        Console.WriteLine("\nGenerated SQL Query 2:");
        Console.WriteLine(query2);
    }
}
