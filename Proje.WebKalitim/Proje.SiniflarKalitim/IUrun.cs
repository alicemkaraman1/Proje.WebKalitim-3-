using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.SiniflarKalitim
{
   public interface IUrun
    {
        string urunadi { get; set; }
        string urunfiyat { get; set; }

        string Yazdir();
    }
}
