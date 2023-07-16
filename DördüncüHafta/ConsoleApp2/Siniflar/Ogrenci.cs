using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Kullanımı.Siniflar;

public class Ogrenci
{
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public List<Ders> Dersler { get; set; } = new List<Ders>();
}
public class Mezun : Ogrenci
{
    public DateTime MezuniyetTarihi { get; set; }
}

public class Ders
{
    public string Ad { get; set; }
    public Ogretmen Ogretmen { get; set; }
}

public class Ogretmen
{
    public string Ad { get; set; }
    public string Soyad { get; set; }
}
