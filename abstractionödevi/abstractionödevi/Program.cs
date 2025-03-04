// See https://aka.ms/new-console-template for more information
using abstractionödevi;
using abstractionödevi.maashesaplama;

Console.WriteLine("Hello, World!");


   
        IHareket bmw = new BMW();
        IHareket mercedes = new Mercedes();
        IHareket porsche = new Porsche();

      
        Console.WriteLine("BMW Hareketleri:");
        bmw.Git();
        bmw.Yuz();
        bmw.Uc();

        
        Console.WriteLine("\nMercedes Hareketleri:");
        mercedes.Git();
        mercedes.Yuz();
        mercedes.Uc();

        Console.WriteLine("\nPorsche Hareketleri:");
        porsche.Git();
        porsche.Yuz();
        porsche.Uc();






  
        List<Calisan> calisanlar = new List<Calisan>
        {
            new GenelMudur { Ad = "Ahmet" },
            new Mudur { Ad = "Mehmet" },
            new Programci { Ad = "Zeynep" },
            new Stajyer { Ad = "Ali" }
        };

        decimal toplamMaas = 0;

        Console.WriteLine("Çalışan Maaş Listesi:\n");
        foreach (var calisan in calisanlar)
        {
            decimal maas = calisan.MaasinizNedir();
            Console.WriteLine($"{calisan.Ad} - {calisan.GetType().Name}: {maas:C}");
            toplamMaas += maas;
        }

        Console.WriteLine("\nToplam Ödenecek Maaş: " + toplamMaas.ToString("C"));





//Array(dizi): aynı türde birden fazla veriyi tek bir değişken altında saklamak için kullanılan bir veri yapısıdır. Diziler, bellekte ardışık olarak saklanır ve elemanlara indeks numarasıyla erişilir.
