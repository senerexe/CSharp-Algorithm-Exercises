namespace DongulerWhıle2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayac = 10;
            while (sayac>0)
            {
                Console.WriteLine("{0,-3} {1,-3}", sayac, sayac * sayac);
                sayac -= 1;
            }
            Console.ReadKey();
        }
    }
}
