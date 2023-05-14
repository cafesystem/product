namespace CafeSystem.ProductManagement.Contracts;

using Domain;

public class ProductGroupId : Id<Guid>
{

    public static ProductGroupId New(Guid id) => new ProductGroupId { Value = id };
    
    public static ProductGroupId New() => New(new Guid());
}