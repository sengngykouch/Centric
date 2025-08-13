using System.Collections.Immutable;

using Centric.Backend.Domain.Model.User;
using Centric.Backend.Domain.Persistance.ModelConverters;
using Centric.Backend.Domain.Persistance.Queries;

namespace Centric.Backend.Domain.Persistance.QueryConverters;

public static class UserQueryConverter
{
    public static ImmutableList<User> Get(ImmutableList<UserQuery.QueryResult> queryResults)
    {
        var users = queryResults.Select(UserModelConverter.Get);

        return [.. users];
    }

    public static bool Add(int queryResults)
    {
        return queryResults == 1;
    }
}