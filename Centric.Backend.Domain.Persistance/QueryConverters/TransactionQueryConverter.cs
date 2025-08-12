using System.Collections.Immutable;

using Centric.Backend.Domain.Model;
using Centric.Backend.Domain.Persistance.ModelConverters;
using Centric.Backend.Domain.Persistance.Queries;

namespace Centric.Backend.Domain.Persistance.QueryConverters;

public static class TransactionQueryConverter
{
    public static ImmutableList<Transaction> Convert(
        ImmutableList<TransactionQuery.QueryResult> transactionQueryResults,
        ImmutableList<CategoryQuery.QueryResult> categoryQueryResults
    )
    {
        var categories = categoryQueryResults.Select(CategoryModelConverter.Get);
        var categoryMapper = categories.ToDictionary(c => c.CategoryId, c => c.Name);

        var transactions = transactionQueryResults.Select(t => TransactionModelConverter.Get(t, categoryMapper));

        return [.. transactions];
    }
}