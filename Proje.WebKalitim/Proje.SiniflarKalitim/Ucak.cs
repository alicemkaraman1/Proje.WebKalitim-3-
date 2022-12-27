using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.SiniflarKalitim
{
   public abstract class Ucak
    {
        public int yolcukapasitesi { get; set; }
        public string UcakSirketi { get; set; }


        public abstract string FiyatGetir();
        
    }



}
