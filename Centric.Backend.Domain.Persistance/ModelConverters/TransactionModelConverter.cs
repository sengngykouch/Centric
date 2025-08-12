using Centric.Backend.Domain.Model.Transaction;
using Centric.Backend.Domain.Persistance.Queries;

namespace Centric.Backend.Domain.Persistance.ModelConverters;

public static class TransactionModelConverter
{
    public static Transaction Get(TransactionQuery.QueryResult transaction, string categoryName)
    {
        return new Transaction(
            TransactionId: transaction.TransactionId,
            Date: transaction.Date,
            Description: transaction.Description,
            CategoryName: categoryName,
            Amount: transaction.Amount,
            IsPurchased: transaction.IsPurchased,
            Receipt: transaction.Receipt
        );
    }
}