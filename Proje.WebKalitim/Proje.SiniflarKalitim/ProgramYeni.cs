using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.SiniflarKalitim
{
    public class ProgramYeni : OrtakOzellikler
    {
        public string ProgramKodu { get; set; }
        public override bool Ekle(object Nesne)
        {
            ProgramYeni yeni = new ProgramYeni();
            yeni = (ProgramYeni)Nesne;
            //veritabanına veri ekleme

            return true;
            //
        }

        public override bool Guncelle(object Nesne)
        {
            ProgramYeni yeni = new ProgramYeni();
            yeni = (ProgramYeni)Nesne;
            //veritabanına veri güncelleme

            return true;
            //
        }

        public override string Listele(object Nesne)
        {
            ProgramYeni yeni = new ProgramYeni();
            yeni = (ProgramYeni)Nesne;
            //veritabanına veri listeleme

            return "Veri Geldi";
            //
        }
    }
}
