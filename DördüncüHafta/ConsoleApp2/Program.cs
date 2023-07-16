using Class_Kullanımı.Siniflar;
using ClassKullanimi.Yardimcilar;

namespace ClassKullanimi;
class Program
{

    static void Main(string[] args)
    {




        using StreamWriter writer = new StreamWriter("test.txt", false);
        writer.WriteLine("lorem ipsum");

        //Ogretmen mali = new Ogretmen();
        //mali.Ad = "Mehmet Ali";
        //mali.Soyad = "Satar";

        //Ogretmen heisenberg = new Ogretmen();
        //heisenberg.Ad = "Walter";
        //heisenberg.Soyad = "White";

        //Ogretmen gorkem = new Ogretmen();
        //gorkem.Ad = "Görkem";
        //gorkem.Soyad = "Korkmaz";


        //Ders ders1 = new Ders();
        //ders1.Ad = "Matematik";
        //ders1.Ogretmen = mali;

        //Ders ders2 = new Ders();
        //ders2.Ad = "Fizik";
        //ders2.Ogretmen = mali;

        //Ders ders3 = new Ders();
        //ders3.Ad = "Kimya";
        //ders3.Ogretmen = heisenberg;

        //Ders ders4 = new Ders();
        //ders4.Ad = "Biyoloji";
        //ders4.Ogretmen = gorkem;

        //Ogrenci jesse = new Ogrenci();
        //jesse.Ad = "Jesse";
        //jesse.Soyad = "Pinkman";
        //jesse.Dersler.Add(ders1);
        //jesse.Dersler.Add(ders2);
        //jesse.Dersler.Add(ders3);

        //Ogrenci saul = new Ogrenci();
        //saul.Ad = "Saul";
        //saul.Soyad = "Goodman";
        //saul.Dersler.Add(ders1);
        //saul.Dersler.Add(ders3);

        //Ogrenci alperen= new Ogrenci();
        //alperen.Ad = "Alperen";
        //alperen.Soyad = "Korkmaz";
        //alperen.Dersler.Add(ders1);
        //alperen.Dersler.Add(ders2);
        //alperen.Dersler.Add(ders3);
        //alperen.Dersler.Add(ders4);

        //List<Ogrenci> ogrenciler = new List<Ogrenci>();
        //ogrenciler.Add(jesse);
        //ogrenciler.Add(saul);
        //ogrenciler.Add(alperen);

        //foreach (var ogrenci in ogrenciler)
        //{
        //    Console.WriteLine($"Öğrenci: {ogrenci.Ad} {ogrenci.Soyad}");


        //    foreach (var ders in ogrenci.Dersler)
        //    {
        //        Console.WriteLine($"-- Aldığı Ders: {ders.Ad}");
        //        Console.WriteLine($"-- Öğretmeni: {ders.Ogretmen.Ad} {ders.Ogretmen.Soyad}");
        //        Console.WriteLine("");
        //    }

        //    Console.WriteLine("");

        //}



        //var orhan = new Ogrenci();

        //Console.WriteLine(orhan.Ad);

        ////orhan.Dersler = new List<Ders>();

        //var ogretmen = new Ogretmen()
        //{
        //    Ad = "David Malan",
        //    DogumTarihi = new DateTime(1989, 3, 17)
        //};

        //orhan.Dersler.Add(
        //    new Ders()
        //    {
        //        Ad = "Bilgisayar Bilimi",
        //        Ogretmen = ogretmen
        //    }
        //);

        // d = gün
        // M = ay
        // y = yıl
        // hh = saat
        // mm = dakika
        // ss = saniye
        // böyle kullanım için sadece DateTime olan değişkenin sonuna .ToString() eklemek gerekiyor
        //Console.WriteLine(orhan.Dersler[0].Ogretmen.DogumTarihi.ToString("dd/MM/yy"));

        //var ogrenciler = new List<Ogrenci>();
        //ogrenciler.Add(
        //    new Ogrenci()
        //    {

        //    }
        //);

        //Kisi yeniKisi = new Kisi();
        //yeniKisi.Ad = "Orhan";
        //yeniKisi.Soyad = "Ekici";
        //yeniKisi.Yas = 34;

        //Kisi uzulenKisi = new Kisi
        //{
        //    Ad = "Orhan",
        //    Soyad = "Ekici",
        //    Yas = 34
        //};

        //List<Kisi> kisiler = new List<Kisi>();
        //kisiler.Add(yeniKisi);

        //kisiler.Add(new Kisi
        //{
        //    Ad = "Orhan",
        //    Soyad = "Ekici",
        //    Yas = 34
        //});

        //kisiler.Add(kisiler[0]);
        //kisiler[0].Ad = "Selami";

        //Console.WriteLine(kisiler[2].Ad);

        // foreach ile kisiler'in içindeki her bir kişinin adını yazdırın
        // foreach ile kisiler'in içindeki her bir kişinin adını ve soyadını bitişik yazdırın


        // Ögrenci düzenleme
        // method yazıp öğrenciyi bulup o method bulduğunuz öğrenciyi dönmeniz gerekiyor






        #region ÖDEVVVVV

        //günlük
        //her gün 750 kelime yazdığınız günlük dosyanız olsun
        //uygulamayı açtığınızda günün tarihi otomatik yazsın
        //örn: 10.06.2023 tarihli günlük
        //sizde tek satırda ve ya birkaç satırda enter a basarak istediklriniz yazın
        // ilk versiyonda enter a basınca kayıt yapılsın
        //txt dosyasına kaydetsin
        //txt dosyasına ekleme yapılarak kayıt edilmesi lazım
        //DateTime.Now --> DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss" ) tarihli kayıt
        


        //ikinci versiyonda kullanıcı ekleme yapmak için meüden seçim yapsın veya eski kayıtlardan birini okuyabilsin
        //tüm kayıtları listeleyebilirsiniz





        #endregion

    }


}
