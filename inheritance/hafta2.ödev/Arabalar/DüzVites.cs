using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hafta2.ödev.Arabalar
{
    public class DüzVites:Araba
    {
        public String sifat;
        public String cins;

        public void DüzVitesOku(String marka,String model,String sifat,String cins)
        {
            Console.WriteLine(marka + " markasının " + model + " modeli " + sifat + " ve " +  cins );
        }
    }
}
