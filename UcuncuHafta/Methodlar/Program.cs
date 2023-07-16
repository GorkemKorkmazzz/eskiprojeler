namespace Methodlar
{
    internal class Program
    {

        // method isimleri her zaman büyük harf ile başlar.
        // method isimleri emir şeklinde olur
        //static void MerhabaDe()
        //{
        //    Console.WriteLine("Merhaba");
        //}

        //static void Selamla(string ad)
        //{
        //    Console.WriteLine("Merhaba " + ad);
        //}


        //static int Topla(int sayi1, int sayi2)
        //{

        //    return sayi1 + sayi2;
        //}

        //static void KullaniciBilgisiVer(string ad, string soyad, int dogumYili)
        //{
        //    int yas = YasHEsapla(dogumYili);

        //    string mesaj = $"Merhaba {ad} {soyad}, yaşın  {yas}";
        //    Console.WriteLine(mesaj);
        //}

        //static int YasHEsapla(int dogumYili)
        //{
        //    int yas = 2023 - dogumYili;

        //    return yas;
        //}

        static int ToplamınıAl(List<int> sayilar)
        {
            int toplam = 0;

            foreach (var sayi in sayilar)
            {
                toplam += sayi;
            }
            return toplam;
        }

        static double OrtalamasnıAl(List<int> sayilar)
        {
            double toplam = ToplamınıAl(sayilar);
            double ortalama = toplam / sayilar.Count();

            return ortalama;
        }

        static void Main(string[] args)
        {
            //MerhabaDe();

            //Selamla("Gorkem");

            //string name = "gorkem";
            // Selamla(name);


            // Topla methodu kullanımı 
            // int sonuc = Topla(5, 10);
            //Console.WriteLine(sonuc);

            //alt kullanım
            //Console.WriteLine(Topla(5, 10));


            //kullanıcının
            //adını soyadını ve
            //doğum yılını gönderdiğiniz method'da
            //ekrana merhaba [ad] [soyad ]  [hesaplana yaş]
            //şeklinde bilgi versin
            //doğum yılı olsun sadece

            //Console.Write("Adınızı Gir: ");
            //string ad = Console.ReadLine();
            //Console.Write("Soyadınızı Gir:");
            //string soyad = Console.ReadLine();
            //int dogumYili = 2002;

            // KullaniciBilgisiVer(ad, soyad, dogumYili);


            //topla diye method oluştur
            //içine liste ve ya array gönder

            Console.WriteLine("Kaç Adet SAyı Gİrmek İstiyorsunuz");
            int girilenSayiAdedi =int.Parse(Console.ReadLine());
            List<int> sayilar = new List<int>();
            for (int i = 0; i < girilenSayiAdedi; i++)
            {
                Console.WriteLine($"{i+1} . sayı Giriniz");
                sayilar.Add(int.Parse(Console.ReadLine()));
            }
            //sayilar.Add(1);
            //sayilar.Add(2);
            //sayilar.Add(3);
            //sayilar.Add(4);
            //sayilar.Add(5);
            //sayilar.Add(6);
            int toplam = ToplamınıAl(sayilar);
            double ortalamsi = OrtalamasnıAl(sayilar);
            Console.Write("Sayıların Toplamı: "+toplam);
            Console.WriteLine(" ");
            Console.Write("Sayıların Ortalaması: "+ortalamsi);

        }


    }
}