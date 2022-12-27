using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.SiniflarKalitim
{
    public class Bolum : Okul
    {
        public string BolumKodu { get; set; }
        public override string Ekle()
        {
            return "Bölüm Eklendi";
        }

        public override string BilgiGetir(string Param, List<Okul> Liste)
        {
            if (Param.Contains("Bölüm"))
                return "Bölüm Adı= " + Param;
            else
                return base.BilgiGetir("-1",Liste);
        }
    }
}
