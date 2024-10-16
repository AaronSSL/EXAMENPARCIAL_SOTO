using System;
using System.Collections.Generic;

namespace EXAMENPARCIAL_SOTO.DOMAIN.CORE.ENTITIES;

public partial class JobOffer
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int Salary { get; set; }

    public string Location { get; set; } = null!;
}
