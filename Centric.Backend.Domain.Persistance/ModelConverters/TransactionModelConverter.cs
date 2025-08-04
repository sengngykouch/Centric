using Centric.Backend.Domain.Model;
using Centric.Backend.Domain.Persistance.Queries;

namespace Centric.Backend.Domain.Persistance.ModelConverters;

public static class TransactionModelConverter
{
    public static Transaction Get(TransactionQuery.QueryResult transaction, Dictionary<int, string> categoryMapper)
    {
        categoryMapper.TryGetValue(transaction.CategoryId, out var categoryName);

        return new Transaction(
            TransactionId: transaction.TransactionId,
            Date: transaction.Date,
            Description: transaction.Description,
            CategoryName: categoryName ?? "",
            Amount: transaction.Amount,
            IsPurchased: transaction.IsPurchased,
            Receipt: transaction.Receipt
        );
    }
}