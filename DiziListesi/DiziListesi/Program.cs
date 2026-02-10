using System.Collections;

namespace DiziListesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Definition
            var arrayList = new ArrayList()
            {
                10,"Bursa",true,'f'
            };
            /* Add
            ArrayList.Add(10); // boxing
            ArrayList.Add("Bursa");
            ArrayList.Add(true);
            ArrayList.Add('f');
            */

            // Count
            foreach (var e in arrayList)
            {
                Console.Write($"{e} ");
            }
            int[] numbers = new int[] { 1, 2, 3, 4, 5 };
            arrayList.AddRange(numbers);

            Console.WriteLine();
            foreach (var e in arrayList)
            {
                Console.Write($"{e} ");
            }
            Console.WriteLine();
            // Access element
            Console.WriteLine(arrayList[3]);

            // Access Element-Assign
            var x = (int)arrayList[0]; // unboxing
            Console.WriteLine(x);

            // Delete Element
            arrayList.Remove(10);
            arrayList.RemoveAt(2);
            arrayList.RemoveRange(3, 3);

            Console.WriteLine();
            foreach (var e in arrayList)
            {
                Console.Write($"{e} ");
            }
            Console.ReadKey();
        }
    }
}
