using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstarctionödev3BenzinHesaplama
{
    abstract class Araba:IYakitTuketimi
    {
        public string Marka { get; set; }
        public abstract double YakitTuketimiHesapla();
    }
}
