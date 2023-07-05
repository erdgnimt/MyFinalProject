using Core.Entities.Concrete;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi!";
        public static string ProductListed= " Ürünler listelendi!";
        public static string MaintenanceTime="Sistem bakımda!";
        public static string CategoryListed="Kategoriler listelendi!";
        public static string CategoryAdded="Kategori eklendi!";
        public static string ProductCountOfCategoryError="Bu kategoriye daha fazla ürün eklenemez!";
        public static string ProductNameAlreadyExists="Aynı isimde ürün zaten var!";
        public static string CategoryLimitExceded="Kategori sayısı aşıldı, yeni ürün eklenemez! ";
        public static string AuthorizationDenied="Yetkiniz yok!";
        public static string UserRegistered="Kayıt başarılı!";
        public static string UserNotFound ="Kullanıcı bulunamadı!";
        public static string PasswordError ="Şifre hatalı!";
        public static string SuccessfulLogin="Başarılı giriş!";
        public static string UserAlreadyExists="Böyle bir kullanıcı mevcut!";
        public static string AccessTokenCreated="Token oluşturuldu!";
    }
}
