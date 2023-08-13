using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp2.BD;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp2
{
    public partial class FormInOut : Form
    {

        CRUD_InOut crud = new CRUD_InOut();
        private string transacao = "Entrada";
        private string motivo = null;
        public FormInOut()
        {
            InitializeComponent();
            listTransacions.GridLines = true;
            listTransacions.View = View.Details;
            listTransacions.LabelEdit = true;
            listTransacions.FullRowSelect = true;
            listTransacions.BorderStyle = BorderStyle.None;
            listTransacions.Columns.Add("ID", 50, HorizontalAlignment.Center);
            listTransacions.Columns.Add("Item", 250, HorizontalAlignment.Left);
            listTransacions.Columns.Add("Transação", 100, HorizontalAlignment.Center);
            listTransacions.Columns.Add("Motivo", 100, HorizontalAlignment.Center);
            listTransacions.Columns.Add("Quantidade", 100, HorizontalAlignment.Center);
            listTransacions.Columns.Add("Código", 100, HorizontalAlignment.Center);
            listTransacions.Columns.Add("Validade", 80, HorizontalAlignment.Center);
            listTransacions.Columns.Add("Data", 170, HorizontalAlignment.Center);

            lblData.Text = "Atualizando...";
        }

        private void FormInOut_Load(object sender, EventArgs e)
        {
            btRefresh_Click(sender, e);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblData.Text = DateTime.Now.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (motivo != null && txtCodigo.Text != null && txtQntd.Text != "" && txtValidade.Text != "")
            {
                string data = DateTime.Now.ToString("dd/MM/yy HH:mm:ss");
                string code = txtCodigo.Text;
                string qntd = txtQntd.Text;
                string validity = txtValidade.Text;

                crud.Entrada_Saida(transacao, motivo, qntd, code, validity, data);
                txtCodigo.Clear();
                txtQntd.Clear();
                txtValidade.Clear();
                btRefresh_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Preencha todos os Campos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void radioEntrada_CheckedChanged(object sender, EventArgs e)
        {
            if (radioEntrada.Checked)
            {
                transacao = "ENTRADA";
                radio1.Text = "Compra";
                if (radio1.Checked)
                {
                    motivo = "Compra";
                }
            }
            if (radioSaida.Checked)
            {
                transacao = "SAÍDA";
                radio1.Text = "Venda";
                if (radio1.Checked)
                {
                    motivo = "Venda";
                }
            }

        }

        private void radio1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioEntrada.Checked)
            {
                motivo = "Compra";
            }
            if (radioSaida.Checked)
            {
                motivo = "Venda";
            }
        }

        private void radio2_CheckedChanged(object sender, EventArgs e)
        {
            if (radio2.Checked)
            {
                motivo = "Devolução";
            }
        }

        private void radioOutros_CheckedChanged(object sender, EventArgs e)
        {
            if (radioOutros.Checked)
            {
                motivo = "Outros";
            }
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            var transactions = crud.listAll();

            listTransacions.Items.Clear();

            foreach (var t in transactions)
            {
                ListViewItem lt = new ListViewItem(new string[]
                {
                    t.Id, t.Product_name, t.Transaction, t.Reason, t.Amount.ToString(), t.Internal_code.ToString(), t.Validity, t.Insert_date
                });

                listTransacions.Items.Add(lt);
            }
        }
    }
}
