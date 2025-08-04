using System.Collections.Immutable;
using Microsoft.Data.SqlClient;

using Dapper;

namespace Centric.Backend.Domain.Persistance.Queries;

public static class CategoryQuery
{
    public static async Task<ImmutableList<QueryResult>> Execute(string conectionString)
    {
        var connection = new SqlConnection(conectionString);
        var categories = await connection.QueryAsync<QueryResult>("SELECT * FROM [Centric].[dbo].[Category]");

        return [.. categories];
    }

    public record QueryResult(
        int CategoryId,
        string Name,
        bool IsActive,
        int? UserId
    );
}