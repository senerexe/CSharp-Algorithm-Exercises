namespace DongulerDoWhıle
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int n = Convert.ToInt32(Console.ReadLine());
              int i = 2;
            do
            {
                Console.Write("{0,3}", i);
                i += 2;
            }
            while (i<n);
            Console.ReadKey();
        }
      
    }
}
