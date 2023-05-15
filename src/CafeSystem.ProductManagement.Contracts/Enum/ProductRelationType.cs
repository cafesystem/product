namespace CafeSystem.ProductManagement.Contracts;

public enum ProductRelationType
{
    /// <summary>
    /// The Product can be an Alternative to another product
    /// </summary>
    Alternate = 0,
    
    /// <summary>
    /// The Product can be a complement for another product
    /// </summary>
    Complement = 1,
    
    /// <summary>
    /// Additional products for another product
    /// </summary>
    CrossSell = 2,
    
    /// <summary>
    /// A much better in quality and more expensive to another product 
    /// </summary>
    Upsell = 3,
    
    /// <summary>
    /// Product is prerequisite for another product
    /// </summary>
    Prerequisite = 4,
}