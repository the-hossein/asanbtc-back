using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using DataLayer.Enums;
using DataLayer.ViewModel;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using ServiceLayer.Contract;

namespace ServiceLayer.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IConfiguration _config;
        public AuthenticationService(IConfiguration _config)
        {
            this._config = _config;
        }

        public GetTokenViewModel GenerateToken(string userName, UserRole theUserRole)
        {
            var claims = new List<Claim>
                                {
                                    //new Claim(JwtRegisteredClaimNames.Sub, Guid.NewGuid().ToString()),
                                    new Claim(ClaimTypes.NameIdentifier, userName),
                                    new Claim(ClaimTypes.Role, theUserRole.ToString()),
                                };
            var authSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var token = new JwtSecurityToken(
                issuer: _config["Jwt:Issuer"],
                audience: _config["Jwt:Audience"],
                expires: DateTime.Now.AddHours(12),
                claims: claims,
                signingCredentials: new SigningCredentials(authSigningKey, SecurityAlgorithms.HmacSha256)
            );
            return new GetTokenViewModel()
            {
                Token = new JwtSecurityTokenHandler().WriteToken(token),
                TokenExpire = token.ValidTo,
            };
        }

        public string GetHashedPassword(string Password)
        {

            var utf8 = new UTF8Encoding();
            byte[] salt = utf8.GetBytes(Password + "AsanBTC");
            //new RNGCryptoServiceProvider().GetBytes(salt = new byte[salt.Count()]);
            var pbkdf2 = new Rfc2898DeriveBytes(Password, salt, 100000);
            byte[] hash = pbkdf2.GetBytes(20);
            //byte[] hashBytes = new byte[18];
            //Array.Copy(salt, 0, hashBytes, 0, 36);
            //Array.Copy(hash, 0, hashBytes, 16, 20);
            string savedPasswordHash = Convert.ToBase64String(hash);
            return savedPasswordHash;
        }
    }
}

