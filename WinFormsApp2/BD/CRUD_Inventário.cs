using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace WinFormsApp2.BD
{
    public class CRUD_Inventário
    {
        Connection conn = new Connection();
        MySqlCommand cmd = new MySqlCommand();
        public string returnName(string codigo)
        {
            string product = null;
            try
            {
                string sql_requestproduct = $"SELECT product_name FROM itens_cadastro WHERE internal_code = {codigo}";

                cmd.Connection = conn.Conect();
                cmd.CommandText = sql_requestproduct;
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    product = reader.GetString(0);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { conn.Desconect(); };
            return product;
        }

        public List<int> returnIn(string codigo)
        {
            List<int> listin = new List<int>();
            try
            {
                string sql_requestproduct = $"SELECT amount FROM transactions WHERE internal_code = {codigo} AND transaction_mode = 'ENTRADA'";

                cmd.Connection = conn.Conect();
                cmd.CommandText = sql_requestproduct;
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int amount = reader.GetInt32(0);
                    listin.Add(amount);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { conn.Desconect(); };
            return listin;
        }
        public List<int> returnOut(string codigo)
        {
            List<int> listout = new List<int>();
            try
            {
                string sql_requestproduct = $"SELECT amount FROM transactions WHERE internal_code = {codigo} AND transaction_mode = 'SAÍDA'";

                cmd.Connection = conn.Conect();
                cmd.CommandText = sql_requestproduct;
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int amount = reader.GetInt32(0);
                    listout.Add(amount);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { conn.Desconect(); };
            return listout;
        }
    }
}
