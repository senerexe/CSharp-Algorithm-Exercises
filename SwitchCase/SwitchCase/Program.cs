namespace SwitchCase
{
    internal class Program
    {
        enum Islemler { Toplama, Cikarma, Carpma, Bolme }
        static void Main(string[] args)
        {
            int A = 10, B = 20;
            Islemler secim = (Islemler) ( new Random().Next(1,4));

            switch (secim)
            {
                case Islemler.Toplama:
                    Console.WriteLine("Toplama: " + (A + B));
                    break;
                case Islemler.Cikarma:
                    Console.WriteLine("Cikarma: " + (A - B));
                    break;
                case Islemler.Carpma:
                    Console.WriteLine("Carpma: " + (A * B));
                    break;
                case Islemler.Bolme:
                    Console.WriteLine("Bolme: " + (A / B));
                    break;
                default:
                    Console.WriteLine("Gecersiz Islem");
                    break;
            }
            Console.ReadKey();
        }
    }
}
