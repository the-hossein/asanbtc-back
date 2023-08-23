using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataLayer.Entities;

public partial class Crypto
{
    [Key]
    public int IntId { get; set; }

    public int Rank { get; set; }

    public string Title { get; set; } = null!;

    public string? TitleFarsi { get; set; }

    public string Abbreviation { get; set; } = null!;

    public string? LogoFile { get; set; }

    public DateTime? IcoTime { get; set; }

    public double? IcoPrice { get; set; }

    public string? Link { get; set; }

    public string? ShortRemark { get; set; }

    public string? IntroductionHtml { get; set; }

    public bool ShowAsIco { get; set; }

    public double? PriceDolar { get; set; }

    public double? PriceUsdt { get; set; }

    public double? PriceToman { get; set; }

    public double? PriceBtc { get; set; }

    public double? MarketVol { get; set; }

    public double? TradeVol24h { get; set; }

    public double? PriceChange24hPercent { get; set; }

    public double? PriceChange1wPercent { get; set; }

    public double? High24h { get; set; }

    public double? Low24h { get; set; }

    public double? ActiveVol { get; set; }

    public double? MaxVol { get; set; }

    public bool Mineable { get; set; }

    public DateTime? LastUpdate { get; set; }

    public int? CryptoId { get; set; }

    public double? PriceChange1hPercent { get; set; }

    public bool? Tradable { get; set; }

    public int? DecimalPlace { get; set; }

    public int? QuoteOrderQty { get; set; }

    
}
