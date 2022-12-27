using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.SiniflarKalitim
{
   public class BuyukUcak:Ucak
    {


        public override string FiyatGetir()
        {
            return "Büyük Uçak 10 TL dir.";
        }
    }
}
