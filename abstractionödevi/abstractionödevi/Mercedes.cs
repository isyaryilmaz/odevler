using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractionödevi
{
     public class Mercedes:IHareket
    {
        public void Git()
        {
            Console.WriteLine("Mercedes normal hızda gider.");
        }

        public void Yuz()
        {
            Console.WriteLine("Mercedes denizde yüzer.");
        }

        public void Uc()
        {
            Console.WriteLine("Mercedes havada uçar.");
        }
    }

}

