using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer.Entities;

public partial class Discount
{
    [Key]
    public int IntId { get; set; }

    public string DiscountCode { get; set; } = null!;

    public int DiscountPercent { get; set; }

    [ForeignKey(nameof(Event))]
    public int? EventId { get; set; }

    [ForeignKey(nameof(User))]
    public int? UserId { get; set; }

    [ForeignKey(nameof(Course))]
    public int? CourseId { get; set; }

    //Relation
    public virtual UserAccount? User { get; set; }
    public virtual Event? Event { get; set; }
    public virtual Course? Course { get; set; }
}
