using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer.Entities;

public partial class CourseSession
{
    [Key]
    public int IntId { get; set; }

    public string? PreviewImg { get; set; }

    public string? VideoFile { get; set; }

    public string? Duration { get; set; }

    public string? Title { get; set; }

    public string? Description { get; set; }

    public int SessionNumber { get; set; }

    [ForeignKey(nameof(Course))]
    public int CourseId { get; set; }

    //Relations
    public virtual Course Course { get; set; }
}
