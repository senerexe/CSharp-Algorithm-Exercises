namespace BtkAkademi.Operatorler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A = 20, B = 10;

            // ARİTMATİK OPERATÖRLER
            Console.WriteLine(A+B);
            Console.WriteLine(A-B);
            Console.WriteLine(A*B);
            Console.WriteLine(A/B);
            Console.WriteLine(A%B);

            // İLİŞKİSEL OPERATÖRLER
            Console.WriteLine(A>B);
            Console.WriteLine(A<B);
            Console.WriteLine(A>=B);
            Console.WriteLine(A<=B);
            Console.WriteLine(A==B);
            Console.WriteLine(A!=B);

            Console.WriteLine(A>B && A<5);
            Console.WriteLine(A<B || B>5);

            Console.ReadKey();
        }
    }
}
