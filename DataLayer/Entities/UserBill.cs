using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer.Entities;

public partial class UserBill
{
    [Key]
    public int IntId { get; set; }

    [ForeignKey(nameof(User))]
    public int UserId { get; set; }

    [ForeignKey(nameof(FactorHead))]
    public int? FactHeadId { get; set; }

    public decimal Bed { get; set; }

    public decimal Bes { get; set; }

    public string? BankOrderId { get; set; }

    public decimal Rest { get; set; }

    public string? Description { get; set; }

    public DateTime TransactionDate { get; set; }

    public bool IsOk { get; set; }

    [ForeignKey(nameof(Crypto))]
    public int? CryptoId { get; set; }

    public bool? Withdrawal { get; set; }

    public string? OriginWallet { get; set; }

    public string? Memo { get; set; }

    public string? PaymentGetway { get; set; }


    //Relations
    public virtual UserAccount User { get; set; }

    public virtual FactorHead? FactorHead { get; set; }

    public virtual Crypto? Crypto { get; set; }
}
