namespace CafeSystem.ProductManagement.Contracts;

using Domain;

public class ProductId : Id<Guid>
{

    public static ProductId New(Guid id) => new ProductId { Value = id };

    public static ProductId New() => New(Guid.NewGuid());
}