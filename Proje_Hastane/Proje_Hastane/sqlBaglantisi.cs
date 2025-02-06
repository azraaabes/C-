using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Proje_Hastane
{
     class sqlBaglantisi
    {
        public SqlConnection baglanti() //metot adı
        {
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-B2AQLAE\\SQLEXPRESS;Initial Catalog=HastaneProje;Integrated Security=True");
            baglan.Open(); //metot
            return baglan;
        }
    }
}
