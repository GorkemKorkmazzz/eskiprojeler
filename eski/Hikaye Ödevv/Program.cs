namespace Hikaye_Ödevv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hikeye Programına Hoşgeldiniz...");
            Console.WriteLine(" ");
            Console.WriteLine("Hangi Tür Hikaye Okumak İstersiniz?");

            List<string> hikayeCesit = new List<string>();
            hikayeCesit.Add("Aşk");
            hikayeCesit.Add("Macera");
            hikayeCesit.Add("Polisiye");

            foreach (string hikaye in hikayeCesit)
            {
                Console.WriteLine(hikaye);
            }

            string secim = Console.ReadLine();

            Console.WriteLine(" ");
            //Aşk
            if (secim == "Aşk")

            {
                Console.WriteLine("Bir varmış bir yokmuş. Uzak Diyarlarda yaşayan bir padişah varmış. Padişahında Aykız adında güzel mi güzel sarışın, mavi gözlü bir kızı varmış.");
                Console.WriteLine("Aykız köyün bir gencine aşık olmuş. Babasından gizli saraydan kaçıp o gencin yanına gişdiyormuş. Genç köyün en fakir oğlanı ama en yakışıklısa da o imiş. Babası Aykızı diğer bir padişahın oğlu ile evlendirmeye çalışıyormuş. Padişahın oğluda zengin biriymiş.");
                Console.WriteLine("Aradan belli bir süre geçmiş. Aykız artık evlilik çağına gelmiş. Ancak iki gençden birisini şeçmek istiyormuş");
                Console.WriteLine(" ");
                Console.WriteLine("Hangisini Seçmeli");
                Console.WriteLine(" ");
                List<string> inputKarar = new List<string>();
                inputKarar.Add("Padişahın Oğlu");
                inputKarar.Add("Köyün Fakir Oğlu");

                foreach (var karar in inputKarar)
                {
                    Console.WriteLine(karar);
                }

                string secenek = Console.ReadLine();
                Console.WriteLine(" ");

                if (secenek == "Padişahın Oğlu")
                {
                    Console.WriteLine("Padişahın oğlu ile dillere destan bir düğün yapar. Ama Aykız çok mutlu değildir. Babası köyün genci ile konuşduğunu duyunca onu sürgüne gönderdi. Aradan belli bir süre geçti. Aykızın cocuğu oldu ve adını köyün gencinin ismini verdi ve sonsuza dek ona köyün gencini hayal ederek hayatına devam etti...");
                }
                else
                {
                    Console.WriteLine("Aykız gizlice köyün genci ile başka diyarlara kaçtı. Mutlu mesut hayatlarını sürerken yavaş yavaş geçim sıkıntısı yaşanmaya başlandı. Aykız artık eskisi gibi mutlu olmamaya başalıdı. Babasının yanına geri döndü. Babası artık Aykızı kabul etmiyordu ve Aykızı sürgüne gönderdi. Aykız artık yaşlanmışdı ve hastalığa yakalanara hayatını kaybetti...");
                }


            }

            //Macera
            else if (secim == "Macera")
            {
                Console.WriteLine("İki maceraperst kişi zorlu bir yolculuğa çıkar. Maceraperestler nereye gideceğine daha karar verememişlerdir. Biri daha önce hiç kimsenin gitmeye çekindiği Everest dağına çıkamk istiyordu. Diğeri ise Bermuda Şeytan Üçgenini keşfetmek istiyordu.");
                Console.WriteLine(" ");
                Console.WriteLine("Hangsini Tercih Etsin?");
                Console.WriteLine(" ");

                List<string> inputYerler = new List<string>();
                inputYerler.Add("Everest Dağı");
                inputYerler.Add("Bermuda Şeytan Üçgeni");

                foreach (var yer in inputYerler)
                {
                    Console.WriteLine(yer);
                }
                string yerSecim = Console.ReadLine();

                if (yerSecim == "Everest Dağı")
                {
                    Console.WriteLine("Maceracılar arık gidecek yerlere karar vermişlerdir. Aradan bir kaç ay geçtikden sonra planladıkları dağa tırmanmak için yola koyulmuşlardır. Yavaş yavaş dağı tırmanmaya başladırlar. Ama beklenmeyen bir durum gerçekleşti. Hava koşullarını hesaplamışlardı. Hava koşulları çok kötü gidiyordu. Biri devam etmek isterken diğeri ise havanın düzelmesini beklemk istiyordu.");
                    Console.WriteLine(" ");

                    List<string> havaTercihleri = new List<string>();
                    havaTercihleri.Add("Düzelmesinin Bekle");
                    havaTercihleri.Add("Devam Et");

                    foreach (var havatercih in havaTercihleri)
                    {
                        Console.WriteLine(havatercih);
                    }

                    string tercih = Console.ReadLine();

                    if (tercih == "Düzelmesini Bekle")
                    {
                        Console.WriteLine("Hava git gide düzelmeye başaldı ve maceracılar everest dağının tepesine ulaşmayı başardılar. Artık geri dönme vakti gelmişdi. Geri döndüler ve büyük bit kutlama yaparak bu olayı kutladılar.");
                    }
                    else
                    {
                        Console.WriteLine("Kötü hava koşullarına aldanış etmeyip yollarına devam ettiler. Aradan zaman geçti ve bir arkadaşı artık dayanamıyodu. Geri dönmek istedi ve diğer arkadaşı buna izin vermek istemedi ama o kararlıydı ve geri döndü. Diğeri ise yoluna devam etti ve bir daha onu göremedi.");
                    }

                }
                else
                {
                    Console.WriteLine("Bermuda şeytan üçgenine gitmek i.çin hazırlıklar yapılmaya başlandı. Onaları zorlu bir yolculuk bekliyoru. Yola çıkma vakti geldi ve gitmeye başladırlar. Aradan kısa bir süre geçtikten sonra iki maceraperstden bir daha haber alınamadı.");
                }
                
            }
            else
            {
                Console.WriteLine("lütfen Bir tercih yapınız...");
            }
        }
    }
}