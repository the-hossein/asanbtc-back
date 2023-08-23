using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataLayer.Entities;

public partial class Exchange
{
    [Key]
    public int IntId { get; set; }

    public int Rank { get; set; }

    public string Title { get; set; } = null!;

    public string? TitleFarsi { get; set; }

    public string? LogoFile { get; set; }

    public decimal BtctradeVolume24Rls { get; set; }

    public int Btchprice24Rls { get; set; }

    public int Btclprice24Rls { get; set; }

    public int BtclastPrice24Rls { get; set; }

    public int BtclastPrice24Usdt { get; set; }

    public string? Link { get; set; }

    public string? Tel { get; set; }

    public string? IntroductionHtml { get; set; }

    public int? MarketCount { get; set; }

    public bool IsIranian { get; set; }

    public DateTime InsertDate { get; set; }

    public DateTime? LastUpdate { get; set; }

    public DateTime? FundDate { get; set; }
}
