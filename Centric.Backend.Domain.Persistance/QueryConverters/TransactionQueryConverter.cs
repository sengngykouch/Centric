using System.Collections.Immutable;

using Centric.Backend.Domain.Model;
using Centric.Backend.Domain.Persistance.ModelConverters;
using Centric.Backend.Domain.Persistance.Queries;

namespace Centric.Backend.Domain.Persistance.QueryConverters;

public static class TransactionQueryConverter
{
    public static async Task<ImmutableList<Transaction>> Convert(string connectionString)
    {
        var categories = (await CategoryQuery.Execute(connectionString)).Select(CategoryModelConverter.Get);
        var categoryMapper = categories.ToDictionary(c => c.CategoryId, c => c.Name);

        var transactions = (await TransactionQuery.Execute(connectionString)).Select(t => TransactionModelConverter.Get(t, categoryMapper));

        return [.. transactions];
    }
}