using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20Haziran
{
    internal class KitaplarDAO
    {
        string connectionString = "Data Source=KUBRA\\SQLEXPRESS02;Initial Catalog=_20Haziran;User ID=sa;Password=123456;Integrated Security=True;";


        public List<Kitap> getAllKitaplar() 
        { 
            List<Kitap> returnThese = new List<Kitap>();

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlCommand command = new SqlCommand("SELECT * FROM kitapevi", connection);

            using(SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Kitap kitap = new Kitap
                    {
                        kitapId = reader.GetInt32(0),
                        kitapAd = reader.GetString(1),
                        yazarAd = reader.GetString(2),
                        sayfaNo = reader.GetInt32(3),
                        yayınevi = reader.GetString(4),
                        basimTarihi = reader.GetDateTime(5)


                    };
                    returnThese.Add(kitap);
                }
            }
            connection.Close();
            return returnThese;
        }
        public List<Kitap> searchTitles(String searchTerm)
        {
            List<Kitap> returnThese = new List<Kitap>();

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string searchWildPhrase = "%" + searchTerm + "%";

            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT * FROM kitapevi WHERE kitapAd LIKE @search";
            command.Parameters.AddWithValue("@search", searchWildPhrase);
            command.Connection = connection;

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Kitap kitap = new Kitap
                    {
                        kitapId = reader.GetInt32(0),
                        kitapAd = reader.GetString(1),
                        yazarAd = reader.GetString(2),
                        sayfaNo = reader.GetInt32(3),
                        yayınevi = reader.GetString(4),
                        basimTarihi = reader.GetDateTime(5)


                    };
                    returnThese.Add(kitap);
                }
            }
            connection.Close();
            return returnThese;
        }

        internal int addOneKitap(Kitap kitap)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlCommand command = new SqlCommand("INSERT INTO kitapevi (kitapAd, yazarAd, sayfaNo, yayınevi, basimTarihi) VALUES (@kad, @yad, @sayfa, @yayın, @basım)",
            connection);
            command.Parameters.AddWithValue("@kad", kitap.kitapAd);
            command.Parameters.AddWithValue("@yad", kitap.yazarAd);
            command.Parameters.AddWithValue("@sayfa", kitap.sayfaNo);
            command.Parameters.AddWithValue("@yayın", kitap.yayınevi);
            command.Parameters.AddWithValue("@basım", kitap.basimTarihi);
            int newRows = command.ExecuteNonQuery();

            connection.Close();
            return newRows;
        }
    }
    

}
