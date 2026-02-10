namespace Diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // definition & initialization & assignment
            int[] numbers = { 3, 5, 7, 8, 10, };

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Numbers[{i}] = " +
                    $"{numbers[i]}");
            }
            Console.ReadKey();
        }
    }
}
