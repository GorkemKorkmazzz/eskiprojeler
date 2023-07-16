namespace ClassKullanimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Araba araba1 = new Araba();
            araba1.arabaRengi = "kırmızı";
            araba1.arabaModel = "Megane 4";
            araba1.kapiSayisi = 5;


            Console.WriteLine("Araba Rengi: "+araba1.arabaRengi);
            Console.WriteLine("Araba Model: "+araba1.arabaModel);
            Console.WriteLine("Kapı Sayısı: " + araba1.kapiSayisi);


        }
    }
}