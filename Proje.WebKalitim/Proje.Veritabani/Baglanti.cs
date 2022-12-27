using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Proje.Veritabani
{
  public class Baglanti
    {
        public SqlConnection Baglan()
        {
            SqlConnection con = new SqlConnection("Data Source=labsis.msku.edu.tr;Initial Catalog=LabSistemi;Persist Security Info=True;User ID=deneme1;Password=abc.123");
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
                return con;
            }
            else
                return null;
        }

        public SqlDataReader VeriyiGetir(SqlConnection cn,string sorgu)
        {
            
            SqlCommand com = new SqlCommand(sorgu, cn);
            SqlDataReader rd = com.ExecuteReader();
                if (rd.HasRows == true)
                    return rd;
                else
                    return null;
            
        }

        public bool VeriyiEkleGuncelleSil(SqlConnection con,string sorgu)
        {
            SqlCommand com = new SqlCommand(sorgu, con);
            int sonuc = com.ExecuteNonQuery();
            if (sonuc == 1)
                return true;
            else
                return false;
        }

    }


}
