using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace FoodBoard.Features.Authorization
{
    public interface ITokenGenerator
    {
        string GenerateToken(string userId);
    }
    public class TokenGenerator : ITokenGenerator
    {
        private readonly IConfiguration _config;

        public TokenGenerator(IConfiguration config)
        {
            _config = config;
        }

        public string GenerateToken(string userId)
        {
            var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["SecretKey"]));
            var signinCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);
            var tokenOptions = new JwtSecurityToken(
                claims: new[] { new Claim("id", userId) },
                expires: DateTime.UtcNow.AddHours(1),
                signingCredentials: signinCredentials);
            return new JwtSecurityTokenHandler().WriteToken(tokenOptions);
        }
    }
}
