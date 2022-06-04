using System;
using System.Collections.Generic;
using System.Text;

namespace ChessHelper.Domain.Entities
{
    public class Authentication
    {
        public string Login { get; set; }
        public string Password { get; set; }

/*        public Authentication(string login, string password)
        {
            this.Login = login;
            this.Password = password;
        }*/
    }
}
