using System;
using System.Collections.Generic;

namespace CoffeeShopBack.Models;

public partial class Location
{
    public string LocationId { get; set; } = null!;

    public string Longitude { get; set; } = null!;

    public string Latitude { get; set; } = null!;

    public string CoffeeShopId { get; set; } = null!;

    public virtual CoffeeShop CoffeeShop { get; set; } = null!;
}
