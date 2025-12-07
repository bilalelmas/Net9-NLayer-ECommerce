namespace Net9.NLayer.ECommerce.Core.Entities;

public class Product : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; }
    public decimal Price { get; set; }
    public int Stock { get; set; }
    public int CategoryId { get; set; }

    // Navigation Properties
    public Category Category { get; set; } = null!;
}
