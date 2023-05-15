namespace CafeSystem.ProductManagement.Contracts;

using CafeSystem.Domain;

public class ProductPackageId : Id<Guid>
{

    public static ProductPackageId New(Guid id) => new ProductPackageId { Value = id };

    public static ProductPackageId New() => New(Guid.NewGuid());
}