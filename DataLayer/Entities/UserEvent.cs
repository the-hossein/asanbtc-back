using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer.Entities;

public partial class UserEvent
{
    [Key]
    public int IntId { get; set; }

    public string FullName { get; set; } = null!;

    [ForeignKey(nameof(Event))]
    public int EventId { get; set; }

    public string CellPhone { get; set; } = null!;

    public string? Remark { get; set; }

    [ForeignKey(nameof(User))]
    public int UserId { get; set; }


    [ForeignKey(nameof(FactorHead))]
    public int FactHeadId { get; set; }

    public DateTime InsertDateTime { get; set; }

    //Relations

    public virtual Event Event { get; set; }

    public virtual UserAccount User { get; set; }


    public virtual FactorHead FactorHead { get; set; }
}
