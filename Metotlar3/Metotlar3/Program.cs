
namespace Metotlar3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0,5:0.##}",
                SeriToplami(5.52, 15.12, 25.54, 13.13));
            Console.ReadKey();
        }

        private static double SeriToplami(params double[] seri)
        {
            double toplam = 0;
            foreach (double s in seri)
                toplam += s;
               return toplam;
        }
    }
}
