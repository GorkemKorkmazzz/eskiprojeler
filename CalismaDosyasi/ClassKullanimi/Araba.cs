using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassKullanimi
{
    public class Araba
    {
        internal static string? araba1;
        public int kapiSayisi;
        public string arabaModel;

        public string arabaRengi;

        public void AracCalistir()
        {
            Console.WriteLine("Araba Çalıştı..");
        }

        public void KapılarıKitle()
        {
            Console.WriteLine("Kapılar Kitlendi");
        }

    }
}
