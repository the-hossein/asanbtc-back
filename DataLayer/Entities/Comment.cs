using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer.Entities;

public partial class Comment
{
    [Key]
    public int IntId { get; set; }

    [ForeignKey(nameof(User))]
    public int? UserAccountId { get; set; }

    public string? UserFullName { get; set; }

    public string CommentText { get; set; } = null!;

    public DateTime CommentTime { get; set; }

    public bool Confirmed { get; set; }

    public DateTime? ConfirmTime { get; set; }

    public int? ConfirmerUserId { get; set; }

    [ForeignKey(nameof(ParentComment))]
    public int? ParentId { get; set; }

    public int LikeNo { get; set; }

    public int DisLikeNo { get; set; }

    [ForeignKey(nameof(TheContent))]
    public int ContentId { get; set; }

    //Relation
    public virtual UserAccount? User { get; set; }

    public virtual Comment? ParentComment { get; set; }

    public virtual Content TheContent { get; set; }
}
