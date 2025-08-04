using System.Collections.Immutable;

using Centric.Backend.Domain.Model;
using Centric.Backend.Domain.Persistance.QueryConverters;

namespace Centric.Backend.Persistance.Repositories;

public static class TransactionRepository
{
    public static async Task<ImmutableList<Transaction>> Get(string connectionString)
    {
        return await TransactionQueryConverter.Convert(connectionString);
    }
}