using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Core.DTO
{
    public class LoginDTO
    {
        public string Username { get; set; } = null!;

        public int Loginid { get; set; }

        public string? Token { get; set; } 

        public int Roleid { get; set; }
    }
}
