using System.Collections.Immutable;

using Centric.Backend.Domain.Model.Category;
using Centric.Backend.Domain.Persistance.Queries;
using Centric.Backend.Domain.Persistance.QueryConverters;

namespace Centric.Backend.Persistance.Repositories;

public static class CategoryRepository
{
    public static async Task<ImmutableList<Category>> Get(string connectionString)
    {
        return CategoryQueryConverter.Get(await CategoryQuery.Get(connectionString));
    }

    public static async Task<bool> Add(string connectionString, CategoryRequest request)
    {
        return CategoryQueryConverter.Add(await CategoryQuery.Add(connectionString, request));
    }
}