using System.Collections.Immutable;
using Microsoft.Data.SqlClient;

using Dapper;

namespace Centric.Backend.Domain.Persistance.Queries;

public static class TransactionQuery
{
    public static async Task<ImmutableList<QueryResult>> Get(string connectionString)
    {
        var connection = new SqlConnection(connectionString);
        var transactions = await connection.QueryAsync<QueryResult>("SELECT * FROM [Centric].[dbo].[Transaction]");

        return [.. transactions];
    }

    public record QueryResult(
        int TransactionId,
        int UserId,
        int CategoryId,

        DateTime Date,
        string Description,
        decimal Amount,
        string Receipt,
        bool IsPurchased
    );
}