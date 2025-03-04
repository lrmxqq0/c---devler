using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Mercedes : Ozellık
    {
        public void DenizdeYuzme()
        {
            Console.WriteLine("mercedes denizde yüzebilir");
        }

        public void HavadaUcma()
        {
            Console.WriteLine("mercedes havada uçabilir");
        }

        public void CokHizliGitme()
        {
            Console.WriteLine("mercedes çok hızlı gitmez");
        }
    }
}
