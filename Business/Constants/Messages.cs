using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string CategoryAdded = "Kategori Eklendi";
        public static string CategoryInvalidFields = "Eksik Alan Girdiniz";
        public static string MaintenanceTime="sistem bakımda";
        public static string ProductsListed="ürünler listelendi";
        public static string UserRegisterSuccess="Kullanıcı Başarıyla Kayıt oldu";
        public static string UserInvalidFields="Eksik Alan Girdiniz";
        public static string UserInvalidEmail="Email Sistemde Kayıtlı";
        public static string UserLoginSuccess="Giriş Başarılı";
        public static string UserLoginError= "Hatalı Giriş";
    }
}