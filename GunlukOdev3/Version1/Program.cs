using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.IO;

namespace gunlukOdev
{
    class Kullanıcılar
    {
        public string KullaniciAdi { get; set; }
        public int Sifre { get; set; }
    }

    class GunlukKaydi
    {
        public DateTime Tarih { get; set; }
        public string Icerik { get; set; }
    }

    class Program
    {
        static List<GunlukKaydi> gunlukKayitlari = new List<GunlukKaydi>();

        //static List<string> kullanicilar = new List<string>();


        static string sifre = "123456";

       

        static void Main(string[] args)
        {
            GirisEkrani();
        }

        static void GirisEkrani()
        {
            Console.WriteLine("GÜNLÜK UYGULAMASI");
            Console.WriteLine("1 - Giriş yap");
            Console.WriteLine("2 - Kayıt ol");
            Console.WriteLine("3 - Kullanıcı Listesi");
            Console.WriteLine("Q - Çıkış yap");
            Console.WriteLine("Seçiminizi yapın:");

            string secim = Console.ReadLine();

            if (secim == "1")
            {
                GirisYap();

            }
            else if (secim == "2")
            {
                KayitOl();

            }
            else if(secim == "3")
            {
                KullanıcıBilgileriGoster();
            }
            else
            {
                Environment.Exit(0);

            }


        }
        static string Kullanicidogrula(string Mesaj)
        {
            Console.WriteLine(Mesaj);
            return Console.ReadLine();
        }
        static void GirisYap()
        {
            Console.Clear();
            Console.WriteLine("Lütfen Bilgilerinizi Giriniz.");
            Console.WriteLine(" ");
            string inputAd = Kullanicidogrula("Kullanıcı Adı: ");
            string inputsifre = Kullanicidogrula("Kullanıcı Şifresi: ");
            string kullaniciadi = "görkem";
            string kullaniciSifre = "123";
            if (kullaniciadi == inputAd.ToLower() && kullaniciSifre == inputsifre)
            {
                Console.WriteLine("Giriş Başarılı\n \nHoşgeldin"+inputAd);

                AnaMenu();
            }
            else
            {
                Console.WriteLine("Giriş bilgilerinizi kontrol ediniz...");
                GirisEkrani();
            }
        }

        static void KayitOl()
        {
            Console.Clear();
            using StreamWriter writer = new StreamWriter("kullanicilistesi.txt", true);
            

           // List<string> kullanicilar = new List<string>();
           // List<int> sifreler = new List<int>();

            Console.WriteLine("Kullanıcı Adı: ");
            string kullaniciAdi = Console.ReadLine();
           // kullanicilar.Add(kullaniciAdi);

            Console.WriteLine("Şifre: ");
            int sifre = int.Parse(Console.ReadLine());
           // sifreler.Add(sifre);

            Console.WriteLine("Kayıt Başarıyla Yapılmıştır.");
            Console.WriteLine("");
            Console.WriteLine("Ana Ekrana Dönmek İçin 0'a Basınız..");

            string anaEkranDonüş = Console.ReadLine();

            if (anaEkranDonüş == "0")
            {
                GirisEkrani();
            }
            else
            {
                Console.WriteLine("Hatalı bir Tuşlama Yaptınız!!!!!");
                Console.WriteLine("Sistem Kapatılıyor....");
            }


            Kullanıcılar kullanıcılar = new Kullanıcılar
            {
                KullaniciAdi = kullaniciAdi,
                Sifre = sifre,
            };

            writer.WriteLine(kullaniciAdi);
            writer.WriteLine(sifre);
            writer.WriteLine("-------------------");
            writer.Close();

        }

        static void KullanıcıBilgileriGoster()
        {
            Console.Clear();
            Console.WriteLine("1-Tüm Kullanıcıları Listele");
            string secim1 = Console.ReadLine();

            if (secim1 == "1")
            {
                Console.Clear();
                Console.WriteLine("Tüm Kullanıcı Listesi: ");

                string[] kullanicilar = File.ReadAllLines("kullanicilistesi.txt");
                foreach (var kullanici in kullanicilar)
                {
                    Console.WriteLine(kullanici);
                }

            }

        }

