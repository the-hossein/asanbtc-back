using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.Contract;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace asanbtc_api.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    public class ContentController : Controller
    {
        private readonly IContentService _content;
        public ContentController(IContentService content)
        {
            _content = content;
        }

        // GET: api/values
        [HttpGet(nameof(GetConfirmContent)), AllowAnonymous]
        public async Task<ActionResult> GetConfirmContent()
        {
            var AllContents = (await _content.FindAll());
            return Ok(new ResultModel()
            {
                Code = Ok().StatusCode,
                Data = AllContents,
                Message = "Get Contents was successfully"
            });
        }


        [HttpPost(nameof(CreateContent)), Authorize(Policy = "Admin")]
        public async Task<ActionResult> CreateContent([FromBody] CreateContentViewModel model)
        {
            DataLayer.Entities.Content NewContent = new DataLayer.Entities.Content()
            {
                AdLocation = model.AdLocation,
                AuthorUserAccountId = model.AuthorUserAccountId,
                Confirmed = model.Confirmed,
                ContentText = model.ContentText,
                ContentTypeId = model.ContentTypeId,
                DisLikeNum = model.DisLikeNum,
                EnglishTitr = model.EnglishTitr,
                ExpireDate = model.ExpireDate,
                Favorite = model.Favorite,
                InsertDate = DateTime.Now,
                Keyword = model.Keyword,
                LastUpdate = DateTime.Now,
                Label = model.Label,
                Lead = model.Lead,
                LikeNum = model.LikeNum,
                NewsPaper = model.NewsPaper,
                VideoFile = model.VideoFile,
                PicAlt = model.PicAlt,
                PicFile = model.PicFile,
                ReleaseTime = model.ReleaseTime,
                ShowLocation = model.ShowLocation,
                SourceLink = model.SourceLink,
                SourceTitle = model.SourceTitle,
                Telegram = model.Telegram,
                TelegramSent = model.TelegramSent,
                Titr = model.Titr,
                Title = model.Title,
                VisitNo = model.VisitNo,
            };

            try
            {
                var Result = await _content.Create(NewContent);
                if (Result != null)
                {
                    return Ok(new ResultModel()
                    {
                        Code = Ok().StatusCode,
                        Data = Result,
                        Message = "Successfully"
                    });
                }
                else
                {
                    return BadRequest(new ResultModel()
                    {
                        Code = BadRequest().StatusCode,
                        Data = null,
                        Message = "Operation Faild"
                    }); ;
                }
            }
            catch
            {
                return BadRequest(new ResultModel()
                {
                    Code = BadRequest().StatusCode,
                    Data = null,
                    Message = "Operation Faild"
                });
            }
        }
    }


}


