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

        public static string AuthorizationDenied = "";

        public static string UserRegistered = "";
        public static string UserNotFound = "";
        public static string PasswordError = "";
        public static string SuccessfulLogin = "";
        public static string UserAlreadyExists = "";
        public static string AccessTokenCreated = "";
    }
}
