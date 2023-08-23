using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer.Entities;

public partial class TradeOrder
{
    [Key]
    public int IntId { get; set; }

    public string Side { get; set; } = null!;

    [ForeignKey(nameof(Crypto))]
    public int CryptoId { get; set; }

    public decimal? Value { get; set; }

    public double? Volume { get; set; }

    public double? OfferPrice { get; set; }

    public string? Remark { get; set; }

    [ForeignKey(nameof(User))]
    public int? UserId { get; set; }

    public string Flname { get; set; } = null!;

    public DateTime InsertDateTime { get; set; }

    [ForeignKey(nameof(FactorHead))]
    public int? FactureHeadId { get; set; }

    public string? WalletAddress { get; set; }

    public string? TypeWallet { get; set; }

    public bool? MakingWallet { get; set; }

    //Relations
    public virtual Crypto Crypto { get; set; }

    public virtual UserAccount? User { get; set; }

    public virtual FactorHead? FactorHead { get; set; }
}
