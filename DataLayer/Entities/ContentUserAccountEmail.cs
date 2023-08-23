using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer.Entities;

public partial class ContentUserAccountEmail
{
    [Key]
    public int IntId { get; set; }

    [ForeignKey(nameof(TheContent))]
    public int ContentId { get; set; }

    [ForeignKey(nameof(User))]
    public int UserAccountId { get; set; }

    public DateTime SendDateTime { get; set; }

    //Relations
    public virtual Content TheContent { get; set; }
    public virtual UserAccount User { get; set; }
}
