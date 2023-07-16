namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //sadece true veya false değerleri alabilir.
            bool ogrenciMi = "orhan" == "orhan";

            Console.WriteLine(ogrenciMi);

            //bu bir yorum satırıdır istediğinin yazın
            //yarum satırları bize hatırlatma yapar
            //kodu ne için yazdığımız veya
            //kodun ne amaçla çalıştığpını not ederiz

            //bazen bir satırdaki ya da bölümdeki kodu geçici olarak
            //çalıştırmamak isteriz o zaman da yarum satırı içine laırız

            //ctrl + K + C yorum satırı yapar
            //ctrl + K + U yorum satırını yorumdan çıkartır.

            if (ogrenciMi)
            {
                Console.WriteLine("Hello, World!");
            }

            //string
            //int
            //bool

            //tanımlama ve oluşturmak
            //declare ve assign

            //kodu hem oluşturduk hem de tanımladık
            string name = "orhan";

            //kodu oluşturduk ama tanımlamadık
            int age = 29;

            Console.WriteLine(age);


            #region Veri Kümelerei
            //içinde veriler olan grup

            //diziler-- array
            //dizilerin eleman sayısı sabittir ve yeni eleman eklenemez.

            //listeler-- list
            //listeler eleman sayısı değişebilir yeni eleman eklenebilir.

            // JIT CLR Common Language Runtime
            // Garbage Collector-- Çöp Toplayıcı
            // programda eklediğimiz ama artık kullanmayı
            // bırkatığımızda değişkenleri otomatik siliyor

            #region Diziler

            //new = yeni
            //null = boş
            string[] meyveler = new string[3];
            meyveler[0] = "Elma";
            meyveler[1] = "Kivi";
            meyveler[2] = "Armut";
            //dizi 3 elemanlı olduğu için 4.eleman ekliyemiyoruz
            //dizilerin ve listelerin index'i 0 ile başlar
            Console.WriteLine(meyveler[1]);

            //kısa yazım
            string[] renkler = { "kırmızı", "yeşil", "siyah" };

            //kısa yazımda veri değiştirme

            renkler[1] = "sarı";

            Console.WriteLine(renkler[1]);

            //dizide kaç eleman oldğunu bulmak için
            //dizinin yanına .Length yazarız
            Console.WriteLine(renkler.Length);

            #endregion

            #region Listeler
            //dizilerde olduğundan farklı sınırsız eleman ekliyebiliyoruz
            //listedeki eleman sayısı.Count yazarak buluyoruz.
            List<string> tatlilar = new List<string>();
            tatlilar.Add("Çilekli Milföy Tatlısı");
            tatlilar.Add("Magnolya");
            tatlilar.Add("Soğuk Baklava");

            //remove seçtiğimiz elemanı listeden çıkartır.
            tatlilar.Remove(tatlilar[0]);

            Console.WriteLine(tatlilar[0]);
            Console.WriteLine(tatlilar.Count);
            #endregion

            #endregion


            #region 1.versiyon
            //1.versiyom
            //kullanıcıya adını sorun
            //"Hoşgeldin [kullancının adı]" şeklinde karşılayın

            Console.Write("Lütfen Kullanıcı Adını Gİriniz: ");
            string kullaniciAdi = Console.ReadLine();
            Console.WriteLine("Hoşgeldin " + kullaniciAdi);

            #endregion


            //2.versiyon
            //2 string değişken oluşturun kullanıcıAdi ve sifre olsun
            // içinde "admin" ve "123" tanımları yapın
            //kullanıcıya kullanıcı adı ve şifre sorun
            //eğer doğru ise hoşgeldin admin
            //hatalı ise girdiğin bilgiler hatalı diyin


            //3.versiyon
            //2.versiyondaki kullanıcı girişinden sonra
            //kullanıcıya 4 tane meyve girmesi için imkan sağlayın
            //girdiği 4 meyveyi ekrana yazdırın
            //meyveler için list kullanın

            string userName = "admin";
            string password = "123";

            Console.Write("Lüften Kullanıcı Adınızı Giriniz: ");
            kullaniciAdi = Console.ReadLine();

            Console.Write("Litfen Şifrenizi Giriniz: ");
            password = Console.ReadLine();

            if (userName == userName && password == password)
            {
                Console.WriteLine("Hoşgeldin Admin");
                Console.WriteLine(" ");
                Console.WriteLine("Girmek İstediğin Meyveleri Yaz");

                List<string> meyveler = new List<string>();
                meyveler.Add(Console.ReadLine());
                meyveler.Add(Console.ReadLine());
                meyveler.Add(Console.ReadLine());
                meyveler.Add(Console.ReadLine());

                //Console.WriteLine(meyveler[0]);
                //Console.WriteLine(meyveler[1]);
                //Console.WriteLine(meyveler[2]);
                //Console.WriteLine(meyveler[3]);
                foreach (var meyve in meyveler)
                {
                    Console.WriteLine(meyve);
                }

            }
            else
            {
                Console.WriteLine("Girdiğiniz Bilgiler Hatalı Lütfen Tekrar Deneyiniz...");
            }

            Console.Clear();
            //paralel liste veya dizi


            List<string> ad = new List<string>();
            ad.Add("Görkem");
            ad.Add("Ahmet");
            ad.Add("Mehmet");

            List<string> soyad = new List<string>();
            soyad.Add("Korkmaz");
            soyad.Add("Mithat");
            soyad.Add("Şahin");

            Console.Write("Birinci Öğrencinin Adı ve Soyadı: " + ad[0] + " " + soyad[0]);
            Console.WriteLine(" ");
            Console.Write("İkinci Öğrencinin Adı ve Soyadı: " + ad[1] + " " + soyad[1]);

            Console.WriteLine(" ");
            Console.Write("Üçüncü Öğrencinin Adı ve Soyadı: " + ad[2] + " " + soyad[2]);



            #region Ödevvv
            //hikaye oluştur
            //kullanıcının seçimlerine göre hikayenin akışı ve sonucu değişssin


            //kullanıcıya kaç adet sayı toplamak istedğini sorun
            //istediği sayı kadar readline yapılacak 
            //toplamı gösterin


            
            #endregion



        }
    }
}