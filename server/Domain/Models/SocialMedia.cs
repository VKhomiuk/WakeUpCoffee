namespace Domain.Models;

public class SocialMedia
{
    public string SocialMediaId { get; set; } = null!;

    public string Title { get; set; } = null!;

    public string Link { get; set; } = null!;

    public string CoffeeShopId { get; set; } = null!;

    public virtual CoffeeShop CoffeeShop { get; set; } = null!;
}
