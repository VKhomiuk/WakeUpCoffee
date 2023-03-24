namespace Domain.Models;

public class OrderLineAdditional
{
    public string OrderLineId { get; set; } = null!;

    public string AdditionalId { get; set; } = null!;

    public int Count { get; set; }

    public virtual OrderLine OrderLine { get; set; } = null!;

    public virtual Additional Additional { get; set; } = null!;
}
