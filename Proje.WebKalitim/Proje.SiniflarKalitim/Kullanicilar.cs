using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.SiniflarKalitim
{
    public class Kullanicilar : OrtakOzellikler
    {
        public Kullanicilar()
        {
            this.Durum = '1';

        }

        public override bool Ekle(object Nesne)
        {
            throw new NotImplementedException();
        }

        public override bool Guncelle(object Nesne)
        {
            throw new NotImplementedException();
        }

        public override string Listele(object Nesne)
        {
            throw new NotImplementedException();
        }
    }
}
