using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataLayer.Entities;

public partial class ContentType
{
    [Key]
    public int IntId { get; set; }

    public string Title { get; set; } = null!;
}
