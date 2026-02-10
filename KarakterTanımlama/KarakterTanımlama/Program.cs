namespace KarakterTanımlama
{
    internal class Program
    {
        static void Main(string[] args)
        {
           var k = (char)Console.Read();
              if (char.IsLetter(k))
              {
                Console.WriteLine("Harf");
              }
              else if (char.IsDigit(k))
              {
                Console.WriteLine("Rakam");
              }
              else
              {
                Console.WriteLine("Özel Karakter");
            }
              Console.ReadKey();
        }
    }
}
