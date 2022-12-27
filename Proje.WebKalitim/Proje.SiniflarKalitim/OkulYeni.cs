using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.SiniflarKalitim
{
    public class OkulYeni : OrtakOzellikler
    {
        public override bool Ekle(Object Nesne)
        {
            OkulYeni yeni = new OkulYeni();
            yeni = (OkulYeni)Nesne;
            //veritabanına ekleme

            //
            bool durum = false;
            if (durum == true)
                return true;
            else
                return false;
        }

        public override bool Guncelle(object Nesne)
        {
            OkulYeni yeni = new OkulYeni();
            yeni = (OkulYeni)Nesne;
            //veritabanına güncelleme

            //
            bool durum = false;
            if (durum == true)
                return true;
            else
                return false;
        }

        public override string Listele(object Nesne)
        {
            OkulYeni yeni = new OkulYeni();
            yeni = (OkulYeni)Nesne;
            //veritabanından listeleme

            //
            bool durum = false;
            if (durum == true)
                return "Veri Geldi";
            else
                return "Veri Yoktur";
        }
    }
}
