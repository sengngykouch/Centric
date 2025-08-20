using System.Collections.Immutable;
using Microsoft.Data.SqlClient;

using Dapper;
using Centric.Backend.Domain.Model.Budget;

namespace Centric.Backend.Domain.Persistance.Queries;

public static class BudgetQuery
{
    public static async Task<ImmutableList<QueryResult>> Get(string conectionString)
    {
        var connection = new SqlConnection(conectionString);
        var budget = await connection.QueryAsync<QueryResult>("SELECT * FROM [Centric].[dbo].[Budget]");

        return [.. budget];
    }

    public static async Task<int> Add(string connectionString, BudgetRequest request)
    {
        var connection = new SqlConnection(connectionString);
        var sql = "INSERT INTO [Centric].dbo.[Budget] (UserId, Amount, StartDate, EndDate) VALUES (@UserId, @Amount, @StartDate @EndDate)";

        return await connection.ExecuteAsync(sql, request);
    }

    public record QueryResult(
        int BudgetId,
        int UserId,
        decimal Amount,
        DateTime StartDate,
        DateTime? EndDate
    );
}