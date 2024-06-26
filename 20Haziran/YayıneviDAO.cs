﻿using System;
using System.Collections.Generic;
using System.Data;
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

            SqlCommand command = new SqlCommand("SELECT * FROM yayınevi", connection);

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Yayınevi yayınevi = new Yayınevi();
                    yayınevi.yayıneviId = reader.GetInt32(0);
                    yayınevi.yayıneviAd = reader.GetString(1);
                    returnThese.Add(yayınevi);
                }
            }


            connection.Close();
            return returnThese;
        }
        public DataTableCollection GetYayıneviId()
        {

            using (SqlConnection connection = new SqlConnection(connectionString)) 
            { 
                connection.Open();


                SqlCommand command = new SqlCommand("SELECT * FROM yayınevi", connection);


                SqlDataAdapter da = new SqlDataAdapter(command);

                DataSet ds = new DataSet();

                da.Fill(ds);

                command.ExecuteNonQuery();

                connection.Close();
                return ds.Tables;
            }

        }

        public int AddOneYazar(Yayınevi yayınevi)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand("INSERT INTO yayınevi(yayıneviAd) VALUES(@yad)", connection);
            command.Parameters.AddWithValue("@yad", yayınevi.yayıneviAd);
            int newRows = command.ExecuteNonQuery();

            connection.Close();
            return newRows;
        }

        public int DeleteYayınevi(int yayıneviId)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlCommand command = new SqlCommand("DELETE FROM yayınevi WHERE yayıneviId = @yayineviid", connection);
            command.Parameters.AddWithValue("@yayineviid", yayıneviId);
            int result = command.ExecuteNonQuery();

            connection.Close();
            return result;
        }

        public List<Yayınevi> searchTitles(string searchTerm)
        {
            List<Yayınevi> returnThese = new List<Yayınevi>();

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string searchWildPhrase = "%" + searchTerm + "%";

            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT * FROM yayınevi WHERE yayıneviAd LIKE @search";
            command.Parameters.AddWithValue("@search", searchWildPhrase);
            command.Connection = connection;

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Yayınevi yayınevi = new Yayınevi();
                    yayınevi.yayıneviId = reader.GetInt32(0);
                    yayınevi.yayıneviAd = reader.GetString(1);
                    returnThese.Add(yayınevi);
                }
            }


            connection.Close();
            return returnThese;
        }
    }
}
