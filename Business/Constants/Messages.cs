using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
  public static class Messages
    {
        public static string CarAdded = "Ürün eklendi";
        public static string CarNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string CarsListed="Ürünler listelendi";
        internal static string CarCountOfBrandError= "Bir markada en fazla 10 ürün olabilir.";
        internal static string CarNameAlreadyExists = "Bu isimde zaten başka bir ürün var.";
        internal static string BrandLimitExceded = "Marka limiti aşıldığı için yeni ürün eklenemiyor.";
    }
}
