using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractionödevi
{
    public class BMW:IHareket
    {
        public void Git()
        {
            Console.WriteLine("BMW çok hızlı gider.");
        }

        public void Yuz()
        {
            Console.WriteLine("BMW denizde yüzer.");
        }

        public void Uc()
        {
            Console.WriteLine("BMW havada uçar.");
        }
    }
}

