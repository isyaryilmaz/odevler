// See https://aka.ms/new-console-template for more information
using abstarctionödev3BenzinHesaplama;

Console.WriteLine("Hello, World!");




List<Araba> arabalar = new List<Araba>
        {
            new BMW { Marka = "BMW" },
            new Mercedes { Marka = "Mercedes" },
            new Porsche { Marka = "Porsche" }
        };

double toplamYakit = 0;

Console.WriteLine("Araç Yakıt Tüketim Listesi:\n");
foreach (var araba in arabalar)
{
    double tuketim = araba.YakitTuketimiHesapla();
    Console.WriteLine($"{araba.Marka} - Yakıt Tüketimi: {tuketim} L");
    toplamYakit += tuketim;
}

Console.WriteLine($"\nToplam Yakıt Tüketimi: {toplamYakit} L");
