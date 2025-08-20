using System.Collections.Immutable;

using Centric.Backend.Domain.Model.Budget;
using Centric.Backend.Domain.Persistance.Queries;
using Centric.Backend.Domain.Persistance.QueryConverters;

namespace Centric.Backend.Persistance.Repositories;

public static class BudgetRepository
{
    public static async Task<ImmutableList<Budget>> Get(string connectionString)
    {
        return BudgetQueryConverter.Get(await BudgetQuery.Get(connectionString));
    }

    public static async Task<bool> Add(string connectionString, BudgetRequest request)
    {
        return BudgetQueryConverter.Add(await BudgetQuery.Add(connectionString, request));
    }
}