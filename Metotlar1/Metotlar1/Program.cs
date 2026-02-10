namespace Metotlar1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int buyuk = Karsilastir(13,5);
            Console.WriteLine(buyuk);
            Console.ReadKey();
        }
            public static int Karsilastir(int A , int B)
        {
            return A > B ? A : B;
        }

    }
}
