namespace MutlakDeger
{
    internal class Program
    {
        static void Main(string[] args)
        {
          int n = Convert.ToInt32(Console.ReadLine());
            if (n < 0) { 
                Console.WriteLine($"|{n}| = {n*-1}");
            } else {
                Console.WriteLine($"|{n}| = {n}");
            }
            Console.ReadKey();

        }
    }
}
