namespace Centric.Backend.Domain.Model.Category;

public record Category(
   int CategoryId,
   string Name,
   bool IsActive,

   int? UserId
);