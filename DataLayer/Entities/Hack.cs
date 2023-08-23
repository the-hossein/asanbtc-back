using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataLayer.Entities;

public partial class Hack
{
    [Key]
    public int IntId { get; set; }

    public DateTime HackDate { get; set; }

    public string Remark { get; set; } = null!;

    public string? Exchange { get; set; }

    public string? Currency { get; set; }

    public string? ContentLink { get; set; }
}
