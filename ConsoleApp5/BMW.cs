using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class BMW : Araba
    {
        public BMW()
        {
            Model = "BMW";
        }
        public override double YakitTuketimiHesapla()
        {
            return 80.0; 
        }
    }
}
