using System.Collections.Immutable;

using Centric.Backend.Domain.Model.Transaction;
using Centric.Backend.Domain.Persistance.Queries;
using Centric.Backend.Domain.Persistance.QueryConverters;

namespace Centric.Backend.Persistance.Repositories;

public static class TransactionRepository
{
    public static async Task<ImmutableList<Transaction>> Get(string connectionString)
    {
        var categoryQueryResults = await CategoryQuery.Get(connectionString);
        var transactionQueryResults = await TransactionQuery.Get(connectionString);

        return TransactionQueryConverter.Get(transactionQueryResults, categoryQueryResults);
    }
}