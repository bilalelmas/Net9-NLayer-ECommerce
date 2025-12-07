namespace Net9.NLayer.ECommerce.Core.Entities;

public class User : BaseEntity
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string PasswordHash { get; set; } = string.Empty;
    public string? PhoneNumber { get; set; }
    public string? Address { get; set; }

    // Navigation Properties
    public ICollection<Order> Orders { get; set; } = new List<Order>();
}
