namespace Centric.Backend.Domain.Model.Budget;

public record Budget(
   int BudgetId,
   int UserId,
   decimal Amount,
   DateTime StartDate,
   DateTime? EndDate
);