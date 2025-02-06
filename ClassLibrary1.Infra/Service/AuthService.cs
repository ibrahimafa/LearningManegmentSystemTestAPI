using ClassLibrary.Core.Data;
using ClassLibrary.Core.DTO;
using ClassLibrary.Core.repository;
using ClassLibrary.Core.Service;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Infra.Service
{
    public class AuthService : IAuthService
    {
        IAuthRepo irepo;
        public AuthService(IAuthRepo _irepo)
        {
            irepo = _irepo;
        }
        
        public string Login(Login login)
        {
            var result= irepo.Login(login);
            if (result == null) return null;
            return GenerateJWTToken(result);

        }

        public string GenerateJWTToken(LoginDTO user)
        {

            //1- create secret key 
            var secertkey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("ewmmetricsecritkey123345"));


            var signingcredentials = new SigningCredentials(secertkey, SecurityAlgorithms.HmacSha256);


            //2- data payload 

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name,user.Username),
                new Claim(ClaimTypes.Role,user.Roleid.ToString())
            };


            //3- Create JWT Token With Options

            var tokenOption = new JwtSecurityToken(
                claims: claims,
                expires: DateTime.UtcNow.AddHours(24),
                signingCredentials: signingcredentials
                );
            return new JwtSecurityTokenHandler().WriteToken(tokenOption);
        }
    }
}
