
using ConsoleApp3;

class Program
{
    static void Main(string[] args)
    {
      
        Ozellık bmw = new BMW();
        Ozellık mercedes = new Mercedes();
        Ozellık porsche = new porsche();

        
        Console.WriteLine("bmw özellikleri:");
        bmw.DenizdeYuzme();
        bmw.HavadaUcma();
        bmw.CokHizliGitme();

        Console.WriteLine("mercedes özellikleri:");
        mercedes.DenizdeYuzme();
        mercedes.HavadaUcma();
        mercedes.CokHizliGitme();

        Console.WriteLine("porsche özellikleri:");
        porsche.DenizdeYuzme();
        porsche.HavadaUcma();
        porsche.CokHizliGitme();
    }
}