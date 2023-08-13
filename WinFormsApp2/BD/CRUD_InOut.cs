using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using WinFormsApp2.Models;

namespace WinFormsApp2.BD
{
    public class CRUD_InOut
    {
        Connection conn = new Connection();
        MySqlCommand cmd = new MySqlCommand();

        private string recuperarNome(string codigo)
        {
            string product = null;
            try
            {
                string sql_requestproduct = $"SELECT product_name FROM itens_cadastro WHERE internal_code = {codigo}";

                cmd.Connection = conn.Conect();
                cmd.CommandText = sql_requestproduct;
                var reader = cmd.ExecuteReader();

                while(reader.Read())
                {
                    product = reader.GetString(0);
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally{ conn.Desconect(); };
            return product;
        }
        public void Entrada_Saida(string transacao, string motivo, string qntd, string codigo, string validade, string data)
        {
            try
            {
                string product_name = recuperarNome(codigo);

                if (product_name != "" && product_name != null)
                {
                    string sql = "INSERT INTO transactions (product_name, transaction_mode, reason, amount, internal_code, product_validity, insert_date)" +
                                                 $" VALUES ('{product_name}', '{transacao}', '{motivo}', '{qntd}', '{codigo}', '{validade}', '{data}')";

                    cmd.Connection = conn.Conect();
                    cmd.CommandText = sql;
                    cmd.ExecuteReader();
                    MessageBox.Show("Transação Concluída!", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Digite o código corretamente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { conn.Desconect(); }
        }

        public List<TransactionsModel> listAll()
        {
            List<TransactionsModel> ltransactions = new List<TransactionsModel>();
            try
            {
                string sql = "SELECT * FROM transactions";

                cmd.Connection = conn.Conect();
                cmd.CommandText = sql;

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string id = reader.GetString("transactions_id");
                    string name = reader.GetString("product_name");
                    string transaction = reader.GetString("transaction_mode");
                    string reason = reader.GetString("reason");
                    int amount = reader.GetInt32("amount");
                    int internalCode = reader.GetInt32("internal_code");
                    string validity = reader.GetString("product_validity");
                    string date = reader.GetString("insert_date");

                    TransactionsModel transactions = new TransactionsModel(id , name, transaction, reason, amount, internalCode, validity, date);
                    ltransactions.Add(transactions);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { conn.Desconect(); }
            return ltransactions;
        }
    }
}
