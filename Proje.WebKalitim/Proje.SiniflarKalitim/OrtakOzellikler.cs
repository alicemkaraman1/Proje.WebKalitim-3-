using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.SiniflarKalitim
{
   public abstract class OrtakOzellikler
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Adres { get; set; }
        public string Kod { get; set; }

        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }

        public char Durum { get; set; }

        private string tel;
        public string Telefon
        {
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


        public abstract string Listele(Object Nesne);
        public abstract bool Ekle(Object Nesne);

        public virtual bool EkleSanal()
        {
            return true;

        }
        public abstract bool Guncelle(Object Nesne);
         

    }



}
