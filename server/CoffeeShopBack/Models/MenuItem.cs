using System;
using System.Collections.Generic;

namespace CoffeeShopBack.Models;

public partial class MenuItem
{
    public string MenuItemId { get; set; } = null!;

    public string Title { get; set; } = null!;

    public string? Description { get; set; }

    public TimeSpan CookingTime { get; set; }

    public decimal Price { get; set; }

    public byte[] Image { get; set; } = null!;

    public bool IsActive { get; set; }

    public string? Amount { get; set; }

    public string CategoryId { get; set; } = null!;

    public virtual Category Category { get; set; } = null!;

    public virtual OrderLine OrderLine { get; } = null!;
}
