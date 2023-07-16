using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek
{
    public class Ogrenci
    {
        private int ogrenciNo;

        private string ogrenciIsmi;

        private string ogrenciSoyismi;

        private int vize1;

        private int vize2;

        private int final;

        private string okulAdi;


        public void OgrenciBilgisiGoster()
        {
            Console.Clear();

            Console.WriteLine("Öğrenci Bilgileri");
            Console.WriteLine("Öğrenci Adı: " + ogrenciIsmi);
            Console.WriteLine("Öğrenci Soyadı: " + ogrenciSoyismi);
            Console.WriteLine("Öğrenci Numarası: " + ogrenciNo);
            Console.WriteLine("Öğrenci Vize 1 Notu: " + vize1);
            Console.WriteLine("Öğrenci Vize 2 Notu: " + vize2);
            Console.WriteLine("Öğrenci Final Notu: " + final);
            Console.WriteLine("Öğrenci Okul Adı: " + okulAdi);

            return;
        }

        public Ogrenci(string _ogrenciIsmi, string _ogrenciSoyismi, int _ogrenciNo, int _vize1, int _vize2, int _final, string _okulaAdi)
        {
            ogrenciIsmi= _ogrenciIsmi;
            ogrenciSoyismi= _ogrenciSoyismi;
            ogrenciNo= _ogrenciNo;
            vize1 = _vize1;
            vize2 = _vize2;
            final = _final;
            okulAdi = _okulaAdi;
        }

        public double OgrenciNotOrtalamasiBul()
        {
            double ortalama = vize1 * 0.2 + vize2 * 0.2 + final * 0.6;

            return ortalama;
        }

        public void OkulGetir()
        {
            Console.Clear();

            Console.WriteLine("Öğrencinin Okul Bilgileri");
            Console.WriteLine("Öğrenci Okul Adı: " + okulAdi);

        }


    }
}
