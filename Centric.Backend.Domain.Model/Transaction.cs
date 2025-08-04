namespace Centric.Backend.Domain.Model;

public record Transaction(
    int TransactionId,
    DateTime Date,
    string Description,
    string CategoryName,
    decimal Amount,
    bool IsPurchased,
    string Receipt
);