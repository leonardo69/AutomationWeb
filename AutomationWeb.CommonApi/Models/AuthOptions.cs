﻿using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace AutomationWeb.Common.Api.Models
{
    public class AuthOptions
    {
        public const string ISSUER = "MyAuthServer"; // издатель токена
        public const string AUDIENCE = "MyAuthClient"; // потребитель токена
        private const string KEY = "mysupersecret_secretkey!123"; // ключ для шифрации
        public const int LIFETIME = 1; // время жизни токена - 1 минута

        public static SymmetricSecurityKey GetSymmetricSecurityKey()
        {
            return new SymmetricSecurityKey(Encoding.ASCII.GetBytes(KEY));
        }
    }
}