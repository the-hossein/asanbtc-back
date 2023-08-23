using System;
using DataLayer.Enums;
using System.IdentityModel.Tokens.Jwt;
using DataLayer.ViewModel;

namespace ServiceLayer.Contract
{
    public interface IAuthenticationService
    {
        GetTokenViewModel GenerateToken(string userName, UserRole theUserRole);
        string GetHashedPassword(string Password);
    }

}