        static void AnaMenu()
        {
            Console.Clear();

            Console.WriteLine("GÜNLÜK UYGULAMASI");
            Console.WriteLine(" ");
            //Console.WriteLine("Hoşgeldin "+inputAd);
            Console.WriteLine("1 - Yeni kayıt ekle");
            Console.WriteLine("2 - Kayıtları listele");
            Console.WriteLine("Q - Çıkış yap");
            Console.WriteLine("Seçiminizi yapın:");

            string secim = Console.ReadLine();

            switch (secim)
            {
                case "1":
                    GunlukKaydiEkle();
                    break;
                case "2":
                    KayitlariListele();
                    break;
                case "Q":
                    //case "q":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Geçersiz seçim.");
                    break;
            }

            
        }

        static void GunlukKaydiEkle()
        {
            using StreamWriter writer = new StreamWriter("gunlukyaz.txt", true);

            Console.WriteLine(DateTime.Now.ToString("dd.MM.yyyy") + " tarihli günlük");
            Console.WriteLine("Günlük kaydınızı girin (Kaydı tamamlamak için 'end' yazın):");

            string icerik = "";
            string satir;

            while ((satir = Console.ReadLine()).ToLower() != "end")
            {
                if (icerik.Length <= 750)
                {
                    icerik += satir;
                }
                else
                {
                    Console.WriteLine("günlük kelime sınırına ulaştınız sevgili yazar....");

                }

                //satir = Console.ReadLine();
            }
            //writer.WriteLine(icerik);
            //writer.WriteLine(" ");


            GunlukKaydi yeniKayit = new GunlukKaydi
            {
                Tarih = DateTime.Now,
                Icerik = icerik
            };

            gunlukKayitlari.Add(yeniKayit);

            writer.WriteLine(yeniKayit.Tarih.ToString("dd.MM.yyyy"));
            writer.WriteLine(yeniKayit.Icerik);
            writer.WriteLine("-------------------");
            writer.Close();

            {
                //while ((satir = Console.ReadLine()).ToLower() != "end")
                //{
                //    if (icerik.Length <= 750)
                //    {
                //        icerik += satir;
                //    }
                //    else
                //    {
                //        Console.WriteLine("günlük kelime sınırına ulaştınız sevgili yazar\nYarın dertleşmeye devam ederiz");

                //    }

                //}

            }

            Console.WriteLine("Kayıt eklendi.");
        }

        static void KayitlariListele()
        {

            Console.Clear();
            Console.WriteLine("1 - Tüm kayıtları listele");
            Console.WriteLine("2 - Belirli bir tarih için kayıtları listele");
            Console.WriteLine("Seçiminizi yapın (1 veya 2):");

            string secim = Console.ReadLine();

            if (secim == "1")
            {
                Console.Clear();
                Console.WriteLine("Tüm kayıtlar:");

                string[] kayitListeleri = File.ReadAllLines("Gunlukyaz.txt");
                foreach (var kayitListesi in kayitListeleri)
                {
                    Console.WriteLine(kayitListesi);
                }
            }
            else if (secim == "2")
            {
                Console.WriteLine("Listelemek istediğiniz tarihi girin (dd.MM.yyyy):");
                string tarih = Console.ReadLine();

                Console.WriteLine(tarih + " tarihli kayıtlar:");

                string[] lines = File.ReadAllLines("Gunlukyaz.txt");
                bool kayitBulundu = false;

                for (int i = 0; i < lines.Length - 2; i += 3)
                {
                    if (lines[i] == tarih)
                    {
                        Console.WriteLine(lines[i]);
                        Console.WriteLine(lines[i + 1]);
                        Console.WriteLine(lines[i + 2]);
                        Console.WriteLine("-------------------");
                        kayitBulundu = true;
                    }
                }

                if (!kayitBulundu)
                {
                    Console.WriteLine("Belirtilen tarihe ait kayıt bulunamadı.");
                }
            }
            else
            {
                Console.WriteLine("Geçersiz seçim.");
            }


        }
    }
}
