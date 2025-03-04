using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractionödevi.maashesaplama
{
    abstract class Calisan : IMaas
    {
        public string Ad { get; set; }
        public abstract decimal MaasinizNedir();
    }
}
