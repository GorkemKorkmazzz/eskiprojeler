namespace ConsoleApp1
{
    internal class Program
    {

        class Kişi
        {
            //ozellik--property
            public string Ad { get; set; }

            public string Soyad { get; set; }

            public int Yas { get; set; }
        }

        static string AdSoyadBirleştir(string ad, string soyad)
        {
            return $"{ad} {soyad}";
        }

        static string KullanıcıdanBilgiAL(string bilgiMesaji)
        {
            Console.Write(AdSoyadBirleştir);
            return Console.ReadLine();
        }

        static int KullanıcıdanSayısalBilgiAL(string bilgiMesaji)
        {
            // aşağıda tanımladığım değişkene sadece bu method içinden erişim sağlanır.
            string inputDeger = KullanıcıdanBilgiAL(bilgiMesaji);

            int donusturulenDeger;
            if (int.TryParse(inputDeger, out donusturulenDeger))
            {
                return donusturulenDeger;
            }

            //burada if çalışmama durumu için else yazmaya gerek yok
            //çünkü gerçekleşen if koşulunda return var
            //return olduğunda 
            //kodun altındaki satırlar asla çalışmaz

            Console.WriteLine("Sadece sayısal değer girin");

            // bu kullanıma recursive method kullanımı diyoruz
            return KullanıcıdanSayısalBilgiAL(bilgiMesaji);

        }

        static string Birlestir(string veri1, string veri2)
        {
            return veri1 + veri2;
        }


        static void Main(string[] args)
        {

            string inputAd = KullanıcıdanBilgiAL("Adınız: ");

            string inputSoyad = KullanıcıdanBilgiAL("Soyadınız: ");

            int inputYas = KullanıcıdanSayısalBilgiAL("Yaşınız: ");

            Console.WriteLine("");
            string tamAd = AdSoyadBirleştir(inputAd, inputSoyad);
            Console.WriteLine("Merhaba: " + tamAd);
            Console.WriteLine("Yaşınız: " + inputYas);
        }
    }
}