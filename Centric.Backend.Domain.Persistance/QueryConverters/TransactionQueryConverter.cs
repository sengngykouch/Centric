using System.Collections.Immutable;

using Centric.Backend.Domain.Model.Transaction;
using Centric.Backend.Domain.Persistance.ModelConverters;
using Centric.Backend.Domain.Persistance.Queries;

namespace Centric.Backend.Domain.Persistance.QueryConverters;

public static class TransactionQueryConverter
{
    public static ImmutableList<Transaction> Get(
        ImmutableList<TransactionQuery.QueryResult> transactionQueryResults,
        ImmutableList<CategoryQuery.QueryResult> categoryQueryResults
    )
    {
        var categories = categoryQueryResults.Select(CategoryModelConverter.Get);
        var transactions = transactionQueryResults.Select(t => TransactionModelConverter.Get(
            t, categories.Where(c => c.CategoryId == t.CategoryId).First().Name
        ));

        return [.. transactions];
    }
}