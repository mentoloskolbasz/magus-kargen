using MagusLib;
using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Text.Json;

namespace MagusKliens
{
    public class DB_Muveletek
    {

        MySqlConnection connection;
        //static SqlCommand command;

        public DB_Muveletek()
        {
            kapcsolodas();
        }
        public long Mentes(IKarakter karakter, long id)
        {
            using (MySqlCommand parancs = sqlParancs())
            {
                using (MySqlTransaction tranzakcio = connection.BeginTransaction())
                {
                    parancs.Transaction = tranzakcio;
                    
                    try
                    {
                        if (id == 0)
                        {
                            parancs.Parameters.AddWithValue("@faj", karakter.Faj);
                            parancs.CommandText = "INSERT INTO `karakter` (`faj`) VALUES (@faj)";
                            parancs.ExecuteNonQuery();
                            parancs.Parameters.Clear();
                            id = parancs.LastInsertedId;
                        }
                        parancs.Parameters.AddWithValue("@karakter_id", id);
                        parancs.Parameters.AddWithValue("@nev", karakter.Nev);
                        parancs.Parameters.AddWithValue("@szint", karakter.Szint);
                        parancs.Parameters.AddWithValue("@alkaszt", karakter.Alkaszt);
                        parancs.Parameters.AddWithValue("@adatok",
                            JsonSerializer.Serialize(
                                karakter,
                                new JsonSerializerOptions
                                {
                                    IgnoreReadOnlyProperties = false,
                                    WriteIndented = false
                                }
                             )
                        );
                        parancs.CommandText = "INSERT INTO `karakter_verziok` (`karakter_id`, `nev`, `szint`, `alkaszt`, `adatok`) VALUES (@karakter_id, @nev, @szint, @alkaszt, @adatok)";
                        parancs.ExecuteNonQuery();
                        tranzakcio.Commit();
                    }
                    catch (Exception)
                    {
                        tranzakcio.Rollback();
                        throw;
                    }
                    return id;
                }
            }
        }



        private void kapcsolodas()
        {
            try
            {
                if (connection is null || connection.State != System.Data.ConnectionState.Open)
                {
                    connection = new MySqlConnection();
                    connection.ConnectionString = ConfigurationManager.ConnectionStrings["MagusDB"].ConnectionString;
                    connection.Open();
                }
            }
            catch (Exception ex)
            {
                string cs = Interaction.InputBox("ConnectionString");

                connection = new MySqlConnection();
                connection.ConnectionString = cs;
                connection.Open();
            }
        }

        private MySqlCommand sqlParancs()
        {
            kapcsolodas();
            return new MySqlCommand { Connection = connection };
        }


        ~DB_Muveletek()
        {
            try
            {
                if (connection != null && connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }

            }
            catch (Exception ex)
            {


            }
        }

    }
}
