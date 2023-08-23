using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RepositoryLayer.Migrations
{
    /// <inheritdoc />
    public partial class addRelations3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ContentTypes",
                columns: table => new
                {
                    IntId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContentTypes", x => x.IntId);
                });

            migrationBuilder.CreateTable(
                name: "Cryptos",
                columns: table => new
                {
                    IntId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rank = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TitleFarsi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Abbreviation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LogoFile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IcoTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IcoPrice = table.Column<double>(type: "float", nullable: true),
                    Link = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShortRemark = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IntroductionHtml = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShowAsIco = table.Column<bool>(type: "bit", nullable: false),
                    PriceDolar = table.Column<double>(type: "float", nullable: true),
                    PriceUsdt = table.Column<double>(type: "float", nullable: true),
                    PriceToman = table.Column<double>(type: "float", nullable: true),
                    PriceBtc = table.Column<double>(type: "float", nullable: true),
                    MarketVol = table.Column<double>(type: "float", nullable: true),
                    TradeVol24h = table.Column<double>(type: "float", nullable: true),
                    PriceChange24hPercent = table.Column<double>(type: "float", nullable: true),
                    PriceChange1wPercent = table.Column<double>(type: "float", nullable: true),
                    High24h = table.Column<double>(type: "float", nullable: true),
                    Low24h = table.Column<double>(type: "float", nullable: true),
                    ActiveVol = table.Column<double>(type: "float", nullable: true),
                    MaxVol = table.Column<double>(type: "float", nullable: true),
                    Mineable = table.Column<bool>(type: "bit", nullable: false),
                    LastUpdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CryptoId = table.Column<int>(type: "int", nullable: true),
                    PriceChange1hPercent = table.Column<double>(type: "float", nullable: true),
                    Tradable = table.Column<bool>(type: "bit", nullable: true),
                    DecimalPlace = table.Column<int>(type: "int", nullable: true),
                    QuoteOrderQty = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cryptos", x => x.IntId);
                });

            migrationBuilder.CreateTable(
                name: "DollarPriceHistories",
                columns: table => new
                {
                    IntId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FromDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ToDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DollarPriceToman = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DollarPriceHistories", x => x.IntId);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    IntId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EventTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    DescriptionHtml = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.IntId);
                });

            migrationBuilder.CreateTable(
                name: "Exchanges",
                columns: table => new
                {
                    IntId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rank = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TitleFarsi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LogoFile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BtctradeVolume24Rls = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Btchprice24Rls = table.Column<int>(type: "int", nullable: false),
                    Btclprice24Rls = table.Column<int>(type: "int", nullable: false),
                    BtclastPrice24Rls = table.Column<int>(type: "int", nullable: false),
                    BtclastPrice24Usdt = table.Column<int>(type: "int", nullable: false),
                    Link = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IntroductionHtml = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MarketCount = table.Column<int>(type: "int", nullable: true),
                    IsIranian = table.Column<bool>(type: "bit", nullable: false),
                    InsertDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FundDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exchanges", x => x.IntId);
                });

            migrationBuilder.CreateTable(
                name: "Hacks",
                columns: table => new
                {
                    IntId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HackDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Remark = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Exchange = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Currency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContentLink = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hacks", x => x.IntId);
                });

            migrationBuilder.CreateTable(
                name: "Icos",
                columns: table => new
                {
                    IntId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Symbol = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StartPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    WebSite = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContentLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LogoFile = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Icos", x => x.IntId);
                });

            migrationBuilder.CreateTable(
                name: "Listings",
                columns: table => new
                {
                    IntId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Exchange = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExchangeLink = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ListingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ListingTime = table.Column<TimeSpan>(type: "time", nullable: true),
                    Pair = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Remark = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContentLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LogoFile = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Listings", x => x.IntId);
                });

            migrationBuilder.CreateTable(
                name: "Settings",
                columns: table => new
                {
                    IntId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TelegramChannel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InstagramPage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SiteEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AboutUs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OurRules = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GeoLocationX = table.Column<double>(type: "float", nullable: true),
                    GeoLocationY = table.Column<double>(type: "float", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AcademySectionText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AgoodNews = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Settings", x => x.IntId);
                });

            migrationBuilder.CreateTable(
                name: "Stops",
                columns: table => new
                {
                    IntId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Exchange = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StopDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StopTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContentLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LogoFile = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stops", x => x.IntId);
                });

            migrationBuilder.CreateTable(
                name: "TinyPngApiKeys",
                columns: table => new
                {
                    IntId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApiKey = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Counter = table.Column<int>(type: "int", nullable: false),
                    LastUpdate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TinyPngApiKeys", x => x.IntId);
                });

            migrationBuilder.CreateTable(
                name: "UserAccounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pass = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccessLevel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsAdmin = table.Column<bool>(type: "bit", nullable: false),
                    NationalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CellPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NationalCardImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BankCardImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BankCardNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Avatar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Lname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreditPoint = table.Column<int>(type: "int", nullable: false),
                    InsertDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TelNumberVerified = table.Column<bool>(type: "bit", nullable: false),
                    CellNumberVerified = table.Column<bool>(type: "bit", nullable: false),
                    AddressVerified = table.Column<bool>(type: "bit", nullable: false),
                    IdentityVerified = table.Column<bool>(type: "bit", nullable: false),
                    IdentityImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NewsPaper = table.Column<bool>(type: "bit", nullable: false),
                    TelegramTel = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAccounts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Wallets",
                columns: table => new
                {
                    IntId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CryptoId = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WalletDetail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WalletMemo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wallets", x => x.IntId);
                    table.ForeignKey(
                        name: "FK_Wallets_Cryptos_CryptoId",
                        column: x => x.CryptoId,
                        principalTable: "Cryptos",
                        principalColumn: "IntId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Contents",
                columns: table => new
                {
                    IntId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContentTypeId = table.Column<int>(type: "int", nullable: false),
                    Titr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Lead = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContentText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PicFile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReleaseTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Label = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Favorite = table.Column<bool>(type: "bit", nullable: false),
                    VisitNo = table.Column<int>(type: "int", nullable: false),
                    Confirmed = table.Column<bool>(type: "bit", nullable: false),
                    Telegram = table.Column<bool>(type: "bit", nullable: false),
                    TelegramSent = table.Column<bool>(type: "bit", nullable: false),
                    Files = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SourceTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SourceLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AuthorUserAccountId = table.Column<int>(type: "int", nullable: true),
                    LikeNum = table.Column<int>(type: "int", nullable: false),
                    DisLikeNum = table.Column<int>(type: "int", nullable: false),
                    InsertDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    VideoFile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VoiceFile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExpireDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NewsPaper = table.Column<bool>(type: "bit", nullable: false),
                    PicAlt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Keyword = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdLocation = table.Column<int>(type: "int", nullable: true),
                    EnglishTitr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShowLocation = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contents", x => x.IntId);
                    table.ForeignKey(
                        name: "FK_Contents_ContentTypes_ContentTypeId",
                        column: x => x.ContentTypeId,
                        principalTable: "ContentTypes",
                        principalColumn: "IntId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Contents_UserAccounts_AuthorUserAccountId",
                        column: x => x.AuthorUserAccountId,
                        principalTable: "UserAccounts",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    IntId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PreviewImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PreviewVideo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumberOfSession = table.Column<int>(type: "int", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Duration = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InsertDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TeacherId = table.Column<int>(type: "int", nullable: false),
                    ExpireDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Online = table.Column<bool>(type: "bit", nullable: false),
                    DiscountPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.IntId);
                    table.ForeignKey(
                        name: "FK_Courses_UserAccounts_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "UserAccounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FactorHeads",
                columns: table => new
                {
                    IntId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FactDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InsertDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Remark = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Payed = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FactorHeads", x => x.IntId);
                    table.ForeignKey(
                        name: "FK_FactorHeads_UserAccounts_UserId",
                        column: x => x.UserId,
                        principalTable: "UserAccounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    IntId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserAccountId = table.Column<int>(type: "int", nullable: true),
                    UserFullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CommentText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CommentTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Confirmed = table.Column<bool>(type: "bit", nullable: false),
                    ConfirmTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ConfirmerUserId = table.Column<int>(type: "int", nullable: true),
                    ParentId = table.Column<int>(type: "int", nullable: true),
                    LikeNo = table.Column<int>(type: "int", nullable: false),
                    DisLikeNo = table.Column<int>(type: "int", nullable: false),
                    ContentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.IntId);
                    table.ForeignKey(
                        name: "FK_Comments_Comments_ParentId",
                        column: x => x.ParentId,
                        principalTable: "Comments",
                        principalColumn: "IntId");
                    table.ForeignKey(
                        name: "FK_Comments_Contents_ContentId",
                        column: x => x.ContentId,
                        principalTable: "Contents",
                        principalColumn: "IntId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Comments_UserAccounts_UserAccountId",
                        column: x => x.UserAccountId,
                        principalTable: "UserAccounts",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ContentUserAccountEmails",
                columns: table => new
                {
                    IntId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContentId = table.Column<int>(type: "int", nullable: false),
                    UserAccountId = table.Column<int>(type: "int", nullable: false),
                    SendDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContentUserAccountEmails", x => x.IntId);
                    table.ForeignKey(
                        name: "FK_ContentUserAccountEmails_Contents_ContentId",
                        column: x => x.ContentId,
                        principalTable: "Contents",
                        principalColumn: "IntId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ContentUserAccountEmails_UserAccounts_UserAccountId",
                        column: x => x.UserAccountId,
                        principalTable: "UserAccounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CourseSessions",
                columns: table => new
                {
                    IntId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PreviewImg = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VideoFile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Duration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SessionNumber = table.Column<int>(type: "int", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseSessions", x => x.IntId);
                    table.ForeignKey(
                        name: "FK_CourseSessions_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "IntId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Discounts",
                columns: table => new
                {
                    IntId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DiscountCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiscountPercent = table.Column<int>(type: "int", nullable: false),
                    EventId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    CourseId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Discounts", x => x.IntId);
                    table.ForeignKey(
                        name: "FK_Discounts_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "IntId");
                    table.ForeignKey(
                        name: "FK_Discounts_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "IntId");
                    table.ForeignKey(
                        name: "FK_Discounts_UserAccounts_UserId",
                        column: x => x.UserId,
                        principalTable: "UserAccounts",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ConsultingRequests",
                columns: table => new
                {
                    IntId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ConsultingType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Flname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Remark = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InsertDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    SuggestedDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FactHeadId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConsultingRequests", x => x.IntId);
                    table.ForeignKey(
                        name: "FK_ConsultingRequests_FactorHeads_FactHeadId",
                        column: x => x.FactHeadId,
                        principalTable: "FactorHeads",
                        principalColumn: "IntId");
                    table.ForeignKey(
                        name: "FK_ConsultingRequests_UserAccounts_UserId",
                        column: x => x.UserId,
                        principalTable: "UserAccounts",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "FactorRows",
                columns: table => new
                {
                    IntId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Remark = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FactorHeadId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FactorRows", x => x.IntId);
                    table.ForeignKey(
                        name: "FK_FactorRows_FactorHeads_FactorHeadId",
                        column: x => x.FactorHeadId,
                        principalTable: "FactorHeads",
                        principalColumn: "IntId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "JunctionTables",
                columns: table => new
                {
                    IntId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FactorHeadId = table.Column<int>(type: "int", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JunctionTables", x => x.IntId);
                    table.ForeignKey(
                        name: "FK_JunctionTables_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "IntId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JunctionTables_FactorHeads_FactorHeadId",
                        column: x => x.FactorHeadId,
                        principalTable: "FactorHeads",
                        principalColumn: "IntId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TradeOrders",
                columns: table => new
                {
                    IntId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Side = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CryptoId = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Volume = table.Column<double>(type: "float", nullable: true),
                    OfferPrice = table.Column<double>(type: "float", nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    Flname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InsertDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FactureHeadId = table.Column<int>(type: "int", nullable: true),
                    WalletAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TypeWallet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MakingWallet = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TradeOrders", x => x.IntId);
                    table.ForeignKey(
                        name: "FK_TradeOrders_Cryptos_CryptoId",
                        column: x => x.CryptoId,
                        principalTable: "Cryptos",
                        principalColumn: "IntId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TradeOrders_FactorHeads_FactureHeadId",
                        column: x => x.FactureHeadId,
                        principalTable: "FactorHeads",
                        principalColumn: "IntId");
                    table.ForeignKey(
                        name: "FK_TradeOrders_UserAccounts_UserId",
                        column: x => x.UserId,
                        principalTable: "UserAccounts",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UserBills",
                columns: table => new
                {
                    IntId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    FactHeadId = table.Column<int>(type: "int", nullable: true),
                    Bed = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Bes = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BankOrderId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rest = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransactionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsOk = table.Column<bool>(type: "bit", nullable: false),
                    CryptoId = table.Column<int>(type: "int", nullable: true),
                    Withdrawal = table.Column<bool>(type: "bit", nullable: true),
                    OriginWallet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Memo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaymentGetway = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserBills", x => x.IntId);
                    table.ForeignKey(
                        name: "FK_UserBills_Cryptos_CryptoId",
                        column: x => x.CryptoId,
                        principalTable: "Cryptos",
                        principalColumn: "IntId");
                    table.ForeignKey(
                        name: "FK_UserBills_FactorHeads_FactHeadId",
                        column: x => x.FactHeadId,
                        principalTable: "FactorHeads",
                        principalColumn: "IntId");
                    table.ForeignKey(
                        name: "FK_UserBills_UserAccounts_UserId",
                        column: x => x.UserId,
                        principalTable: "UserAccounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserEvents",
                columns: table => new
                {
                    IntId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EventId = table.Column<int>(type: "int", nullable: false),
                    CellPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Remark = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    FactHeadId = table.Column<int>(type: "int", nullable: false),
                    InsertDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserEvents", x => x.IntId);
                    table.ForeignKey(
                        name: "FK_UserEvents_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "IntId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserEvents_FactorHeads_FactHeadId",
                        column: x => x.FactHeadId,
                        principalTable: "FactorHeads",
                        principalColumn: "IntId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserEvents_UserAccounts_UserId",
                        column: x => x.UserId,
                        principalTable: "UserAccounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ContentId",
                table: "Comments",
                column: "ContentId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ParentId",
                table: "Comments",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_UserAccountId",
                table: "Comments",
                column: "UserAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_ConsultingRequests_FactHeadId",
                table: "ConsultingRequests",
                column: "FactHeadId");

            migrationBuilder.CreateIndex(
                name: "IX_ConsultingRequests_UserId",
                table: "ConsultingRequests",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Contents_AuthorUserAccountId",
                table: "Contents",
                column: "AuthorUserAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Contents_ContentTypeId",
                table: "Contents",
                column: "ContentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ContentUserAccountEmails_ContentId",
                table: "ContentUserAccountEmails",
                column: "ContentId");

            migrationBuilder.CreateIndex(
                name: "IX_ContentUserAccountEmails_UserAccountId",
                table: "ContentUserAccountEmails",
                column: "UserAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_TeacherId",
                table: "Courses",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseSessions_CourseId",
                table: "CourseSessions",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Discounts_CourseId",
                table: "Discounts",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Discounts_EventId",
                table: "Discounts",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_Discounts_UserId",
                table: "Discounts",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_FactorHeads_UserId",
                table: "FactorHeads",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_FactorRows_FactorHeadId",
                table: "FactorRows",
                column: "FactorHeadId");

            migrationBuilder.CreateIndex(
                name: "IX_JunctionTables_CourseId",
                table: "JunctionTables",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_JunctionTables_FactorHeadId",
                table: "JunctionTables",
                column: "FactorHeadId");

            migrationBuilder.CreateIndex(
                name: "IX_TradeOrders_CryptoId",
                table: "TradeOrders",
                column: "CryptoId");

            migrationBuilder.CreateIndex(
                name: "IX_TradeOrders_FactureHeadId",
                table: "TradeOrders",
                column: "FactureHeadId");

            migrationBuilder.CreateIndex(
                name: "IX_TradeOrders_UserId",
                table: "TradeOrders",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserBills_CryptoId",
                table: "UserBills",
                column: "CryptoId");

            migrationBuilder.CreateIndex(
                name: "IX_UserBills_FactHeadId",
                table: "UserBills",
                column: "FactHeadId");

            migrationBuilder.CreateIndex(
                name: "IX_UserBills_UserId",
                table: "UserBills",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserEvents_EventId",
                table: "UserEvents",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_UserEvents_FactHeadId",
                table: "UserEvents",
                column: "FactHeadId");

            migrationBuilder.CreateIndex(
                name: "IX_UserEvents_UserId",
                table: "UserEvents",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Wallets_CryptoId",
                table: "Wallets",
                column: "CryptoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "ConsultingRequests");

            migrationBuilder.DropTable(
                name: "ContentUserAccountEmails");

            migrationBuilder.DropTable(
                name: "CourseSessions");

            migrationBuilder.DropTable(
                name: "Discounts");

            migrationBuilder.DropTable(
                name: "DollarPriceHistories");

            migrationBuilder.DropTable(
                name: "Exchanges");

            migrationBuilder.DropTable(
                name: "FactorRows");

            migrationBuilder.DropTable(
                name: "Hacks");

            migrationBuilder.DropTable(
                name: "Icos");

            migrationBuilder.DropTable(
                name: "JunctionTables");

            migrationBuilder.DropTable(
                name: "Listings");

            migrationBuilder.DropTable(
                name: "Settings");

            migrationBuilder.DropTable(
                name: "Stops");

            migrationBuilder.DropTable(
                name: "TinyPngApiKeys");

            migrationBuilder.DropTable(
                name: "TradeOrders");

            migrationBuilder.DropTable(
                name: "UserBills");

            migrationBuilder.DropTable(
                name: "UserEvents");

            migrationBuilder.DropTable(
                name: "Wallets");

            migrationBuilder.DropTable(
                name: "Contents");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "FactorHeads");

            migrationBuilder.DropTable(
                name: "Cryptos");

            migrationBuilder.DropTable(
                name: "ContentTypes");

            migrationBuilder.DropTable(
                name: "UserAccounts");
        }
    }
}
