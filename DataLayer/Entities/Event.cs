using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataLayer.Entities;

public partial class Event
{
    [Key]
    public int IntId { get; set; }

    public string EventTitle { get; set; } = null!;

    public int Price { get; set; }

    public string? DescriptionHtml { get; set; }

    public string? Remark { get; set; }
}
