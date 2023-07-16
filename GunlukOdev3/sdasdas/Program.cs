using System;
using System.Collections.Generic;

class GunlukKaydi
{
    public DateTime Tarih { get; set; }
    public string Icerik { get; set; }
}

class Program
{
    static List<GunlukKaydi> gunlukKayitlari = new List<GunlukKaydi>();
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
        Console.WriteLine("Q - Çıkış yap");
        Console.WriteLine("Seçiminizi yapın:");

        string secim = Console.ReadLine();

        switch (secim)
        {
            case "1":
                GirisYap();
                break;
            case "2":
                KayitOl();
                break;
            case "Q":
            case "q":
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Geçersiz seçim.");
                GirisEkrani();
                break;
        }
    }

    static void GirisYap()
    {
        Console.Write("Şifrenizi girin: ");
        string girilenSifre = Console.ReadLine();

        if (girilenSifre == sifre)
        {
            AnaMenu();
        }
        else
        {
            Console.WriteLine("Hatalı şifre.");
            GirisEkrani();
        }
    }

    static void KayitOl()
    {
        Console.WriteLine("Kayıt ol");
        Console.Write("Yeni şifre belirleyin: ");
        sifre = Console.ReadLine();

        Console.WriteLine("Kayıt başarıyla oluşturuldu.");
        GirisEkrani();
    }

    static void AnaMenu()
    {
        Console.WriteLine("GÜNLÜK UYGULAMASI");
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
            case "q":
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Geçersiz seçim.");
                break;
        }

        AnaMenu();
    }

    static void GunlukKaydiEkle()
    {
        Console.WriteLine(DateTime.Now.ToString("dd.MM.yyyy") + " tarihli günlük");
        Console.WriteLine("Günlük kaydınızı girin (Kaydı tamamlamak için 'end' yazın):");

        string icerik = "";
        string satir = Console.ReadLine();

        while (satir.ToLower() != "end")
        {
            icerik += satir + Environment.NewLine;
            satir = Console.ReadLine();
        }

        GunlukKaydi yeniKayit = new GunlukKaydi
        {
            Tarih = DateTime.Now,
            Icerik = icerik
        };

        gunlukKayitlari.Add(yeniKayit);
        Console.WriteLine("Kayıt eklendi.");
    }

    static void KayitlariListele()
    {
        Console.WriteLine("1 - Tüm kayıtları listele");
        Console.WriteLine("2 - Belirli bir tarih için kayıtları listele");
        Console.WriteLine("Seçiminizi yapın (1 veya 2):");

        string secim = Console.ReadLine();

        if (secim == "1")
        {
            Console.WriteLine("Tüm kayıtlar:");
            foreach (var kayit in gunlukKayitlari)
            {
                Console.WriteLine(kayit.Tarih.ToString("dd.MM.yyyy") + " tarihli kayıt:");
                Console.WriteLine(kayit.Icerik);
                Console.WriteLine("-------------------");
            }
        }
        else if (secim == "2")
        {
            Console.WriteLine("Listelemek istediğiniz tarihi girin (dd.MM.yyyy):");
            string tarih = Console.ReadLine();

            Console.WriteLine(tarih + " tarihli kayıtlar:");
            foreach (var kayit in gunlukKayitlari)
            {
                if (kayit.Tarih.ToString("dd.MM.yyyy") == tarih)
                {
                    Console.WriteLine(kayit.Tarih.ToString("dd.MM.yyyy") + " tarihli kayıt:");
                    Console.WriteLine(kayit.Icerik);
                    Console.WriteLine("-------------------");
                }
            }
        }
        else
        {
            Console.WriteLine("Geçersiz seçim.");
        }
    }
}