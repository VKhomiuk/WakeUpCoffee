namespace Domain.Models;

public class MenuItemAdditional
{
    public string MenuItemId { get; set; } = null!;

    public string AdditionalId { get; set; } = null!;

    public virtual MenuItem MenuItem { get; set; } = null!;

    public virtual Additional Additional { get; set; } = null!;
}
