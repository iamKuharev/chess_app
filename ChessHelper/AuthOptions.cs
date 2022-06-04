using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Tokens;

namespace ChessHelper
{
    public class AuthOptions
    {
        public const string ISSUER = "ChessHelperServer"; // издатель токена
        public const string AUDIENCE = "ChessHelperClient"; // потребитель токена
        const string KEY = "mysupersecret_secretkey!macbookSosat";   // ключ для шифрации
        public const int LIFETIME = 60; // время жизни токена - 1 минута
        public static SymmetricSecurityKey GetSymmetricSecurityKey()
        {
            return new SymmetricSecurityKey(Encoding.ASCII.GetBytes(KEY));
        }
    }
}
