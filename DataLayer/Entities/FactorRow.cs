using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer.Entities;

public partial class FactorRow
{
    [Key]
    public int IntId { get; set; }

    public string Description { get; set; } = null!;

    public decimal Price { get; set; }

    public string? Remark { get; set; }

    [ForeignKey(nameof(FactorHead))]
    public int FactorHeadId { get; set; }

    //Relations
    public virtual FactorHead FactorHead { get; set; }
}
