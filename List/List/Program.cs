using System.Runtime.CompilerServices;

namespace List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tanımlama-Atama
            var sayilar = new List<int>() { 10, 15, 20 };
            int x = 55;
            // int [] Seri = new int[] {70, 80, 90};
            //Ekleme
            sayilar.Add(x);
            sayilar.AddRange(new int[] { 40, 50, 60 });
            // Araya Ekleme
            sayilar.Insert(3, 0);
            sayilar.InsertRange(4, new int[] { 80, 90 });
            //Silme
            sayilar.Remove(3);
            sayilar.RemoveAt(sayilar.IndexOf(55));
            //Dolaşma
            foreach (int s in sayilar)
            {
                Console.Write($"{s,-5}");
            }
            Console.ReadKey();
        }
    }
}
