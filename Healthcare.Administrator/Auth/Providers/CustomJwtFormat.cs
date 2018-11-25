using Microsoft.Owin.Security;
using Microsoft.Owin.Security.DataHandler.Encoder;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using Thinktecture.IdentityModel.Tokens;
using System.IdentityModel.Tokens;
using System.Text;
using System.IdentityModel.Tokens.Jwt;

namespace Healthcare.Administrator.Providers
{
    /// <summary>
    /// CustomJwtFormat class
    /// Generates the Token by validating
    /// the username and password
    /// </summary>
    public class CustomJwtFormat : ISecureDataFormat<AuthenticationTicket>
    {
        /// <summary>
        /// The _issuer field
        /// </summary>
        private readonly string _issuer;
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="issuer"></param>
        public CustomJwtFormat(string issuer)
        {
            _issuer = issuer;
        }
        /// <summary>
        /// Issues the token by validating
        /// the user and password and validating
        /// the role assigned to the user
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public string Protect(AuthenticationTicket data)
        {
            if (data == null)
            {
                throw new ArgumentNullException("data");
            }

            var audienceId = ConfigurationManager.AppSettings["as:AudienceId"];

            var symmetricKeyAsBase64 = ConfigurationManager.AppSettings["as:AudienceSecret"];

            var keyByteArray = TextEncodings.Base64Url.Decode(symmetricKeyAsBase64);

            var signingKey = new HmacSigningCredentials(keyByteArray);

            var issued = data.Properties.IssuedUtc;

            var expires = data.Properties.ExpiresUtc;

            // var token = new JwtSecurityToken((_issuer, audienceId, data.Identity.Claims, issued.Value.UtcDateTime,
            // expires.Value.UtcDateTime, signingKey);

            // var stringName = token.Payload.Where(i => i.Key == "nameid").Select(i => i.Value).FirstOrDefault();


            //var handler = new JwtSecurityTokenHandler();

            //var jwt = handler.WriteToken(token);

            // Write the Jwt Token 
            //return jwt;

            // Define const Key this should be private secret key  stored in some safe place
           // string key = "401b09eab3c013d4ca54922bb802bec8fd5318192b0a75f201d8b3727429090fb337591abd3e44453b954555b7a0812e1081c39b740293f765eae731f5a65ed1";

            // Create Security key  using private key above:
            // not that latest version of JWT using Microsoft namespace instead of System
            var securityKey = new Microsoft
               .IdentityModel.Tokens.SymmetricSecurityKey(Encoding.UTF8.GetBytes(symmetricKeyAsBase64));

            // Also note that securityKey length should be >256b
            // so you have to make sure that your private key has a proper length
            //
            var credentials = new Microsoft.IdentityModel.Tokens.SigningCredentials
                              (securityKey, SecurityAlgorithms.HmacSha256Signature);

            //  Finally create a Token
            var header = new JwtHeader(credentials);

            //Some PayLoad that contain information about the  customer
            var payload = new JwtPayload
           {
               { "some ", "hello "},
               { "scope", "http://dummy.com/"},
           };

            //
            var secToken = new JwtSecurityToken(header, payload);
            var handler = new JwtSecurityTokenHandler();

            // Token to String so you can use it in your client
            var tokenString = handler.WriteToken(secToken);

            return tokenString;
        }
        /// <summary>
        /// Unprotects the token
        /// </summary>
        /// <param name="protectedText"></param>
        /// <returns></returns>
        public AuthenticationTicket Unprotect(string protectedText)
        {
            throw new NotImplementedException();
        }
    }
}