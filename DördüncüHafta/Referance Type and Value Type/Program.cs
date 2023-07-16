namespace Referance_Type_and_Value_Type
{
    internal class Program
    {
        static List<string> ogrenciler = new List<string>();

        static void Main(string[] args)
        {

            string isim1 = "orhan";

            string isim2 = isim1;

            //Console.WriteLine(isim1);

            isim1 = "göko";

            //Console.WriteLine(isim2);

            string[] isimler = { "orhan", "mali", "emre" };

            //string[] ogrenciler = isimler;

            //string[] students = ogrenciler;

            isimler[0]= "görkem";

            //Console.WriteLine(ogrenciler[0]);

            //Console.WriteLine(students[0]);

            // list'de bu şekilde çalışır.
            //class yani objeler de bu şekilde çalışır.

            OgrenciEkle("orhan");

            OgrencileriListele();
        }

        static void OgrencileriListele()
        {
            foreach(string ogrenci in ogrenciler) 
            {
                Console.WriteLine(ogrenci);
            }
        }

        static void OgrenciEkle(string OgrenciAdi)
        {
            ogrenciler.Add(OgrenciAdi);
        }
    }
}