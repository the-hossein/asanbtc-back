using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer.Entities;

public partial class ConsultingRequest
{
    [Key]
    public int IntId { get; set; }

    public string ConsultingType { get; set; } = null!;

    public string Flname { get; set; } = null!;

    public string Tel { get; set; } = null!;

    public string? Remark { get; set; }

    public DateTime InsertDateTime { get; set; }

    [ForeignKey(nameof(User))]
    public int? UserId { get; set; }

    public string? SuggestedDate { get; set; }

    [ForeignKey(nameof(FactorHead))]
    public int? FactHeadId { get; set; }



    public virtual FactorHead? FactorHead { get; set; }

    public virtual UserAccount? User { get; set; }
}
