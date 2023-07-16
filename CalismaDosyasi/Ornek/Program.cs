namespace Ornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // bir tane öğrenci olacak
            // öğrencinin öğrenci no, isim, soyisim,vize1, vize2 ve okul ismi adında değişkenler olcak
            // erişim belirliyecilerini prvite yapacaz
            // yapıcı method olarak değişkenlere değerleri atıyacaz

            // OgrenciBilgiGoster() methodu olacak
            // OgrenciOrtalamasıBul() methodu olacak
            // OkulGetir methodu olacak

            // öğrencinin seçimlerine göre işlemleri yapacaz
            // 1-öğrenci bilgilerini göster
            // 2-öğrenci ortalamasını göster
            // 3-öğrencinin okulunu öğren
            // 4-çıkış yap


            Ogrenci ogrenci1=new Ogrenci("Görkem","Korkmaz",1286,80,73,67,"Dokuz Eylül Üniversitesi");
            


            Console.WriteLine("Uygulamamıza Hoşgeldiniz...");
            Console.WriteLine("");
            Console.WriteLine("Yapmak İstediğiniz İşlemi Tuşlayınız");
            Console.WriteLine("");
            MenuGoster();


            string secim =Console.ReadLine();

            if (secim=="1")
            {
                ogrenci1.OgrenciBilgisiGoster();
            }
            else if (secim=="2")
            {
                ogrenci1.OgrenciNotOrtalamasiBul();
                
            }
            else
            {
                ogrenci1.OkulGetir();
            }
        }


        static void MenuGoster()
        {
            
            Console.WriteLine("1-Öğrenci Bilgilerini Göster");
            Console.WriteLine("2-Öğrenci Ortalamasını Göster");
            Console.WriteLine("3-Öğrencinin Okulunu Göster");

            CikisYap();

        }

        static void CikisYap()
        {
            Console.WriteLine("4-Çıkış Yap");

        }
    }
}