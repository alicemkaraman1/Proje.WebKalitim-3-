using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
namespace Proje.WebKalitim.neos
{
    public partial class Okul : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Proje.SiniflarKalitim.Teknoloji yeni = new SiniflarKalitim.Teknoloji("tek","muğla","12313131","Lisans");
            string isim= yeni.OkulAdiGetir();
            Label1.Text = isim;
        }
        public static List<Proje.SiniflarKalitim.Okul> OkulListe = new List<SiniflarKalitim.Okul>();
        protected void Button2_Click(object sender, EventArgs e)
        {
            Proje.SiniflarKalitim.Okul entity = new SiniflarKalitim.Okul();
            entity.Ad = txt_okulad.Text;
            entity.Adres = txt_okuladres.Text;
            entity.Kodu = txt_okulkodu.Text;
            entity.Telefon = txt_okultel.Text;
            OkulListe.Add(entity);

            Proje.Veritabani.Baglanti baglan = new Veritabani.Baglanti();
            SqlConnection con=baglan.Baglan();
            string sorgum = "insert into Okul Values('"+txt_okulad.Text+"','"+txt_okuladres.Text+"','"+txt_okulkodu.Text+"','"+txt_okultel.Text+"')";
            bool sonuc = baglan.VeriyiEkleGuncelleSil(con, sorgum);
            if (sonuc == true)
                Label1.Text = "Veri Eklenmiştir.";
            
            //Proje.Veritabani.Baglanti yeni = new Veritabani.Baglanti();
            //SqlConnection con= yeni.Baglan();
            //SqlDataReader rd = yeni.VeriyiGetir(con,"select * from Okul");
            //while(rd.Read())
            //{
            //    var sonuc = rd.GetValue(0).ToString()+" "+ rd.GetValue(1).ToString();


            //}

            //entity.BilgiGetir("1", OkulListe);
        }

        
        protected void Button3_Click(object sender, EventArgs e)
        {
            Session["Okullar"] = OkulListe;
            Response.Redirect("/neos/Bolum.aspx");
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var okulidsecilen = DropDownList1.SelectedValue;
            Proje.Veritabani.Baglanti yeni = new Veritabani.Baglanti();
            SqlConnection con = yeni.Baglan();
            SqlDataReader rd = yeni.VeriyiGetir(con, "select * from Okul where OkulId="+okulidsecilen+"");
            while (rd.Read())
            {
                txt_okuladyeni.Text= rd.GetValue(1).ToString();
                txt_okuladresyeni.Text = rd.GetValue(2).ToString();
                txt_okulkodyeni.Text = rd.GetValue(3).ToString();
                txt_okultelyeni.Text = rd.GetValue(4).ToString();

            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
           
        }
    }
}