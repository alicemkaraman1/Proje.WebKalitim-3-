using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.SiniflarKalitim
{
   public class Lab:LabTurleri
    {

        public string LabTurKodu { get; set; }
        public string LabProgramId { get; set; }
        public List<Malzemeler> LabMalzemeleri { get; set; }
        public Lab(string TurAdi,List<LabTurleri>Turlistesi)
        {
            var sonuc = Turlistesi.Where(p => p.Adi.Contains(TurAdi));
            if (sonuc.Count() > 0)
                this.LabTurKodu = sonuc.First().Kodu;
            else
                this.LabTurKodu = "Bilinmiyor,Yeni Tür olarak Ekleyiniz";

        }
        public override string Ekle(Lab Entity)
        {
            if (Entity.LabProgramId == null)
                return base.Ekle(Entity);
            else
                return Entity.Adi+" labı eklenmiştir.";
        }

    }
}
