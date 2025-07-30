namespace Centric.Backend.Domain.Model;

public record Category(
   int CategoryId,
   string Name,
   bool IsActive,

   int? UserId
);