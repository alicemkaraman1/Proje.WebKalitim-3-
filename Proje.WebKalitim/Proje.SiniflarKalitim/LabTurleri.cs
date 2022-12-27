using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.SiniflarKalitim
{
    public class LabTurleri
    {
        public int Id { get; set; }
        public string Adi { get; set; }

        public string Kodu { get; set; }


        public virtual string TurGetir(string Kod,List<LabTurleri> Liste)
        {
            var sonuc = Liste.Where(p => p.Kodu == Kod).FirstOrDefault();
            return sonuc.Adi;
        }


        public virtual string Ekle(Lab Entity)
        {
            return Entity.Adi + " Eklenmiştir.";          
           

        }
    }
}
