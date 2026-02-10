namespace Metotlar2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var x = KareAl(3);
            double y = KareAl(x);

            Console.WriteLine(x);
            Console.WriteLine(y);

            Console.ReadKey();

        }

        static double KareAl(double sayi )
        {
            double kare = sayi * sayi;
            return kare;
        }
    }
}
