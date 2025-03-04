using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace erişimbelirleyiciler_ve_Değişkenler
{
    public class User
    {
        private string adSoyad;
        private int yas;

        // Public üye (dışarıdan erişilebilir)
        public string Email { get; set; }

        // Constructor ile değer atama
        public User(string adSoyad, int yas, string email)
        {
            this.adSoyad = adSoyad;
            this.yas = yas;
            this.Email = email;
        }

        // Getter ve Setter metodları (adSoyad ve yas için)
        public string GetAdSoyad()
        {
            return adSoyad;
        }

        public void SetAdSoyad(string adSoyad)
        {
            this.adSoyad = adSoyad;
        }

        public int GetYas()
        {
            return yas;
        }

        public void SetYas(int yas)
        {
            if (yas > 0)
            {
                this.yas = yas;
            }
            else
            {
                Console.WriteLine("Geçersiz yaş değeri.");
            }
        }

        // Bilgileri gösteren metod
        public void BilgileriGoster()
        {
            Console.WriteLine("Ad Soyad: " + adSoyad);
            Console.WriteLine("Yaş: " + yas);
            Console.WriteLine("Email: " + Email);
        }
    }
}
