using System.Collections.Immutable;

using Centric.Backend.Domain.Model.Budget;
using Centric.Backend.Domain.Persistance.ModelConverters;
using Centric.Backend.Domain.Persistance.Queries;

namespace Centric.Backend.Domain.Persistance.QueryConverters;

public static class BudgetQueryConverter
{
    public static ImmutableList<Budget> Get(ImmutableList<BudgetQuery.QueryResult> queryResults)
    {
        var budget = queryResults.Select(BudgetModelConverter.Get);

        return [.. budget];
    }

    public static bool Add(int queryResults)
    {
        return queryResults == 1;
    }
}