using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.SiniflarKalitim
{
   public interface IMusteri
    {
        string musteriad { get; set; }
        string musterisoyad { get; set; }

        string Yazdir();

    }
}
