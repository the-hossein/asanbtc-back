using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer.Entities;

public partial class JunctionTable
{
    [Key]
    public int IntId { get; set; }

    [ForeignKey(nameof(FactorHead))]
    public int FactorHeadId { get; set; }

    [ForeignKey(nameof(Course))]
    public int CourseId { get; set; }

    //Relations
    public virtual FactorHead FactorHead { get; set; }

    public virtual Course Course { get; set; }
}
