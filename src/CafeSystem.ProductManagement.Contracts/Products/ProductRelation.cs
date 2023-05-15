namespace CafeSystem.ProductManagement.Contracts;

using Domain;

/// <summary>
/// Determines relationship (see: <see cref="ProductRelationType"/> for two Products.
/// </summary>
public class ProductRelation : ValueObject 
{
    
    public ProductId SourceProductId { get; }
    
    public ProductId TargetProductId { get; }
    
    public ProductRelationType RelationType { get; }
    
    public bool TwoWay { get; }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return SourceProductId;
        yield return TargetProductId;
        yield return RelationType;
    }
}