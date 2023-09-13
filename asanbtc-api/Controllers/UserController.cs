using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.Enums;
using DataLayer.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.Contract;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace asanbtc_api.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private readonly IUserAccountService _user;
        private readonly IAuthenticationService _auth;
        public UserController(IUserAccountService user, IAuthenticationService auth)
        {
            _user = user;
            _auth = auth;
        }
        // GET: api/values
        [HttpGet(nameof(GetAllUserAccount)), AllowAnonymous]
        public async Task<ActionResult> GetAllUserAccount()
        {
            var AllUser = (await _user.FindAll()).ToList();
            return Ok(new
            {
                data = AllUser
            });
        }

        [HttpPost(nameof(AdminLogin)), AllowAnonymous]
        public async Task<ActionResult> AdminLogin(LoginViewModel model)
        {
            var userHashedPassword = _auth.GetHashedPassword(model.Passwod);
            var theUser = await _user.FindByCondition(a => a.UserName == model.UserName && a.IsAdmin == true && a.IsActive == true & a.Pass == userHashedPassword);
            if (theUser != null)
            {
                var userToken = _auth.GenerateToken(theUser.UserName, UserRole.Admin);
                return Ok(new ResultModel()
                {
                    Code = Ok().StatusCode,
                    Data = new
                    {
                        token = userToken,
                        userName = theUser.UserName
                    },
                    Message = "Successfully"
                });
            }
            else
            {
                return NotFound(new ResultModel()
                {
                    Code = NotFound().StatusCode,
                    Data = null,
                    Message = "The user not found"
                });

            }


        }

        [HttpGet(nameof(GetAdminProfile)), Authorize(Policy = "Admin")]
        public async Task<ActionResult> GetAdminProfile(string userName)
        {
            var theUser = await _user.FindByCondition(a => a.UserName == userName && a.IsAdmin == true && a.IsActive == true);
            if (theUser != null)
            {

                return Ok(new ResultModel()
                {
                    Code = Ok().StatusCode,
                    Data = theUser,
                    Message = "Successfully"
                });
            }
            else
            {
                return NotFound(new ResultModel()
                {
                    Code = NotFound().StatusCode,
                    Data = null,
                    Message = "The user not found"
                });

            }
        }
    }
}


