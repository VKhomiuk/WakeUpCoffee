using System;
using System.Collections.Generic;

namespace CoffeeShopBack.Models;

public partial class Order
{
    public string OrderId { get; set; } = null!;

    public decimal Price { get; set; }

    public string Status { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public DateTime ScheduledDate { get; set; }

    public string? Comment { get; set; }

    public string? PaymentType { get; set; }

    public string CoffeeShopId { get; set; } = null!;

    public string UserId { get; set; } = null!;

    public virtual CoffeeShop CoffeeShop { get; set; } = null!;

    public virtual ICollection<OrderLine> OrderLines { get; } = new List<OrderLine>();

    public virtual User User { get; set; } = null!;
}
