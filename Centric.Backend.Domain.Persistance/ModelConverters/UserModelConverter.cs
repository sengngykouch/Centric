using Centric.Backend.Domain.Model.User;
using Centric.Backend.Domain.Persistance.Queries;

namespace Centric.Backend.Domain.Persistance.ModelConverters;

public static class UserModelConverter
{
    public static User Get(UserQuery.QueryResult queryResult)
    {
        return new User(
            UserId: queryResult.UserId,
            FirstName: queryResult.FirstName,
            LastName: queryResult.LastName,
            EmailAddress: queryResult.EmailAddress,
            Notifications: queryResult.Notifications
        );
    }
}