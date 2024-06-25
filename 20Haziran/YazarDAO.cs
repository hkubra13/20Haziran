using System;
using System.Collections.Generic;
using System.Data;
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

            SqlCommand command = new SqlCommand("SELECT * FROM yazar", connection);

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Yazar yazar = new Yazar();
                    yazar.yazarId = reader.GetInt32(0);
                    yazar.yazarAd = reader.GetString(1);
                    returnThese.Add(yazar);
                }
            }


            connection.Close();
            return returnThese;
        }

        public DataTableCollection GetYazarId()
        {

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlCommand command = new SqlCommand("SELECT * FROM yazar", connection);


            SqlDataAdapter da = new SqlDataAdapter(command);


            DataSet ds = new DataSet();
            da.Fill(ds);


            command.ExecuteNonQuery();


            connection.Close();
            return ds.Tables;

        }

        public int AddOneYazar(Yazar yazar)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand("INSERT INTO yazar(yazarAd) VALUES(@yad)", connection);
            command.Parameters.AddWithValue("@yad", yazar.yazarAd);
            int newRows = command.ExecuteNonQuery();

            connection.Close();
            return newRows;
        }

        public int DeleteYazar(int yazarId)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlCommand command = new SqlCommand("DELETE FROM yazar WHERE yazarId = @yazarid", connection);
            command.Parameters.AddWithValue("@yazarid", yazarId);
            int result = command.ExecuteNonQuery();

            connection.Close();
            return result;
        }

        public List<Yazar> searchTitles(string searchTerm)
        {
            List<Yazar> returnThese = new List<Yazar>();

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string searchWildPhrase = "%" + searchTerm + "%";

            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT * FROM yazar WHERE yazarAd LIKE @search";
            command.Parameters.AddWithValue("@search", searchWildPhrase);
            command.Connection = connection;

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Yazar yazar = new Yazar();
                    yazar.yazarId = reader.GetInt32(0);
                    yazar.yazarAd = reader.GetString(1);
                    returnThese.Add(yazar);
                }
            }


            connection.Close();
            return returnThese;
        }
    }
}
