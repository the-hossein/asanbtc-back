using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataLayer.Entities;

public partial class UserAccount
{
    [Key]
    public int Id { get; set; }

    public string UserName { get; set; } = null!;

    public string? Pass { get; set; }

    public string? Email { get; set; }

    public string? AccessLevel { get; set; }

    public bool IsAdmin { get; set; }

    public string? NationalCode { get; set; }

    public string? Tel { get; set; }

    public string? CellPhone { get; set; }

    public string? NationalCardImage { get; set; }

    public string? BankCardImage { get; set; }

    public string? BankCardNo { get; set; }

    public string? Avatar { get; set; }

    public string? Fname { get; set; }

    public string? Lname { get; set; }

    public int CreditPoint { get; set; }

    public DateTime InsertDate { get; set; }

    public DateTime? LastUpdate { get; set; }

    public bool? IsActive { get; set; }

    public string? Address { get; set; }

    public bool TelNumberVerified { get; set; }

    public bool CellNumberVerified { get; set; }

    public bool AddressVerified { get; set; }

    public bool IdentityVerified { get; set; }

    public string? IdentityImage { get; set; }

    public bool NewsPaper { get; set; }

    public string? TelegramTel { get; set; }
}
