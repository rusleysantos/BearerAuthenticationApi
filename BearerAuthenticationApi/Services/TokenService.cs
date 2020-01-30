using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Claims;
using BearerAuthenticationApi.Models;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.Extensions.Configuration;
using System.Text;

namespace BearerAuthenticationApi.Services
{
    public class TokenService
    {
        private IConfiguration _conf { get; }
        public TokenService(IConfiguration configuration)
        {
            _conf = configuration;
        }

        public string GenerateToken(User user)
        {
            var tokenHendler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_conf.GetValue<string>("Key"));
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, user.Username.ToString()),
                    //new Claim(ClaimsIdentity.role)

                }),

            };

           // tokenHendler.CreateToken();

            return "";
        }
    }
}
