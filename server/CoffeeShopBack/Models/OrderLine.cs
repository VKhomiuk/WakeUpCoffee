using System;
using System.Collections.Generic;

namespace CoffeeShopBack.Models;

public partial class OrderLine
{
    public string OrderLineId { get; set; } = null!;

    public int Count { get; set; }

    public string MenuItemName { get; set; } = null!;

    public string OrderId { get; set; } = null!;

    public string MenuItemId { get; set; } = null!;

    public virtual MenuItem MenuItem { get; set; } = null!;

    public virtual Order Order { get; set; } = null!;
}
