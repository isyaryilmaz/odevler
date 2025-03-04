// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


   
        
        int[] sayilar = new int[5];
        int toplam = 0;
        Console.WriteLine("Lütfen 5 tane sayı giriniz:");

        for (int i = 0; i < 5; i++)
        {
            Console.Write("Sayı " + (i + 1) + ": ");
            sayilar[i] = int.Parse(Console.ReadLine());
        }
        foreach (var sayi in sayilar)
        {
            toplam += sayi; 
        }
        double ortalama = (double)toplam / 5;
        Console.WriteLine("Toplam: " + toplam);
        Console.WriteLine("Ortalama: " + ortalama);
    

