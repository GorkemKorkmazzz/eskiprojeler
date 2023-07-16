namespace Odevvv
{
    internal class Program
    {
        static List<string> ogrenciler = new List<string>();

        static List<string> ogretmenler = new List<string>();
        static void Main(string[] args)
        {
            // listeler dizilere benzer
            // genel farkı listelere ekleme ve cıkarma yapabılırız
            // yazım bıcımı dızılerden farklıdır
            // toplam eleman sayısını almak ıcın Lenght yerıne Count kllanırız.
            //static List<string> ogrenciler = new List<string>();




            MenuGoster();

        }

        static void MenuGoster()
        {
            Console.Clear();
            Console.WriteLine("Hoşgeldiniz");
            Console.WriteLine("Ögrencileri listelemek için 1");
            Console.WriteLine("Ögrenci eklemek için 2");
            Console.WriteLine("Öğretim Görevlilerini Listelemek İçin 3");
            Console.WriteLine("Öğretim Görevlisi Eklemek için 4");
            Console.WriteLine("Çıkış yapmak için 0");
            


            string inputkullaniciSecimi = Console.ReadLine();

            if (inputkullaniciSecimi == "1")
            {
                OgrencileriListele();
            }
            else if (inputkullaniciSecimi == "2")
            {
                OgrenciEkle();
            }
            else if (inputkullaniciSecimi == "3")
            {
                OgretimGorevlileriniListele();
            }
            else if (inputkullaniciSecimi=="4")
            {
                OgretimGorevlisiEkle();
            }

            else
            {
                // kullanıcı 3 veya herhangı bı sey secerse programı kapatır.
                // programı sonuclandırmak ıcın return;
                //veya Environment.Exit(0); yazabilirsiniz.
                Console.WriteLine("Çıkış Yapılıyor...");
                return;
            }






        }


        static void OgretimGorevlisiEkle()
        {
            List<string> OgretimGorevlileri = new List<string>();
            foreach (var ogretimgorevlisi in OgretimGorevlileri)
            {
                Console.WriteLine(ogretimgorevlisi);
            }
            Console.Clear();
            Console.WriteLine("Ad:");
            OgretimGorevlileri.Add(Console.ReadLine());

            Console.WriteLine(" ");
            Console.WriteLine("Öğretim Görevliis Eklendi...");
            MnuyeDon();

        }
        static void OgretimGorevlileriniListele()
        {
            Console.Clear();
            Console.WriteLine("Öğretim Görevlileri'nin Listesi: ");
            Console.WriteLine("");
            List<string> OgretimGorevlileri = new List<string>();

            foreach (var ogretimGorevlisi in OgretimGorevlileri)
            {
                Console.WriteLine(ogretimGorevlisi);
            }
            MnuyeDon();
        }

        static void OgrencileriListele()
        {
            Console.Clear();
            Console.WriteLine("Öğrenci Listesi: ");
            Console.WriteLine(" ");
            List<string> ogrenciler = new List<string>();
            foreach (var ogrenci in ogrenciler)
            {
                Console.WriteLine(ogrenci);
            }

            MnuyeDon();
        }

        static void OgrenciEkle()
        {
            Console.Clear();
            List<string> ogrenciler = new List<string>();
            Console.Write("Öğrenci Adı: ");
            ogrenciler.Add(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine("Öğrenci Eklendi...");

            MnuyeDon();

        }

        static void MnuyeDon()
        {
            Console.WriteLine("");
            Console.WriteLine("Menüye Dönmek İçin Bir Tuşa Basın");
            Console.ReadKey();
            MenuGoster();
        }
    }

 }
