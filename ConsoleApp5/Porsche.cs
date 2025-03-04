using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Porsche : Araba
    {
        public Porsche()
        {
            Model = "Porsche";
        }

        public override double YakitTuketimiHesapla()
        {
            return 60.0;
        }
    }
}
