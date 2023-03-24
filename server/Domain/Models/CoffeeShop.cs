namespace Domain.Models;

public class CoffeeShop
{
    public string CoffeeShopId { get; set; } = null!;

    public string Title { get; set; } = null!;

    public string? Description { get; set; }

    public string? WorkingHours { get; set; }

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public byte[] Image { get; set; } = null!;

    public string Status { get; set; } = null!;

    public virtual ICollection<Category> Categories { get; } = new List<Category>();

    public virtual ICollection<Location> Locations { get; } = new List<Location>();

    public virtual ICollection<Order> Orders { get; } = new List<Order>();

    public virtual ICollection<SocialMedia> SocialMedias { get; } = new List<SocialMedia>();
}
