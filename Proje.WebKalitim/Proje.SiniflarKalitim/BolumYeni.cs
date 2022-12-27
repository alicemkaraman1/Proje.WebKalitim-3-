using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.SiniflarKalitim
{
    public class BolumYeni : OrtakOzellikler
    {
       
        public override bool Ekle(object Nesne)
        {
            BolumYeni yeni = new BolumYeni();
            yeni = (BolumYeni)Nesne;
            //veritabanına veri ekleme

            return true;
            //
        }

        public override bool Guncelle(object Nesne)
        {
            BolumYeni yeni = new BolumYeni();
            yeni = (BolumYeni)Nesne;
            //veritabanına veri güncelleme

            return true;
            //
        }

        public override string Listele(object Nesne)
        {
            BolumYeni yeni = new BolumYeni();
            yeni = (BolumYeni)Nesne;
            //veritabanına veri listeleme

            return "Veri Geldi";
            //
        }
    }
}
