using System.Collections.Immutable;
using Microsoft.Data.SqlClient;

using Dapper;
using Centric.Backend.Domain.Model.Category;

namespace Centric.Backend.Domain.Persistance.Queries;

public static class CategoryQuery
{
    public static async Task<ImmutableList<QueryResult>> Get(string conectionString)
    {
        var connection = new SqlConnection(conectionString);
        var categories = await connection.QueryAsync<QueryResult>("SELECT * FROM [Centric].[dbo].[Category]");

        return [.. categories];
    }

    public static async Task<int> Add(string connectionString, CategoryRequest request)
    {
        var connection = new SqlConnection(connectionString);
        var sql = "INSERT INTO [Centric].dbo.[Category] (Name, IsActive, UserId) VALUES (@Name, @IsActive, @UserId)";

        return await connection.ExecuteAsync(sql, request);
    }

    public record QueryResult(
        int CategoryId,
        string Name,
        bool IsActive,
        int? UserId
    );
}