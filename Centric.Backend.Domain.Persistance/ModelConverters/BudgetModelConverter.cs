using Centric.Backend.Domain.Model.Budget;
using Centric.Backend.Domain.Persistance.Queries;

namespace Centric.Backend.Domain.Persistance.ModelConverters;

public static class BudgetModelConverter
{
    public static Budget Get(BudgetQuery.QueryResult queryResult)
    {
        return new Budget(
            BudgetId: queryResult.BudgetId,
            UserId: queryResult.UserId,
            Amount: queryResult.Amount,
            StartDate: queryResult.StartDate,
            EndDate: queryResult.EndDate
        );
    }
}