using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.SiniflarKalitim
{
    public class Edebiyat : Universite
    {

        public int OkumaSalonu { get; set; }
        public Edebiyat(string OkulAdi, string OkulAdres, string OkulTel, string Tur) : base(OkulAdi, OkulAdres, OkulTel, Tur)
        {


        }

    

        public string OkulOkumaSalonuGetir()
        {
            return "Okulumuzun Okuma Salonu Sayisi: " + this.OkumaSalonu;

        }

        public string OkulAdiGetir()
        {
            return "Okulumuzun Adı:" + this.OkulAd;

        }
    }
}
