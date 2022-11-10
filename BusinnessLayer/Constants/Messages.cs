using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BusinnessLayer.Constants
{
    public static class Messages
    {
        public static string AddedSuccess = "Araba eklenmiştir";
        public static string AddedError = "Karakter sayısı hatası";

        public static string CarPicturePieces = "En fazla 5 araba resmi olabilir";

        public static string AuthorizationDenied = "YetkilendirmeReddedildi";

        public static string UserRegistered = "Kullanıcı Kayıtlı";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Şifre Hatası";
        public static string SuccessfulLogin = "Başarılı Giriş";
        public static string UserAlreadyExists = "Kullanıcı zaten var";
        public static string AccessTokenCreated = "Erişim Simgesi Oluşturuldu";
    }
}
