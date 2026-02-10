namespace CokBoyutluDızıler2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[,] matris = new double[,]
            {
             {1,2,3,},
             {5,6,7,},
             {9,10,11,}
            };
            double toplam = 0;

            for (int i = 0; i < matris.GetLength(0); i++)
            {
                for (int j = 0; j < matris.GetLength(1); j++)
                {
                    if (i == j)
                        matris[i, j] = -1;
                    if (matris[i, j] % 2 == 0)
                        matris[i, j] = 0;
                    toplam += matris[i, j];
                    Console.Write($"{matris[i, j],5}");

                }
                Console.WriteLine();
            }
            Console.WriteLine($"Toplam: {toplam}");
            Console.ReadKey();
        }
    }
}
