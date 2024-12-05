using System;
using System.Collections.Generic;

namespace PR3;

public partial class Partner
{
    public int Id { get; set; }

    public short TypeOfPartnerId { get; set; }

    public string Name { get; set; } = null!;

    public string LegalAdress { get; set; } = null!;

    public string Tin { get; set; } = null!;

    public string NameOfDirector { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string Email { get; set; } = null!;

    public decimal Rating { get; set; }

    public virtual ICollection<PartnersProduct> PartnersProducts { get; set; } = new List<PartnersProduct>();

    public virtual TypesOfPartner TypeOfPartner { get; set; } = null!;
}
