using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.SiniflarKalitim
{
    public class Satis : IUrun, IMusteri
    {
        

        private string Mad, Msoyad;
        string IMusteri.musteriad
        {
            get
            {
                return Mad;
            }

            set
            {
                Mad=value;
            }
        }

        string IMusteri.musterisoyad
        {
            get
            {
                return Msoyad;
            }

            set
            {
                Msoyad = value;
            }
        }
        private string Uad, UFiyat;
        string IUrun.urunadi
        {
            get
            {
                return Uad;
            }

            set
            {
                Uad = value;
            }
        }

        string IUrun.urunfiyat
        {
            get
            {
                return UFiyat;
            }

            set
            {
                UFiyat = value;
            }
        }

       string IMusteri.Yazdir()
        {
            return "Müşteri Bilgisi:"+ this.Mad+" "+this.Msoyad;
        }

       string IUrun.Yazdir()
        {
            return "ÜrünBilgisi"+ this.Uad + " " + this.UFiyat;
        }
    }
}
