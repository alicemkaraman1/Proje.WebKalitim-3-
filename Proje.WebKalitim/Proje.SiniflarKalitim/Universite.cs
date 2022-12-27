using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.SiniflarKalitim
{
   public class Universite
    {
        public string OkulAd { get; set; }

        public string OkulAdres { get; set; }
        public string OkulTel { get; set; }
        public string Tur { get; set; }


        public Universite(string OkulAdi,string OkulAdres,string OkulTel,string Tur)
        {

            this.OkulAd = OkulAdi;
            this.OkulAdres = OkulAdres;
            this.OkulTel = OkulTel;
            this.Tur = Tur;
        }

        public virtual string ToplamOgrenciSayisiGetir(string OkulTuru)
        {
            return "Toplam Üniversite Öğrencisi Sayısı: 41000 dir";

        }


    }
}
