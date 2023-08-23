using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataLayer.Entities;

public partial class Stop
{
    [Key]
    public int IntId { get; set; }

    public string? Exchange { get; set; }

    public DateTime StopDate { get; set; }

    public string? StopTime { get; set; }

    public string? Remark { get; set; }

    public string? ContentLink { get; set; }

    public string? LogoFile { get; set; }
}
