using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer.Entities;

public partial class Course
{
    [Key]
    public int IntId { get; set; }

    public string? PreviewImage { get; set; }

    public string? PreviewVideo { get; set; }

    public int? NumberOfSession { get; set; }

    public decimal Price { get; set; }

    public string Duration { get; set; } = null!;

    public string? Title { get; set; }

    public string? Description { get; set; }

    public DateTime InsertDate { get; set; }

    public DateTime? LastUpdate { get; set; }

    [ForeignKey(nameof(User))]
    public int TeacherId { get; set; }

    public DateTime? ExpireDate { get; set; }

    public bool Online { get; set; }

    public decimal? DiscountPrice { get; set; }

    //Relations
    public virtual UserAccount User { get; set; }
}
