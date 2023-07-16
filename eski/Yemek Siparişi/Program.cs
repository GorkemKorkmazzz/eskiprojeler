namespace Yemek_Siparişi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //menüyü method haline getir.

            //MenüGöster();
            //static void MenüGöster()
            //{
            //menüyü yaz
            //}


            //1 -) kullanıcıya 5 menü ve fiyatlarını söyleyeceğiz
            //2 -) 5 tane de yan ürün ve promosyon seçimi yaptıracağız
            //3 -) en son toplam sipariş tutarını ekrana yazdıracağız
            int kasa = 0;
            string sepet = " ";

            Console.WriteLine("GRK Gurme Restorantına Hoşgeldiniz");
            Console.WriteLine(" ");

            Console.WriteLine("Ana Yemekler");
            Console.WriteLine(" ");

            //fiyatları ana yemeklerin yanına yaz
            List<string> anaYemkeler = new List<string>();
            anaYemkeler.Add("Köfte ");
            anaYemkeler.Add("Tavuk ");
            anaYemkeler.Add("Biftek ");
            anaYemkeler.Add("Balık ");
            anaYemkeler.Add("Izgara Çeşitleri ");

            List<int> anaYemekFiyatları = new List<int>();
            anaYemekFiyatları.Add(150);
            anaYemekFiyatları.Add(100);
            anaYemekFiyatları.Add(200);
            anaYemekFiyatları.Add(250);
            anaYemekFiyatları.Add(200);

            for (int i = 0; i < anaYemkeler.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{anaYemkeler[i]}-- {anaYemekFiyatları[i]} TL");
            }
                
            Console.WriteLine(" ");

            Console.WriteLine("Meze Çeşitleri");

            Console.WriteLine(" ");

            List<string> mezeÇeşitleri = new List<string>();
            mezeÇeşitleri.Add("Havuç Tarator ");
            mezeÇeşitleri.Add("Haydari ");
            mezeÇeşitleri.Add("Şakşuka ");
            mezeÇeşitleri.Add("Humus ");
            mezeÇeşitleri.Add("Yuğurtlu Kırmızı Biber ");

            List<int> mezeFiyat = new List<int>();
            mezeFiyat.Add(60);
            mezeFiyat.Add(50);
            mezeFiyat.Add(50);
            mezeFiyat.Add(45);
            mezeFiyat.Add(60);

            for (int i = 0; i < mezeÇeşitleri.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{mezeÇeşitleri[i]}-- {mezeFiyat[i]} TL");

            }

            Console.WriteLine(" ");

            Console.WriteLine("Promosyonlar");

            Console.WriteLine(" ");

            List<string> promosyonlar = new List<string>();
            promosyonlar.Add("Patates Kızartması");
            promosyonlar.Add("Salata");
            promosyonlar.Add("Su");
            promosyonlar.Add("Ekmek");

            foreach (var promosyon in promosyonlar)
            {
                Console.WriteLine(promosyon);
            }

            Console.WriteLine(" ");
            Console.WriteLine("Lütfen Ana Yemek Tercihini Yazınız?");
            string inputAnaYemek = Console.ReadLine();

            if (inputAnaYemek == "köfte")
            {
                kasa += anaYemekFiyatları[0];
                sepet += anaYemkeler[0];
            }
            else if (inputAnaYemek == "tavuk")
            {
                kasa += anaYemekFiyatları[1];
                sepet += anaYemkeler[1];

            }
            else if (inputAnaYemek == "Biftek")
            {
                kasa += anaYemekFiyatları[2];
                sepet += anaYemkeler[2];

            }
            else if (inputAnaYemek == "balık")
            {
                sepet += anaYemkeler[3];
                kasa += anaYemekFiyatları[3];
            }
            else if (inputAnaYemek == "ızgara")
            {
                sepet += anaYemkeler[4];
                kasa += anaYemekFiyatları[4];

            }
            else
            {
                Console.WriteLine("Geçerli bir sipariş yaznız.");
            }

            Console.WriteLine(" ");
            Console.WriteLine("Lütfen Meze Tercihini Yazınız?");
            string inputMeze = Console.ReadLine();

            if (inputMeze == "havuç")
            {
                kasa += mezeFiyat[0];
                sepet += mezeÇeşitleri[0];

            }
            else if (inputMeze == "haydari")
            {
                sepet += mezeÇeşitleri[1];
                kasa += mezeFiyat[1];
            }
            else if (inputMeze == "şakşuka")
            {
                sepet += mezeÇeşitleri[2];
                kasa += mezeFiyat[2];
            }
            else if (inputMeze == "humus")
            {
                sepet += mezeÇeşitleri[3];
                kasa += mezeFiyat[3];
            }
            else
            {
                kasa += mezeFiyat[4];
                sepet += mezeÇeşitleri[4];
            }

            Console.WriteLine(" ");
            Console.WriteLine("Lütfen Promosyon Tercihini Yazınız");
            string inputPromosyon = Console.ReadLine();

            Console.WriteLine(" ");
            Console.Write("Toplam Yemek Siparişi Tutarı: " + kasa + "TL");
            Console.WriteLine(" ");
            Console.WriteLine("Sepetinizdeki Ürünler" + sepet);

        }
    }
}
