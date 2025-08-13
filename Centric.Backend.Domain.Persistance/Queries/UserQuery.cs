using System.Collections.Immutable;
using Microsoft.Data.SqlClient;

using Dapper;
using Centric.Backend.Domain.Model.User;

namespace Centric.Backend.Domain.Persistance.Queries;

public static class UserQuery
{
    public static async Task<ImmutableList<QueryResult>> Get(string conectionString)
    {
        var connection = new SqlConnection(conectionString);
        var users = await connection.QueryAsync<QueryResult>("SELECT * FROM [Centric].[dbo].[Users]");

        return [.. users];
    }

    // public static async Task<int> Add(string connectionString, UserRequest request)
    // {
    //     var connection = new SqlConnection(connectionString);
    //     var sql = "INSERT INTO [Centric].dbo.[Users] (Name, IsActive, UserId) VALUES (@Name, @IsActive, @UserId)";

    //     return await connection.ExecuteAsync(sql, request);
    // }

    public record QueryResult(
        int UserId,
        string FirstName,
        string LastName,
        string EmailAddress,
        bool Notifications
    );
}