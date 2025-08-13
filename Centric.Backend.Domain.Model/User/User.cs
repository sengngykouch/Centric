namespace Centric.Backend.Domain.Model.User;

public record User(
    int UserId,
    string FirstName,
    string LastName,
    string EmailAddress,
    bool Notifications
);