namespace Domain.Models;

public class Category
{
    public string CategoryId { get; set; } = null!;

    public string Title { get; set; } = null!;

    public string CoffeeShopId { get; set; } = null!;

    public virtual CoffeeShop CoffeeShop { get; set; } = null!;

    public virtual ICollection<MenuItem> MenuItems { get; } = new List<MenuItem>();
}
