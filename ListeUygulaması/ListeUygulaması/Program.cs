namespace ListeUygulaması
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sehirler = new List<string>
            {
                "Ankara",
                "İstanbul",
                "Tekirdağ",
                "Giresun",
            };
            // Lambda expression =>
            sehirler.ForEach(sehir => Console.WriteLine(sehir));
            Console.WriteLine(new string('-',50));

            var iller = sehirler;
            sehirler.ForEach(iller => Console.WriteLine(iller));

            sehirler.Add("Bursa");
            sehirler.ForEach(sehir => Console.WriteLine(sehir));
            Console.WriteLine();
            iller.ForEach(iller => Console.WriteLine(iller));

            iller.Remove("Ankara");
            iller.ForEach(iller => Console.WriteLine(iller));
            Console.WriteLine();
            sehirler.ForEach(sehir => Console.WriteLine(sehir));

            Console.ReadKey();
        }
    }
}
