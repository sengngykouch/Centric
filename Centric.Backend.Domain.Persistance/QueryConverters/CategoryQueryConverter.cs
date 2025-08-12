using System.Collections.Immutable;

using Centric.Backend.Domain.Model.Category;
using Centric.Backend.Domain.Persistance.ModelConverters;
using Centric.Backend.Domain.Persistance.Queries;

namespace Centric.Backend.Domain.Persistance.QueryConverters;

public static class CategoryQueryConverter
{
    public static ImmutableList<Category> Get(ImmutableList<CategoryQuery.QueryResult> queryResults)
    {
        var categories = queryResults.Select(CategoryModelConverter.Get);

        return [.. categories];
    }

    public static bool Add(int queryResults)
    {
        return queryResults == 1;
    }
}