using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                connection.Close();
            }
            catch (Exception ex)
            {


            }
        }

    }
}
