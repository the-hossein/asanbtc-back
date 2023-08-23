using System;
namespace DataLayer.ViewModel
{
    public class CreateContentViewModel
    {
        public int? Id { get; set; }

        public int ContentTypeId { get; set; }

        public string? Titr { get; set; }

        public string? Lead { get; set; }

        public string? ContentText { get; set; }

        public string? PicFile { get; set; }

        public DateTime? ReleaseTime { get; set; }

        public string? Label { get; set; }

        public bool Favorite { get; set; }

        public int VisitNo { get; set; }

        public bool Confirmed { get; set; }

        public bool Telegram { get; set; }

        public bool TelegramSent { get; set; }

        public string? Files { get; set; }

        public string? SourceTitle { get; set; }

        public string? SourceLink { get; set; }

        //[ForeignKey(nameof(UserAccount))]
        public int? AuthorUserAccountId { get; set; }

        public int LikeNum { get; set; }

        public int DisLikeNum { get; set; }

        public DateTime InsertDate { get; set; }

        public DateTime? LastUpdate { get; set; }

        public string? VideoFile { get; set; }

        public string? VoiceFile { get; set; }

        public DateTime? ExpireDate { get; set; }

        public bool NewsPaper { get; set; }

        public string? PicAlt { get; set; }

        public string? Keyword { get; set; }

        public string? Title { get; set; }

        public int? AdLocation { get; set; }

        public string? EnglishTitr { get; set; }

        public int ShowLocation { get; set; }


    }
}

