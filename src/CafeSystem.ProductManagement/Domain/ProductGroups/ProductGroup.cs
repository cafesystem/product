using CafeSystem.ProductManagement.Contracts;

namespace CafeSystem.ProductManagement.Domain;

using CafeSystem.Domain;

public class ProductGroup : AggregateRoot<ProductGroupId>
{

    #region Props

    public string Title { get; }

    public ProductGroupId ParentId { get; }
    
    public string Description { get; }

    #endregion
}