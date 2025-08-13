namespace Centric.Backend.Domain.Model.Category;

public record UserRequest(
    string Name,
    bool IsActive,
    int UserId
);