using ClassLibrary.Core.Data;
using ClassLibrary.Core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Core.repository
{
    public interface IAuthRepo
    {
        public LoginDTO Login(Login login);
    }
}
