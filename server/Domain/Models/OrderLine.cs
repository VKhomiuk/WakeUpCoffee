namespace Domain.Models;

public class OrderLine
{
    public string OrderLineId { get; set; } = null!;

    public int Count { get; set; }

    public string MenuItemName { get; set; } = null!;

    public string OrderId { get; set; } = null!;

    public string MenuItemId { get; set; } = null!;

    public virtual MenuItem MenuItem { get; set; } = null!;

    public virtual Order Order { get; set; } = null!;

    public virtual ICollection<OrderLineAdditional> OrderLineAdditionals { get; set; } = new List<OrderLineAdditional>();
}
