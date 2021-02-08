using Bildirim.App.Migrations;
using Bildirim.Common;
using Bildirim.Common.Auth;
using Bildirim.Infrastructure.Main.Repositories.Interfaces.Authorization;
using System;
using System.Security.Claims;
using System.Text;
using System.IdentityModel.Tokens.Jwt;
using System.Collections.Generic;
using Microsoft.IdentityModel.Tokens;

namespace Bildirim.Infrastructure.Main.Repositories.Impl.Authorization
{
    class TokenRepository : ITokenRepository
    {
        private readonly BildirimContext context;
        private readonly ApplicationConfig _appConfig;

        public TokenRepository(BildirimContext context, ApplicationConfig appConfig)
        {
            this.context = context;
            _appConfig = appConfig;
        }

        public string GetToken(JwtPayLoad payload)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appConfig.JWTSecretKey);

            var claims = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.Sid, payload.UserId.ToString()),
                new Claim(ClaimTypes.Name, payload.Name),
                new Claim(ClaimTypes.Surname, payload.LastName),
                new Claim(ClaimTypes.Email, payload.Email),
                new Claim(ClaimTypes.Role, $"{payload.RoleId}.{payload.Role}")
            };

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.UtcNow.Add(_appConfig.TokenLifetime),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);

            return tokenHandler.WriteToken(token);
        }

        public ClaimsPrincipal ValidateToken(string jwtToken)
        {
            if (string.IsNullOrEmpty(jwtToken))
                return null;

            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appConfig.JWTSecretKey);

            var validations = new TokenValidationParameters
            {
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(key),
                ValidateIssuer = false,
                ValidateAudience = false
            };

            var claims = tokenHandler.ValidateToken(jwtToken, validations, out var tokenSecure);

            return new ClaimsPrincipal(claims);
        }
    }
}
