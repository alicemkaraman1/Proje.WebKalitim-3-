using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.SiniflarKalitim
{
   public class Malzemeler
    {
        public string Id { get; set; }
        public string MalzemeAdi { get; set; }
        public int MalzemeTuru { get; set; }
        public string MalzemeAlisTarihi { get; set; }
        public string MalzemeSonKTarihi { get; set; }
        public string MalzemeMarkasi { get; set; }



        public void Ekle()
        {


        }

        public void MalzemeGetir()
        {


        }

        public void MalzemeGuncelle()
        {


        }
    }


    public enum MalzemeTurleri
    {
        Demirbas=1,
        Sarf=0

    }
}
