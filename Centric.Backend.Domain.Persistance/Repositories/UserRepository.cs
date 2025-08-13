using System.Collections.Immutable;

using Centric.Backend.Domain.Model.User;
using Centric.Backend.Domain.Persistance.Queries;
using Centric.Backend.Domain.Persistance.QueryConverters;

namespace Centric.Backend.Persistance.Repositories;

public static class UserRepository
{
    public static async Task<ImmutableList<User>> Get(string connectionString)
    {
        return UserQueryConverter.Get(await UserQuery.Get(connectionString));
    }

    // public static async Task<bool> Add(string connectionString, UserRequest request)
    // {
    //     return UserQueryConverter.Add(await UserQuery.Add(connectionString, request));
    // }
}