using System.Collections.Immutable;

using Centric.Backend.Domain.Model;
using Centric.Backend.Domain.Persistance.ModelConverters;
using Centric.Backend.Domain.Persistance.Queries;

namespace Centric.Backend.Domain.Persistance.QueryConverters;

public static class CategoryQueryConverter
{
    public static async Task<ImmutableList<Category>> Convert(string connectionString)
    {
        var categories = (await CategoryQuery.Execute(connectionString)).Select(CategoryModelConverter.Get);

        return [.. categories];
    }
}