using _20Haziran;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
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

            SqlCommand command = new SqlCommand("SELECT kitapId, kitapAd, yazarAd, sayfaNo, yayıneviAd, basimTarihi FROM kitapevi\r\nLEFT JOIN yazar on kitapevi.yazarId = yazar.yazarId \r\nLEFT JOIN yayınevi on kitapevi.yayıneviId = yayınevi.yayıneviId", connection);

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Kitap kitap = new Kitap();

                    kitap.kitapId = reader.GetInt32(reader.GetOrdinal("kitapId"));
                    kitap.kitapAd = reader.IsDBNull(reader.GetOrdinal("kitapAd")) ? "Unknown" : reader.GetString(reader.GetOrdinal("kitapAd"));
                    kitap.yazarAd = reader.IsDBNull(reader.GetOrdinal("yazarAd")) ? "Unknown" : reader.GetString(reader.GetOrdinal("yazarAd"));
                    kitap.sayfaNo = reader.IsDBNull(reader.GetOrdinal("sayfaNo")) ? 0 : reader.GetInt32(reader.GetOrdinal("sayfaNo"));
                    kitap.yayınevi = reader.IsDBNull(reader.GetOrdinal("yayıneviAd")) ? "Unknown" : reader.GetString(reader.GetOrdinal("yayıneviAd"));
                    kitap.basimTarihi = reader.IsDBNull(reader.GetOrdinal("basimTarihi")) ? DateTime.MinValue : reader.GetDateTime(reader.GetOrdinal("basimTarihi"));
                    returnThese.Add(kitap);
                }
            }
            connection.Close();
            return returnThese;
        }
        public List<Kitap> searchTitles(string searchTermKitap, string searchTermYayınevi, string searchTermYazar)
        {
            List<Kitap> returnThese = new List<Kitap>();

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string searchWildPhraseKitap = "%" + searchTermKitap + "%";
            string searchWildPhraseYayınevi = "%" + searchTermYayınevi + "%";
            string searchWildPhraseYazar = "%" + searchTermYazar + "%";

            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT kitapId, kitapAd, yazarAd, sayfaNo, yayıneviAd, basimTarihi FROM kitapevi\r\nLEFT JOIN yazar on kitapevi.yazarId = yazar.yazarId \r\nLEFT JOIN yayınevi on kitapevi.yayıneviId = yayınevi.yayıneviId WHERE 1 = 1";
            if (!string.IsNullOrEmpty(searchTermYazar))
            {
                command.CommandText = command.CommandText + " AND yazarAd LIKE @search3";
                command.Parameters.AddWithValue("@search3", searchWildPhraseYazar);
            }
            if (!string.IsNullOrEmpty(searchTermKitap))
            {
                command.CommandText += " AND kitapAd LIKE @search1";
                command.Parameters.AddWithValue("@search1", searchWildPhraseKitap);
            }
            if (!string.IsNullOrEmpty(searchTermYayınevi))
            {
                command.CommandText = command.CommandText + " AND yayıneviAd LIKE @search2";
                command.Parameters.AddWithValue("@search2", searchWildPhraseYayınevi);
            }

            command.Connection = connection;

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Kitap kitap = new Kitap();
                    
                    kitap.kitapId = reader.GetInt32(reader.GetOrdinal("kitapId"));
                    kitap.kitapAd = reader.IsDBNull(reader.GetOrdinal("kitapAd")) ? "Unknown" : reader.GetString(reader.GetOrdinal("kitapAd"));
                    kitap.yazarAd = reader.IsDBNull(reader.GetOrdinal("yazarAd")) ? "Unknown" : reader.GetString(reader.GetOrdinal("yazarAd"));
                    kitap.sayfaNo = reader.IsDBNull(reader.GetOrdinal("sayfaNo")) ? 0 : reader.GetInt32(reader.GetOrdinal("sayfaNo"));
                    kitap.yayınevi = reader.IsDBNull(reader.GetOrdinal("yayıneviAd")) ? "Unknown" : reader.GetString(reader.GetOrdinal("yayıneviAd"));
                    kitap.basimTarihi = reader.IsDBNull(reader.GetOrdinal("basimTarihi")) ? DateTime.MinValue : reader.GetDateTime(reader.GetOrdinal("basimTarihi"));
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

            SqlCommand command = new SqlCommand("INSERT INTO kitapevi (kitapAd, yazarId, sayfaNo, yayıneviId, basimTarihi) VALUES (@kad, @yad, @sayfa, @yayın, @basım)",
            connection);
            command.Parameters.AddWithValue("@kad", kitap.kitapAd);
            command.Parameters.AddWithValue("@yad", kitap.yazarId);
            command.Parameters.AddWithValue("@sayfa", kitap.sayfaNo);
            command.Parameters.AddWithValue("@yayın", kitap.yayıneviId);
            command.Parameters.AddWithValue("@basım", kitap.basimTarihi);
            int newRows = command.ExecuteNonQuery();

            connection.Close();
            return newRows;
        }

        public Kitap gosterKitap(int kitapId)
        {


            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            Kitap kitap = new Kitap();
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT kitapId, kitapAd, yazarAd, sayfaNo, yayıneviAd, basimTarihi FROM kitapevi\r\nLEFT JOIN yazar on kitapevi.yazarId = yazar.yazarId \r\nLEFT JOIN yayınevi on kitapevi.yayıneviId = yayınevi.yayıneviId WHERE kitapId = @kitapid";
            command.Parameters.AddWithValue("@kitapid", kitapId);
            command.Connection = connection;

            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {

                    kitap.kitapId = reader.GetInt32(reader.GetOrdinal("kitapId"));
                    kitap.kitapAd = reader.IsDBNull(reader.GetOrdinal("kitapAd")) ? "Unknown" : reader.GetString(reader.GetOrdinal("kitapAd"));
                    kitap.yazarAd = reader.IsDBNull(reader.GetOrdinal("yazarAd")) ? "Unknown" : reader.GetString(reader.GetOrdinal("yazarAd"));
                    kitap.sayfaNo = reader.IsDBNull(reader.GetOrdinal("sayfaNo")) ? 0 : reader.GetInt32(reader.GetOrdinal("sayfaNo"));
                    kitap.yayınevi = reader.IsDBNull(reader.GetOrdinal("yayıneviAd")) ? "Unknown" : reader.GetString(reader.GetOrdinal("yayıneviAd"));
                    kitap.basimTarihi = reader.IsDBNull(reader.GetOrdinal("basimTarihi")) ? DateTime.MinValue : reader.GetDateTime(reader.GetOrdinal("basimTarihi"));


                }
            }
            connection.Close();
            return kitap;
        }

        internal int updateKitap(Kitap kitap)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlCommand command = new SqlCommand("UPDATE kitapevi SET kitapAd = @kad, yazarId = @yad, sayfaNo = @sayfa, yayıneviId = @yayın, basimTarihi = @basım WHERE kitapId = @kitapid", connection);
            command.Parameters.AddWithValue("@kitapid", kitap.kitapId);
            command.Parameters.AddWithValue("@kad", kitap.kitapAd);
            command.Parameters.AddWithValue("@yad", kitap.yazarId);
            command.Parameters.AddWithValue("@sayfa", kitap.sayfaNo);
            command.Parameters.AddWithValue("@yayın", kitap.yayıneviId);
            command.Parameters.AddWithValue("@basım", kitap.basimTarihi);

            int rowsAffected = command.ExecuteNonQuery();
            connection.Close();
            return rowsAffected;
        }

        internal int deleteKitap(int kitapID)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlCommand command = new SqlCommand("DELETE FROM kitapevi WHERE kitapId = @kitapid", connection);
            command.Parameters.AddWithValue("@kitapid", kitapID);
            int result = command.ExecuteNonQuery();

            connection.Close();
            return result;
        }
    }
}


/*
 
 

 
 
 */