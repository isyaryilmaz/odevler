// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



        Random random = new Random();
        int bilgisayarSayisi = random.Next(1, 101); 
        int kullaniciTahmini;
        int tahminSayisi = 0;

        Console.WriteLine("Bilgisayar 1 ile 100 arasında bir sayı tuttu. Tahmin etmeye çalışın!");
        do
        {
            Console.Write("Tahmininizi girin: ");
            kullaniciTahmini = int.Parse(Console.ReadLine());
            tahminSayisi++;

            if (kullaniciTahmini < bilgisayarSayisi)
            {
                Console.WriteLine("Tahmininiz küçük. Tekrar deneyin!");
            }
            else if (kullaniciTahmini > bilgisayarSayisi)
            {
                Console.WriteLine("Tahmininiz büyük. Tekrar deneyin!");
            }
            else
            {
                Console.WriteLine("Tebrikler! Doğru tahmin ettiniz.");
                Console.WriteLine("Toplam tahmin sayınız: " + tahminSayisi);
            }

        } while (kullaniciTahmini != bilgisayarSayisi); 
  
