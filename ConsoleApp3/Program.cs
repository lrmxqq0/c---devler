using ConsoleApp3;

class Program
{
    static void Main(string[] args)
    {
        
        List<Calisan> calisanlar = new List<Calisan>
        {
            new GenelMudur(),
            new Mudur(),
            new Programcı(),
            new Stajyer()
        };

        decimal toplamMaas = 0;
        foreach (var calisan in calisanlar)
        {
            toplamMaas += calisan.MaasinizNedir();
        }

        Console.WriteLine($"Toplam maaş: {toplamMaas} TL");
    }
}