using System.Data;
using System.Data.SqlClient;
using Dapper;
using DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

public partial class AsanBtcDbContext : DbContext
{

  
    public AsanBtcDbContext(DbContextOptions<AsanBtcDbContext> options)
        : base(options)
    {
   
    }

    public virtual DbSet<Comment> Comment { get; set; }

    public virtual DbSet<ConsultingRequest> ConsultingRequest { get; set; }

    public virtual DbSet<Content> Content { get; set; }

    public virtual DbSet<ContentType> ContentType { get; set; }

    public virtual DbSet<ContentUserAccountEmail> ContentUserAccountEmail { get; set; }

    public virtual DbSet<Course> Course { get; set; }

    public virtual DbSet<CourseSession> CourseSession { get; set; }

    public virtual DbSet<Crypto> Crypto { get; set; }

    public virtual DbSet<Discount> Discount { get; set; }

    public virtual DbSet<DollarPriceHistory> DollarPriceHistorie { get; set; }

    public virtual DbSet<Event> Event { get; set; }

    public virtual DbSet<Exchange> Exchange { get; set; }

    public virtual DbSet<FactorHead> FactorHead { get; set; }

    public virtual DbSet<FactorRow> FactorRow { get; set; }

    public virtual DbSet<Hack> Hack { get; set; }

    public virtual DbSet<Ico> Icos { get; set; }

    public virtual DbSet<JunctionTable> JunctionTable { get; set; }

    public virtual DbSet<Listing> Listing { get; set; }

    public virtual DbSet<Setting> Setting { get; set; }

    public virtual DbSet<Stop> Stop { get; set; }

    public virtual DbSet<Sysdiagram> Sysdiagrams { get; set; }

    public virtual DbSet<TinyPngApiKey> TinyPngApiKey { get; set; }

    public virtual DbSet<TradeOrder> TradeOrder { get; set; }

    public virtual DbSet<UserAccount> UserAccount { get; set; }

    public virtual DbSet<UserBill> UserBills { get; set; }

    public virtual DbSet<UserEvent> UserEvents { get; set; }

    public virtual DbSet<Wallet> Wallets { get; set; }


  
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Sysdiagram>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("sysdiagrams");

            entity.Property(e => e.Definition).HasColumnName("definition");
            entity.Property(e => e.DiagramId).HasColumnName("diagram_id");
            entity.Property(e => e.Name)
                .HasMaxLength(128)
                .HasColumnName("name");
            entity.Property(e => e.PrincipalId).HasColumnName("principal_id");
            entity.Property(e => e.Version).HasColumnName("version");
        });



    }

    
}