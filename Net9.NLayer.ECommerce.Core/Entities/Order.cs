namespace Net9.NLayer.ECommerce.Core.Entities;

public class Order : BaseEntity
{
    public int UserId { get; set; }
    public decimal TotalAmount { get; set; }
    public string Status { get; set; } = string.Empty; // Örn: "Pending", "Completed", "Cancelled"
    public DateTime OrderDate { get; set; }

    // Navigation Properties
    public User User { get; set; } = null!;
    public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
}
