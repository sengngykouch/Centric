using System.Collections.Immutable;

using Centric.Backend.Domain.Model;
using Centric.Backend.Domain.Persistance.QueryConverters;

namespace Centric.Backend.Persistance.Repositories;

public static class CategoryRepository
{
    public static async Task<ImmutableList<Category>> Get(string connectionString)
    {
        return await CategoryQueryConverter.Convert(connectionString);
    }
}