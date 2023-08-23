using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer.Entities;

public partial class Wallet
{
    [Key]
    public int IntId { get; set; }

    [ForeignKey(nameof(Crypto))]
    public int CryptoId { get; set; }

    public string? Type { get; set; }

    public string? Address { get; set; }

    public string? WalletDetail { get; set; }

    public string? WalletMemo { get; set; }

    //Relations
    public virtual Crypto Crypto { get; set; }
}
