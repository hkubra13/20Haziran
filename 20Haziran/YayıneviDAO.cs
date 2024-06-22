using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20Haziran
{
    internal class YayıneviDAO
    {
        string connectionString = "Data Source=KUBRA\\SQLEXPRESS02;Initial Catalog=_20Haziran;User ID=sa;Password=123456;Integrated Security=True;";

        internal List<Yayınevi> getAllYayınevleri()
        {

            List<Yayınevi> returnThese = new List<Yayınevi>();
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            Yayınevi yayınevi = new Yayınevi();
            SqlCommand command = new SqlCommand("SELECT * FROM yayınevi", connection);

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {

                    yayınevi.yayıneviId = reader.GetInt32(0);
                    yayınevi.yayıneviAd = reader.GetString(1);
                }
            }
            returnThese.Add(yayınevi);

            connection.Close();
            return returnThese;
        }
    }
}
