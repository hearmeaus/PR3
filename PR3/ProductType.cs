using System;
using System.Collections.Generic;

namespace PR3;

public partial class ProductType
{
    public short Id { get; set; }

    public string TypeProduct { get; set; } = null!;

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
