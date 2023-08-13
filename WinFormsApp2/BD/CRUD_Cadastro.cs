using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using WinFormsApp2.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WinFormsApp2.BD
{
    public class CRUD_Cadastro
    {
        Connection conn = new Connection();
        MySqlCommand cmd = new MySqlCommand();

        public void InsertUpdate(string nome, string fornecedor, string codigo_interno, string ean13, string data, int? index)
        {

            try
            {

                if (index == null)
                {
                    string sql = $"INSERT INTO itens_cadastro (product_name, supplier, internal_code, ean13, include_date)" +
                                 $" VALUES('{nome}', '{fornecedor}', '{codigo_interno}', '{ean13}', '{data}') ";

                    cmd.Connection = conn.Conect();
                    cmd.CommandText = sql;
                    cmd.ExecuteReader();

                    MessageBox.Show("Item Cadastrado!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string sql = $"UPDATE itens_cadastro SET product_name='{nome}', supplier='{fornecedor}', internal_code={codigo_interno}, ean13='{ean13}', include_date='{data}' " +
                                 $"WHERE product_id={index}";

                    cmd.Connection = conn.Conect();
                    cmd.CommandText = sql;
                    cmd.ExecuteReader();

                    MessageBox.Show("Item Atualizado!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { conn.Desconect(); }
        }

        public List<ItensModel> listItens()
        {

            List<ItensModel> litens = new List<ItensModel>();
            try
            {

                string sql = "SELECT * FROM itens_cadastro";

                cmd.Connection = conn.Conect();
                cmd.CommandText = sql;

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string id = reader.GetString("product_id");
                    string name = reader.GetString("product_name");
                    string supplier = reader.GetString("supplier");
                    int internalCode = reader.GetInt32("internal_code");
                    double ean13 = reader.GetDouble("ean13");
                    string date = reader.GetString("include_date");

                    ItensModel itens = new ItensModel(id, name, supplier, internalCode, ean13, date);
                    litens.Add(itens);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            { conn.Desconect(); }
            return litens;
        }

        public void Delete(int? index)
        {
            try
            {
                string sql = $"DELETE FROM itens_cadastro WHERE product_id = {index}";

                cmd.Connection = conn.Conect();
                cmd.CommandText = sql;
                cmd.ExecuteReader();

                MessageBox.Show("Item Deletado!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            { conn.Desconect(); }

        }

        public List<ItensModel> listItensParam(string param)
        {
            List<ItensModel> litens = new List<ItensModel>();
            try
            {
                string sql = "SELECT * FROM itens_cadastro " +
                    $"WHERE product_name LIKE '%{param}%' OR supplier LIKE '%{param}%' OR internal_code LIKE '%{param}%' OR ean13 LIKE '%{param}%' OR include_date LIKE '%{param}%'";

                cmd.Connection = conn.Conect();
                cmd.CommandText = sql;

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string id = reader.GetString("product_id");
                    string name = reader.GetString("product_name");
                    string supplier = reader.GetString("supplier");
                    int internalCode = reader.GetInt32("internal_code");
                    double ean13 = reader.GetDouble("ean13");
                    string date = reader.GetString("include_date");

                    ItensModel itens = new ItensModel(id, name, supplier, internalCode, ean13, date);
                    litens.Add(itens);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            { conn.Desconect(); }
            return litens;
        }

    }
}
