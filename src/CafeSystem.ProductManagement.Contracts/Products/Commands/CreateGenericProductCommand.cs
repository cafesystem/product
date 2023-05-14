namespace CafeSystem.ProductManagement.Contracts;

public class CreateGenericProductCommand
{
    public string Title { get; set; }
    public string Description { get; set; }
    public ProductNature Nature { get; set; }
    public ProductId ParentId { get; set; }
    public IReadOnlyCollection<ProductGroupId> Groups { get; set; }
}