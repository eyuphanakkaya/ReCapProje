using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Security.Hashing
{
    public class HashingHelper
    {
        //hash oluşturma
        //verdiğimiz password değerine göre salt ve hash değerini oluşturmaya çalışıyo
        public static void CreatePasswordHash(string password,out byte[] passwordHash,out byte[] passwordSalt)//passwordün hashini oluşturucak hash ve saltı da oluşturur
        {
            using (var hmac=new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key;//değişmeyen anahtar
                passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
        }
        //hash doğrulama
        //veritabanından gelen hash değerlerini kullanıcadan gelen değerlerle karşılaştırır
        public static bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512(passwordSalt))
            {
        var computedHash=hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
                for (int i = 0; i < computedHash.Length; i++)
                {
                    if (computedHash[i] != passwordHash[i])//veri tabanı değeri
                        //eğer ki veritabanından gelen değer birbirine eşit değilse
                    {
                        return false;
                    }
                    
                }
            }
            return true;
        }
    }
}
