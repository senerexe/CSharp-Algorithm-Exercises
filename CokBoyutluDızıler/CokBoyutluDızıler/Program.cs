namespace CokBoyutluDızıler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array size: ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[size];

            var r = new Random();

            for (int i = 0; i < numbers.Length; i++)
                numbers[i] = r.Next(1, 10);

            foreach (var s in numbers)
            {
                Console.WriteLine($"{s,5} {s * s,5}");
            }
            Console.ReadKey();
        }

        
    }
}
