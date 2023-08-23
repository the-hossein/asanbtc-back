using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataLayer.Entities;

public partial class Listing
{
    [Key]
    public int IntId { get; set; }

    public string Exchange { get; set; } = null!;

    public string ExchangeLink { get; set; } = null!;

    public DateTime ListingDate { get; set; }

    public TimeSpan? ListingTime { get; set; }

    public string Pair { get; set; } = null!;

    public string? Remark { get; set; }

    public string? ContentLink { get; set; }

    public string? LogoFile { get; set; }
}
