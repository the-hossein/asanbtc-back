using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataLayer.Entities;

public partial class Setting
{
    [Key]
    public int IntId { get; set; }

    public string? Tel { get; set; }

    public string? TelegramChannel { get; set; }

    public string? InstagramPage { get; set; }

    public string? SiteEmail { get; set; }

    public string? AboutUs { get; set; }

    public string? OurRules { get; set; }

    public double? GeoLocationX { get; set; }

    public double? GeoLocationY { get; set; }

    public string? Address { get; set; }

    public string? AcademySectionText { get; set; }

    public string? AgoodNews { get; set; }
}
