using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.IdentityModel.Tokens;


namespace ecommerce.Security.Auth
{
    public class TokenAuthOption
    {
        public static string Audience { get; } = "EcommerceAudience";
        public static string Issuer { get; } = "EcommerceIssuer";
        public static RsaSecurityKey Key { get; } = new RsaSecurityKey(RSAKeyHelper.GenerateKey());
        public static SigningCredentials SigningCredentials { get; } = new SigningCredentials(Key, SecurityAlgorithms.RsaSha256Signature);
        public static TimeSpan ExpiresSpan { get; } = TimeSpan.FromMinutes(60);
        public static string TokenType { get; } = "Bearer";
    }
}
