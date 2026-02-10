namespace Metotlar4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var odenecekMiktar = SatisYap(100);
            Console.WriteLine("{0,5:0.##}", odenecekMiktar);

            var odenecekMiktar2 = SatisYap(100, .2);
            Console.WriteLine("{0,5:0.##}", odenecekMiktar2);

            Console.ReadKey();
        }
        /// <summary>
        /// Şatış yapan fonksiyon
        /// </summary>
        /// <param name="miktar">Alış-veriş tutarı</param>
        /// <returns>KDV eklendiğinde ödenecek tutar</returns>
        private static double SatisYap(double miktar)
        {
            return miktar * 1.18;
        }

        /// <summary>
        /// Şatış yapan fonksiyon
        /// </summary>
        /// <param name="miktar">Alış-veriş tutarı</param>
        /// <param name="indirim">İndirim oranı</param>
        /// <returns>KDV eklendiğinde ödenecek tutar</returns>
        private static double SatisYap(double miktar , double indirim)
        {
            return (miktar * (1.0 - indirim)) * 1.18;
        }
    }
}
