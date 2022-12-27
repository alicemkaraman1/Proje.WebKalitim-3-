using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.SiniflarKalitim
{
   public class Program:Bolum
    {
        public string ProgramKodu { get; set; }
        public override string Ekle()
        {
            return "Program Eklemiştir";
        }


        public override string BilgiGetir(string Param, List<Okul> Liste)
        {
            if (Param.Contains("Program"))
                return "Program Adı= " + Param;
            else
                return base.BilgiGetir("-1", Liste);
        }
    }
}
