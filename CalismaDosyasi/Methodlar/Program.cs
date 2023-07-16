namespace Methodlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SelamVer();

            ToplamaYap(5,10);
        }


        static void SelamVer()
        {
            // void olarak tanımladığımız method geriye değer döndürmeyen method dur.
            // parametre almayan

            Console.WriteLine("Selam");
        }

        static void ToplamaYap(int veri1, int veri2)
        {
            Console.WriteLine(veri1 + veri2);
        }

        
    }
}