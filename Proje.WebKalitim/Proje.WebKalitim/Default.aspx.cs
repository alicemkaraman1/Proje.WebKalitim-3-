using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proje.WebKalitim
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           // Proje.SiniflarKalitim.Universite yeni = new SiniflarKalitim.Universite(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text);


            Proje.SiniflarKalitim.Teknoloji tek = new SiniflarKalitim.Teknoloji(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text);
            tek.LabSayisi =int.Parse(TextBox5.Text);



            //
            Label1.Text = tek.OkulAdiGetir();
            Label1.Text += "</br>" + tek.OkulLabSayisiGetir();



        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Proje.SiniflarKalitim.BuyukUcak by = new SiniflarKalitim.BuyukUcak();
            Label1.Text = by.FiyatGetir();

            Proje.SiniflarKalitim.KucukUcak kc = new SiniflarKalitim.KucukUcak();
            Label1.Text +="</br>"+ kc.FiyatGetir();


        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Proje.SiniflarKalitim.Teknoloji yeni = new SiniflarKalitim.Teknoloji("","","","");
            Label2.Text=yeni.ToplamOgrenciSayisiGetir(TextBox7.Text);
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Proje.SiniflarKalitim.Satis yeni = new SiniflarKalitim.Satis();
            Proje.SiniflarKalitim.IMusteri arayuzmusteri = (Proje.SiniflarKalitim.IMusteri)yeni;
            arayuzmusteri.musteriad = "Güncel";
            arayuzmusteri.musterisoyad = "Sarıman";
            Label2.Text= arayuzmusteri.Yazdir();


            Proje.SiniflarKalitim.IUrun arayuzurun = (Proje.SiniflarKalitim.IUrun)yeni;
            arayuzurun.urunadi = "biskrem";
            arayuzurun.urunfiyat = "10";
            Label2.Text = arayuzurun.Yazdir();

            Proje.Veritabani.PersonelSistemiEntity veritabani = new Veritabani.PersonelSistemiEntity();
            var sonuc = new Proje.Veritabani.PersonelSistemiEntity();
            ///linq sorgu yazımı
            var bilgi = (from d in sonuc.Personel select d).ToList();
            Label1.Text = bilgi[0].PersonelAd;


            
        }
    }
}