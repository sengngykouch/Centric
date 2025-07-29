namespace Centric.Backend.Domain.Model;

public record Category(
   int Id,
   string Name,
   bool IsActive,

   int? UserId
);