// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


 
       
        Console.Write("Birinci sayıyı girin: ");
        int sayi1 = int.Parse(Console.ReadLine()); 

        Console.Write("İkinci sayıyı girin: ");
        int sayi2 = int.Parse(Console.ReadLine());  

        
        Console.WriteLine("Yapmak istediğiniz işlemi seçin:");
        Console.WriteLine("1 - Toplama");
        Console.WriteLine("2 - Çıkarma");
        Console.WriteLine("3 - Çarpma");
        Console.WriteLine("4 - Bölme");

        int secim = int.Parse(Console.ReadLine());
        if (secim == 1)
        {
            int toplam = sayi1 + sayi2;
            Console.WriteLine("Toplam: " + toplam);
        }
        else if (secim == 2)
        {
            int fark = sayi1 - sayi2;
            Console.WriteLine("Fark: " + fark);
        }
        else if (secim == 3)
        {
            int carpim = sayi1 * sayi2;
            Console.WriteLine("Çarpım: " + carpim);
        }
        else if (secim == 4)
        {
            if (sayi2 != 0)
            {
                double bolum = (double)sayi1 / sayi2; 
                Console.WriteLine("Bölüm: " + bolum);
            }
            else
            {
                Console.WriteLine("Hata: Sıfıra bölme hatası!");
            }
        }
        else
        {
            Console.WriteLine("Geçersiz seçim!");
        }
    

