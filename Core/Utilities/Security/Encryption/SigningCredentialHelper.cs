using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Security.Encryption
{
    //jwp servislerinin oluşturulabilmesi için sisteme girmek için elimizdeki olanlar 
    public class SigningCredentialHelper
    {
        public static SigningCredentials CreateSigningCredentials(SecurityKey securityKey)
        {
            //anahtar olarak sen securityKeyi kullan şifreleme olarakta gğvenlik algoritması sha512 kullan
            return new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha512Signature);
        }
    }
}
