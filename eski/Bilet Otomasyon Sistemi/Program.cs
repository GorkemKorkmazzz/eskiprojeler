using System.Net;

namespace Ödevvv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bilet Sistemine Hoşgeldiniz.");

            Console.WriteLine(" ");

            Console.WriteLine("Lütfen Yapmak İstediğiniz İşlemi Seçinizs?");

            Console.WriteLine(" ");

            Console.WriteLine("1-Bilet Satın Almak");
            Console.WriteLine("2-Bilet İptal Etmek");
            Console.WriteLine("3-Bilet Rezervasyonu Yapmak");

            List<string> secimler = new List<string>();
            secimler.Add("1-Bilet Satın Almak");
            secimler.Add("2-Bilet İptal Etmek");
            secimler.Add("3-Bilet Rezervasyonu Yapmak");

            string secim = Console.ReadLine();
            Console.WriteLine(" ");
            if (secim == "1")
            {
                Console.WriteLine("Nereye Gitmek İstiyorsunuz?");

                List<string> sehirler = new List<string>();
                sehirler.Add("Ankara");
                sehirler.Add("İzmir");
                sehirler.Add("İstanbul");
                sehirler.Add("Ordu");
                sehirler.Add("Hatay");

                foreach (string sehir in sehirler)
                {
                    Console.Write(sehir + " ");
                }

                Console.WriteLine(" ");

                string secim2 = Console.ReadLine();
                if (sehirler[0] == secim2)
                {
                    Console.WriteLine("Ankara Bilet Fiyatı 350 TL");
                    Console.WriteLine(" ");
                    Console.WriteLine("Devam Etmek İstiyor musunuz? ");
                    string inputEvet = Console.ReadLine();
                    if (inputEvet == "Evet")
                    {
                        Console.WriteLine("Lütfen Gitmek İstediğiniz Tarihi Yazınız?");

                        string inputTarih = Console.ReadLine();

                        Console.WriteLine("Biletiniz Hazırlanıyor...");

                        Console.WriteLine(" ");

                        Console.WriteLine("Biletiniz bu tarihde " + inputTarih + " oluşturldu.");
                        Console.WriteLine(" ");
                        Console.WriteLine("Hayırlı Yolculuklar Dileriz...");
                    }
                    else
                    {
                        Console.WriteLine("Bilet Sisteminden Çıkış Yapıyorsunuz. İyi Günler..");
                    }
                }
                else if (secimler[1]==secim2)
                {
                    Console.WriteLine("dsfds");
                }

            }


            

        }
    }
}