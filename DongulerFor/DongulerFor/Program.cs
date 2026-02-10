namespace DongulerFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            for (int i = a; i <= b; i++)
            {
                if (i % 3 == 0)
                    continue;
                Console.WriteLine("{0,3}",i);
            }
            Console.ReadKey();
        }
    }
}
