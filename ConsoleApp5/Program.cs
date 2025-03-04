using ConsoleApp3;

class Program
{
    static void Main(string[] args)
    {
        
        List<Araba> arabalar = new List<Araba>
        {
            new BMW(),
            new Mercedes(),
            new Porsche()
        };

        double toplamYakit = 0;
        foreach (var araba in arabalar)
        {
            toplamYakit += araba.YakitTuketimiHesapla();
        }

        
        Console.WriteLine($"Toplam yakıt tüketimi: {toplamYakit} L");
    }
}
