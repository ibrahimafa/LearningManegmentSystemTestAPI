using ClassLibrary.Core.Data;
using ClassLibrary.Core.DTO;
using ClassLibrary.Core.repository;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Infra.repository
{
    public class AuthRepo : IAuthRepo
    {
        LmsdemoDbContext lmsdemoDbContext;
        public AuthRepo(LmsdemoDbContext _lmsdemoDbContext) 
        {
            lmsdemoDbContext = _lmsdemoDbContext;

        }
        public LoginDTO Login(Login login)
        {
            var p = new[]
            {
                new SqlParameter("@UseraName", login.Username),
                new SqlParameter("@Pass" , login.Password)
            };

            var result = lmsdemoDbContext.Logins.FromSqlRaw("EXEC User_Login @UseraName,@Pass", p).SingleOrDefault();
            if (result == null) return null;


            //Mapping 
            return new LoginDTO
            {
                Username = result.Username,
                Roleid = (int)result.Roleid
            };
        }

    }
}
