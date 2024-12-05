using System;
using System.Collections.Generic;

namespace PR3;

public partial class TypesOfPartner
{
    public short Id { get; set; }

    public string PartnerType { get; set; } = null!;

    public virtual ICollection<Partner> Partners { get; set; } = new List<Partner>();
}
