using CafeSystem.ProductManagement.Contracts;

namespace CafeSystem.ProductManagement.Domain;

using CafeSystem.Domain;

public partial class ProductPackage : AggregateRoot<ProductPackageId>
{

    #region props

    public string Title { get; }
    
    public IReadOnlyCollection<Product> Products { get; }

    public IReadOnlyCollection<ProductPackage> Packages { get; }
    
    #endregion
}