namespace Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = { "ali", "veli", "ahmet" };

            //burada değişken tanımlarsam

            foreach (var isim in isimler)
            {
                //üstte tanımlanan değişkene burada da ulaşabilirim

                //burada değişken tanımlarsam

                //Console.WriteLine(isim);
            }
            //o değişkene ulaşamam


            int sayi = 10;

            Console.WriteLine(sayi);

            sayi = sayi + 1;

            Console.WriteLine(sayi);

            sayi += 2;

            Console.WriteLine(sayi);

            sayi -= 3;

            Console.WriteLine(sayi);


            //string ifade de -= oeratöeü çalışmaz
            string name = "görkem";
            Console.WriteLine(name);

            name += " korkmaz";

            Console.WriteLine(name);

            //çift ++ ile mevcut sayıyı 1'er arttırmak için ++ kullanabilirz
            //yeniden değişken tanımı yapmadan ++ etki eder
            //eğer başa eklersek hemen arttırır 
            //eğer sona eklersek bir sonraki satırda işlem yapılırken arttırır.

            Console.WriteLine(sayi);
            Console.WriteLine(sayi++); // bir sonraki çağırdığında artışı görürüz
            Console.WriteLine(sayi);
            Console.WriteLine(++sayi); // hemen artırır

            //sayılı dögü
            //hangi sayıdan başlıyacağını
            //ne zaman duracağını
            //her işlemde sayı artıcakmı eksilecekmi yoksa 
            //sayılar her işlemde kaçar kaçar değişecek
            //i==index
            //eğer iç içe döngü açarsanı ikinci i yerine j kullanılır
            //üçüncüyü açıyorsanız ona da siz karar verin

            Console.Clear();

            //Console.WriteLine(isimler[0]);

            for (var i = 0; i < isimler.Length; i++)
            {
                Console.WriteLine(isimler[i]);
                //Console.WriteLine(i);
            }

            Console.Clear();

            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine(i);
            }

            //Console.Clear();

            //int sayac = 0;
            //while (sayac<=10)
            //{
            //    Console.WriteLine("çalıştım");
            //    sayac++;
            //}

            //berak; yazdığımızda döngü kırılır.
            //her döngüde çalışır

            Console.Clear();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                if (i == 5)
                {
                    break;
                }
            }


            //döngünün her bir çalışmasına iterasyon denir
            //continue; çalıştıktan sonra altındaki satırlar çalışmaz 
            //ve bir sonraki iterasyona geçer

            Console.Clear();
            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                {
                    continue;
                }
                Console.WriteLine(i);

            }

            Console.Clear();

            //kullanıcıdan kaç tane sayıyı toplamak istediğini sorun
            //for döngüsünü kullanıp listeye toplanacak sayıları ekleyelim
            //sonra toplamı ekrana yazdıralım
            //kullanıcıya kaç tane sayı topladığınıda söyleyelim

            //kullanıcıya kaç tane sayı girmek istediğini soralım
            //girdiği sayıları tek tek kontrol edip çift mi tek mi diye ayıralım
            //sadece çift ve tek olanları ekrqana yazdıralım

            Console.WriteLine("Girmek istediğiniz sayı adedini yazınız.");
            int inputSayiAdedi = int.Parse(Console.ReadLine());
            List<int> girilenSayilar = new List<int>();
            List<int> tekSayilar = new List<int>();
            List<int> çiftSayilar = new List<int>();
            int toplam = 0;
            int çifttoplam = 0;
            int tekToplam = 0;

            for (int i = 0; i < inputSayiAdedi; i++)
            {

                Console.WriteLine("Toplamak istediğiniz sayıları yazınız.");
                int girilenSayi = int.Parse(Console.ReadLine());
                girilenSayilar.Add(girilenSayi);
                toplam += girilenSayi;

                if (girilenSayi % 2 == 0)
                {
                    çiftSayilar.Add(girilenSayi);
                    çifttoplam += girilenSayi;

                }
                else
                {
                    tekSayilar.Add(girilenSayi);
                    tekToplam += girilenSayi;
                }

            }
            Console.WriteLine(" ");
            Console.WriteLine("Girilen Sayıların Toplamı: " + toplam);
            Console.WriteLine("");
            Console.Write("Çift Sayıların Toplamı:" + çifttoplam);
            Console.WriteLine(" ");
            Console.WriteLine("Girilen Çift Sayılar");
            foreach (var çiftSayi in çiftSayilar)
            {
                Console.WriteLine(çiftSayi);
            }
            Console.WriteLine(" ");

            Console.WriteLine("Tek Sayıların Toplamı: " + tekToplam);
            Console.WriteLine("Girilen Tek Sayılar");
            foreach (int teksayi in tekSayilar)
            {
                Console.WriteLine(teksayi);
            }



            Console.Clear();
            //
            List<string> adlar = new List<string>();
            adlar.Add("görkem");
            adlar.Add("furkan");
            adlar.Add("atıf");
            adlar.Add("yunus");
            adlar.Add("emre");
            adlar.Add("murat");
            adlar.Add("tekin");
            adlar.Add("mehmet");
            adlar.Add("barış");
            adlar.Add("erkan");

            Console.Write("Hangi ismi arıyorsunuz: ");

            string arananIsim = Console.ReadLine();

            for (int i = 0; i < adlar.Count; i++)
            {
                if (arananIsim == adlar[i])
                {
                    Console.WriteLine(arananIsim + " " + (i + 1) + ". sıradadır.");
                }
            }
        }

    }
}