namespace Odevv2
{
    internal class Program
    {
        static List<string> ogrenciler = new List<string>();

        static List<string> ogretimGorevlileri = new List<string>();
        static void MenuGoster()
        {
            Console.Clear();
            Console.WriteLine("Hoşgeldiniz");
            Console.WriteLine("1- Ögrencileri listelemek için ");
            Console.WriteLine("2- Ögrenci eklemek için ");
            Console.WriteLine("3- Öğretim Görevlilerini Listelemek İçin");
            Console.WriteLine("4- Öğretim Görevlisi Eklemek için ");
            Console.WriteLine("5- Öğrenci Silmek için ");
            Console.WriteLine("6- Öğrenci Bulmak İçin ");
            Console.WriteLine("7- Öğrenci Düzenlemek İçin ");
            Console.WriteLine("0- Çıkış yapmak için ");

            string inputMenuSecim = Console.ReadLine();

            if (inputMenuSecim == "1")
            {
                OgrenciListesi();
            }
            else if (inputMenuSecim == "2")
            {
                OgrenciEkle();
            }
            else if (inputMenuSecim == "3")
            {
                OgretimGorevlisi();
            }
            else if (inputMenuSecim == "4")
            {
                OgretimGorevlisiEkle();
            }
            else if (inputMenuSecim == "5")
            {
                OgrenciSİl();
            }
            else if (inputMenuSecim == "6")
            {
                OgrenciBul();
            }
            else if (inputMenuSecim == "7")
            {
                OgrenciDuzenle();
            }
            else
            {
                Console.WriteLine("Çıkış Yapılıyor...");
                return;

            }
        }

        static void MenuyeDon()
        {
            Console.WriteLine("Menüye Dönmek İçin HErhangibir Tuşa Basınız...");
            Console.ReadKey();

            MenuGoster();
        }

        static void OgrenciListesi()
        {
            Console.Clear();
            Console.WriteLine("Öğrenci Listesi: ");
            Console.WriteLine(" ");
            foreach (var ogrenci in ogrenciler)
            {
                Console.WriteLine(ogrenci);
            }

            Console.WriteLine(" ");

            MenuyeDon();
        }

        static void OgrenciEkle()
        {
            Console.Clear();
            Console.Write("Öğrencinin İsmi:");

            ogrenciler.Add(Console.ReadLine());

            Console.WriteLine(" ");
            Console.WriteLine("Öğrenci Listeye Eklendi...");
            Console.WriteLine(" ");

            MenuyeDon();
        }

        static void OgretimGorevlisi()
        {
            Console.Clear();
            Console.WriteLine("Öğretim Görevlisi Listesi:");
            Console.WriteLine(" ");

            foreach (var ogretimgorevlisi in ogretimGorevlileri)
            {
                Console.WriteLine(ogretimgorevlisi);
            }

            Console.WriteLine("");

            MenuyeDon();
        }

        static void OgretimGorevlisiEkle()
        {
            Console.Clear();
            Console.Write("Öğretim Görevlisinin İsmi:");

            ogretimGorevlileri.Add(Console.ReadLine());

            Console.WriteLine(" ");
            Console.WriteLine("Öğretim Görevlisi Listeye Eklendi...");
            Console.WriteLine(" ");

            MenuyeDon();
        }

        static void OgrenciSİl()
        {
            Console.Clear();
            Console.Write("Silmek İstediğiniz Öğrencinin Adı: ");
            Console.WriteLine(" ");

            ogrenciler.Remove(Console.ReadLine());

            Console.WriteLine(" ");
            Console.WriteLine("Öğrenci Silinmiştir....");
            MenuyeDon();
        }

        static void OgrenciBul()
        {
            Console.Clear();
            Console.Write("Aramak İstediğiniz Öğrencinin Adı: ");

            string arananIsim = Console.ReadLine();
            Console.WriteLine(" ");

            for (int i = 0; i < ogrenciler.Count; i++)
            {
                if (arananIsim == ogrenciler[i])
                {
                    Console.WriteLine(arananIsim + " " + (i + 1) + ". sıradadır.");
                    break;
                }
                else
                {
                    Console.WriteLine("Öğrenci Bulunamadı.");
                    break;
                }

            }
            Console.WriteLine(" ");

            MenuyeDon();
        }

        static void OgrenciDuzenle()
        {

        }

        static void Main(string[] args)
        {
            MenuGoster();
        }

    }
}
