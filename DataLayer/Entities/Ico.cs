using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataLayer.Entities;

public partial class Ico
{
    [Key]
    public int IntId { get; set; }

    public string Title { get; set; } = null!;

    public string Symbol { get; set; } = null!;

    public DateTime StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public decimal? StartPrice { get; set; }

    public string? WebSite { get; set; }

    public string? Remark { get; set; }

    public string? ContentLink { get; set; }

    public string? LogoFile { get; set; }
}
