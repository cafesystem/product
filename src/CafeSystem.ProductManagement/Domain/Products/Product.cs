namespace CafeSystem.ProductManagement.Domain;

using CafeSystem.Domain;
using CafeSystem.ProductManagement.Contracts;


public partial class Product : AggregateRoot<ProductId>
{


    private Product(CreateGenericProductCommand command) : base()
    {
        if (command is null) throw new ArgumentNullException(nameof(command));
        
        
    }
}