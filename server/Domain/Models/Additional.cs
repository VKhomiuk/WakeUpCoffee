namespace Domain.Models;

public class Additional
{
    public string AdditionalId { get; set; } = null!;

    public string Title { get; set; } = null!;

    public decimal Price { get; set; }

    public bool IsActive { get; set; }

    public virtual ICollection<MenuItemAdditional> MenuItemAdditionals { get; set; } = new List<MenuItemAdditional>();

    public virtual ICollection<OrderLineAdditional> OrderLineAdditionals { get; set; } = new List<OrderLineAdditional>();
}
