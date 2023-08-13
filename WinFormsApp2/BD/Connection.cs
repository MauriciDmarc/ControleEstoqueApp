using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace WinFormsApp2.BD
{
    public class Connection
    {
        MySqlConnection conn = new MySqlConnection();
        public Connection() 
        {
            conn.ConnectionString = "datasource=localhost;username=root;password=233544899;database=controle_estoque";
        }

        public MySqlConnection Conect()
        {

            if(conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
            return conn;
        }

        public void Desconect()
        {
            if (conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
        }

    }
}
