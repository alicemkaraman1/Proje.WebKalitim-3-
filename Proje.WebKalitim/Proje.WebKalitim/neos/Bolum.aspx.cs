using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proje.WebKalitim.neos
{
    public partial class Bolum : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        { 

            if (!IsPostBack)
            {
                List<Proje.SiniflarKalitim.Okul> Okulum = (List<Proje.SiniflarKalitim.Okul>)Session["Okullar"];
                drp_okul.DataTextField = "Ad";
                drp_okul.DataValueField = "Kodu";
                drp_okul.DataSource = Okulum;
                drp_okul.DataBind();
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
        }
        public static List<Proje.SiniflarKalitim.Bolum> BolumListe = new List<SiniflarKalitim.Bolum>();
        protected void Button2_Click(object sender, EventArgs e)
        {
            Proje.SiniflarKalitim.Bolum entity = new SiniflarKalitim.Bolum();
            entity.Kodu = drp_okul.SelectedValue;
            entity.Ad = txt_okulad.Text;
            entity.Adres = txt_okuladres.Text;
            entity.Kodu = txt_okulkodu.Text;
            entity.Telefon = txt_okultel.Text;
            BolumListe.Add(entity);
            Session["Bolumler"] = BolumListe;
           

            //entity.BilgiGetir("1", OkulListe);
        }
    }
}