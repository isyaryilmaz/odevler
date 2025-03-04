using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractionödevi
{
    public class Porsche : IHareket
    {
        public void Git()
        {
            Console.WriteLine("Porsche kara yolunda gider.");
        }

        public void Yuz()
        {
            Console.WriteLine("Porsche denizde yüzemez.");
        }

        public void Uc()
        {
            Console.WriteLine("Porsche havada uçar.");
        }
    }
}

