namespace Gunluk
{
    class Program
    {
        class kayıtlarıgoster
        {
            public static List<string> Gunlukler = new List<string>();
        }
        static List<string>kayitTarileri = new List<string>();
        static string tarih = DateTime.Now.ToString("dd/MM/yyyy");
        static string KayitTarihi;
        static void Main(string[] args)
        {
            Console.Title = "Gunluk uygulaması";
            Console.WriteLine("Hoşgeldiniz\nLütfen kullanıcı bilgilerinizi giriniz...");

            GirisYap();
        }
        static void GirisYap()
        {
            string inputAd = Kullanicidogrula("adınız: ");
            string inputsifre = Kullanicidogrula("şifre: ");
            string kullaniciadi = "baris";
            string kullaniciSifre = "123";
            if (kullaniciadi == inputAd && kullaniciSifre == inputsifre)
            {
                Console.WriteLine("Giriş Başarılı\n \nHoşgeldin Barış ");

                Arayuz();
            }
            else
            {
                Console.WriteLine("Giriş bilgilerinizi kontrol ediniz...");
            }
        }
        static void Arayuz()
        {
            Console.Clear();
            Console.WriteLine("1- Yeni Kayıt Ekle\n2- Kayıtları listele\n3-Çıkış");
            string secim = Console.ReadLine();
            switch (secim)
            {
                case "1":
                    YenikayitEkle();
                    break;
                case "2":
                    Kayitlarilistele();
                    break;
                case "3":
                    Environment.Exit(0);
                    break;

            }
        }
        static string Kullanicidogrula(string Mesaj)
        {
            Console.WriteLine(Mesaj);
            return Console.ReadLine();
        }
        static void YenikayitEkle()
        {
            using StreamWriter writer = new StreamWriter("Gunlukyaz.txt", true);
            {
                Console.WriteLine("Kayıt tarihini giriniz (dd/MM/yyyy): ");
                kayitTarileri.Add(Console.ReadLine()); 
                writer.Write($"{KayitTarihi} Tarihli kayıt |");

                string metin = "";
                string satir;
                //writer.Write($"{tarih} Tarihli kayıt ");

                while ((satir = Console.ReadLine()) != "end")
                {
                    if (metin.Length <= 750)
                    {
                        metin += satir;
                    }
                    else
                    {
                        Console.WriteLine("günlük kelime sınırına ulaştınız sevgili yazar\nYarın dertleşmeye devam ederiz");
                        Arayuz();
                    }

                }
                writer.WriteLine(metin);
                writer.WriteLine(" ");
                Console.WriteLine("Kayıt başarıyla eklendi.");
                Arayuz();

            }
        }
        static void Kayitlarilistele()
        {
            using StreamReader reader = new StreamReader("Gunlukyaz.txt");

        }

        private static void NewMethod(StreamReader reader)
        {
            Console.Clear();
            Console.WriteLine("Okumak istediğiniz kayıt tarihini giriniz\nGG.AA.YYYY");
            string inputTarih = Console.ReadLine();
            if (inputTarih == KayitTarihi)
            {
                Console.WriteLine(reader.ReadToEnd().Split('\n'));

                while (true)
                {
                    string satir = reader.ReadLine();

                    if (satir == null)
                    {
                        break;
                    }

                    Console.WriteLine(satir);

                }
            }




            Console.ReadKey();

            Arayuz();
        }
    }
}