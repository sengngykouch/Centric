using System.Collections.Immutable;

using Centric.Backend.Domain.Model;
using Centric.Backend.Domain.Persistance.Queries;
using Centric.Backend.Domain.Persistance.QueryConverters;

namespace Centric.Backend.Persistance.Repositories;

public static class TransactionRepository
{
    public static async Task<ImmutableList<Transaction>> Get(string connectionString)
    {
        var categoryQueryResults = await CategoryQuery.Execute(connectionString);
        var transactionQueryResults = await TransactionQuery.Execute(connectionString);

        return TransactionQueryConverter.Convert(transactionQueryResults, categoryQueryResults);
    }
}