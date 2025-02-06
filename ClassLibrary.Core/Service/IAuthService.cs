using ClassLibrary.Core.Data;
using ClassLibrary.Core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Core.Service
{
    public interface IAuthService
    {
        public string Login(Login login);

    }
}
