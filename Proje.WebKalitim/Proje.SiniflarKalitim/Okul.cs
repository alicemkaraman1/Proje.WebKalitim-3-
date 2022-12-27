using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.SiniflarKalitim
{
   public class Okul
    {
        public string Ad { get; set; }
        public string Adres { get; set; }
        public string Kodu { get; set; }

        private string tel;
         
        public string Telefon {
            get
            {
                return tel;
            }
            set
            {
                if (value.Length <= 11)
                    tel = value;
                else
                    tel = "Fazla Değer Girdiniz";
            }
            


        }

        public virtual string BilgiGetir(string Param,List<Okul> Liste)
        {
            if (Param == "-1")
                return "Okula ait Fonksiyonu çağırdınız";
            else
            {
                string okulad=Liste.Where(p => p.Kodu == Param).First().Ad;
                return okulad;
            }
        }
        public virtual string Ekle()
        {
            return "Okul Eklendi";
        }
        
    }
}
