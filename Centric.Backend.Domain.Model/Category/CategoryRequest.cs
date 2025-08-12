namespace Centric.Backend.Domain.Model.Category;

public record CategoryRequest(
    string Name,
    bool IsActive,
    int UserId
);