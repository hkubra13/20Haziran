using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20Haziran
{
    internal class YazarDAO
    {
        string connectionString = "Data Source=KUBRA\\SQLEXPRESS02;Initial Catalog=_20Haziran;User ID=sa;Password=123456;Integrated Security=True;"; 

        internal List<Yazar> getAllYazarlar()
        {

            List<Yazar> returnThese = new List<Yazar>();
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            Yazar yazar = new Yazar();
            SqlCommand command = new SqlCommand("SELECT * FROM yazar", connection);

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {

                    yazar.yazarId = reader.GetInt32(0);
                    yazar.yazarAd = reader.GetString(1);
                }
            }
            returnThese.Add(yazar);

            connection.Close();
            return returnThese;
        }
    }
}
