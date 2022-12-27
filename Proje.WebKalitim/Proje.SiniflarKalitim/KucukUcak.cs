using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.SiniflarKalitim
{
    public class KucukUcak : Ucak
    {
        public override string FiyatGetir()
        {
            return "Küçük Uçak Fiyatı 3 TLdir";
        }
    }
}
