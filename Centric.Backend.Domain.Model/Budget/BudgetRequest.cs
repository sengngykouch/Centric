namespace Centric.Backend.Domain.Model.Budget;

public record BudgetRequest(
    int UserId,
    decimal Amount,
    DateTime StartDate,
    DateTime? EndDate
);