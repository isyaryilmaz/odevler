using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    namespace MatematikIslemleri
    {
        public class Hesaplama
        {
            public void Topla(int sayi1, int sayi2)
            {
                Console.WriteLine("Toplama Sonucu: " + (sayi1 + sayi2));
            }

            // Çarpma işlemi yapan metot
            public void Carp(int sayi1, int sayi2)
            {
                Console.WriteLine("Çarpma Sonucu: " + (sayi1 * sayi2));
            }
        }
    }

