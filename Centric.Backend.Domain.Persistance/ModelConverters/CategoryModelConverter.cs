using Centric.Backend.Domain.Model.Category;
using Centric.Backend.Domain.Persistance.Queries;

namespace Centric.Backend.Domain.Persistance.ModelConverters;

public static class CategoryModelConverter
{
    public static Category Get(CategoryQuery.QueryResult queryResult)
    {
        return new Category(
            CategoryId: queryResult.CategoryId,
            Name: queryResult.Name,
            IsActive: queryResult.IsActive,
            UserId: queryResult.UserId
        );
    }
}