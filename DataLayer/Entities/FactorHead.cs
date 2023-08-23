using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer.Entities;

public partial class FactorHead
{
    [Key]
    public int IntId { get; set; }

    public DateTime FactDate { get; set; }

    public DateTime InsertDate { get; set; }

    [ForeignKey(nameof(User))]
    public int UserId { get; set; }

    public string? Remark { get; set; }

    public bool Payed { get; set; }

    //Relations
    public virtual UserAccount User { get; set; }
}
