using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.SiniflarKalitim
{
    public class Teknoloji : Universite
    {
        public int LabSayisi { get; set; }
        public Teknoloji(string OkulAdi, string OkulAdres, string OkulTel, string Tur) : base(OkulAdi, OkulAdres, OkulTel, Tur)
        {
            this.LabSayisi = 3;
            this.OkulAd = OkulAdi+" ----Burası Teknolojidir.---";

        }

      public string OkulLabSayisiGetir()
        {
            return "Okulumuzun Lab Sayisi: " + this.LabSayisi;

        }

        public string OkulAdiGetir()
        {
            return "Okulumuzun Adı:" + this.OkulAd;

        }

        public override string ToplamOgrenciSayisiGetir(string OkulTuru)
        {
            if (OkulTuru == "Tek")
                return "Teknoloji Fakültesinin Toplam Öğrencisi 2000 dir.";
            else
                return base.ToplamOgrenciSayisiGetir("-1");

        }


    }
}
