using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Logging;
using Microsoft.IdentityModel.Tokens;
using Basecode.WebApp.Authentication;
using Basecode.Data;
using Basecode.Data.Models;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Basecode.Data.ViewModels.Common;

namespace Basecode.WebApp.Utilities
{
    public class GetAuthResponse
    {
        /// <summary>
        ///     Retrieves token options from appconfig.json 
        /// </summary>
        /// <returns></returns>
        public static TokenProviderOptions GetOptions()
        {
            var signingKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(Configuration.Config.GetSection("Basecode:AuthSecretKey").Value));

            return new TokenProviderOptions
            {
                Path = Configuration.Config.GetSection("Basecode:TokenPath").Value,
                Audience = Configuration.Config.GetSection("Basecode:Audience").Value,
                Issuer = Configuration.Config.GetSection("Basecode:Issuer").Value,
                Expiration = TimeSpan.FromMinutes(Convert.ToInt32(Configuration.Config.GetSection("Basecode:ExpirationMinutes").Value)),
                SigningCredentials = new SigningCredentials(signingKey, SecurityAlgorithms.HmacSha256)
            };
        }

        /// <summary>
        ///     Handles token generation for access and refresh tokens
        /// </summary>
        /// <param name="identity"></param>
        /// <param name="db"></param>
        /// <param name="userName"></param>
        /// <param name="refreshToken"></param>
        /// <returns></returns>
        public static LoginViewModel Execute(ClaimsIdentity identity, BasecodeContext db, IdentityUser userName, RefreshToken refreshToken = null)
        {
            var options = GetOptions();
            var now = DateTime.UtcNow;


            if (refreshToken == null)
            {
                refreshToken = new RefreshToken()
                {
                    Username = userName.UserName,
                    Token = Guid.NewGuid().ToString("N"),
                };
                db.InsertNew(refreshToken);
            }

            refreshToken.IssuedUtc = now;
            refreshToken.ExpiresUtc = now.Add(options.Expiration);
            db.SaveChanges();

            var jwt = new JwtSecurityToken(
                issuer: options.Issuer,
                audience: options.Audience,
                claims: identity.Claims,
                notBefore: DateTime.UtcNow,
                expires: DateTime.UtcNow.Add(options.Expiration),
                signingCredentials: options.SigningCredentials
            );

            IdentityModelEventSource.ShowPII = true;

            var encodedJwt = new JwtSecurityTokenHandler().WriteToken(jwt);

            var response = new LoginViewModel
            {
                access_token = encodedJwt,
                refresh_token = refreshToken.Token,
                expires_in = (int)options.Expiration.TotalSeconds,
            };
            return response;
        }
    }
}