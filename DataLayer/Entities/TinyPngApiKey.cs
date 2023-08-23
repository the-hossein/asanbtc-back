using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataLayer.Entities;

public partial class TinyPngApiKey
{
    [Key]
    public int IntId { get; set; }

    public string ApiKey { get; set; } = null!;

    public int Counter { get; set; }

    public DateTime LastUpdate { get; set; }
}
