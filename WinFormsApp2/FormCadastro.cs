using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlX.XDevAPI.CRUD;
using WinFormsApp2.BD;

namespace WinFormsApp2
{
    public partial class FormCadastro : Form
    {

        private int? index = null;

        CRUD_Cadastro crud = new CRUD_Cadastro();
        public FormCadastro()
        {
            InitializeComponent();
            listProducts.GridLines = true;
            listProducts.View = View.Details;
            listProducts.LabelEdit = true;
            listProducts.FullRowSelect = true;
            listProducts.BorderStyle = BorderStyle.None;
            listProducts.Columns.Add("ID", 80, HorizontalAlignment.Center);
            listProducts.Columns.Add("Item", 250, HorizontalAlignment.Left);
            listProducts.Columns.Add("Fornecedor", 200, HorizontalAlignment.Left);
            listProducts.Columns.Add("Código", 100, HorizontalAlignment.Center);
            listProducts.Columns.Add("EAN13", 200, HorizontalAlignment.Center);
            listProducts.Columns.Add("Data", 120, HorizontalAlignment.Center);

            var date = DateTime.Now.ToString("dd/MM/yyyy");
            lblData.Text = "Data: " + date;

            btRefresh_Click(this, new EventArgs());
        }

        private void FormCadastro_Load(object sender, EventArgs e)
        {

        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {

            if (txtNameItem.Text != "" && txtCodeItem.Text != "" && txtean13.Text != "" && txtSupplier.Text != "")
            {
                string nome = txtNameItem.Text;
                string fornecedor = txtSupplier.Text;
                string codigo_interno = txtCodeItem.Text;
                string ean13 = txtean13.Text;
                string data = DateTime.Now.ToString("dd/MM/yy");

                if (ean13.Length == 13)
                {
                    crud.InsertUpdate(nome, fornecedor, codigo_interno, ean13, data, index);
                    txtNameItem.Clear();
                    txtCodeItem.Clear();
                    txtSupplier.Clear();
                    txtean13.Clear();
                }
                else
                {
                    MessageBox.Show("Verifique o código EAN13", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


            }
            else
            {
                MessageBox.Show("Preencha todos os campos!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            btRefresh_Click(sender, e);
            index = null;
            lbl_id.Text = "";
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            var itens = crud.listItens();

            listProducts.Items.Clear();

            foreach (var item in itens)
            {
                ListViewItem litens = new ListViewItem(new string[]
                {
                    item.Id, item.Product_name, item.Supplier, item.Internal_code.ToString(), item.Ean13.ToString(), item.Include_date
                });

                listProducts.Items.Add(litens);
                index = null;
                lbl_id.Text = "";
                txtBuscar.Clear();
            }
        }

        private void listProducts_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            ListView.SelectedListViewItemCollection itens_selecionado = listProducts.SelectedItems;

            foreach (ListViewItem item in itens_selecionado)
            {
                index = Convert.ToInt32(item.SubItems[0].Text);

                txtNameItem.Text = item.SubItems[1].Text;
                txtSupplier.Text = item.SubItems[2].Text;
                txtCodeItem.Text = item.SubItems[3].Text;
                txtean13.Text = item.SubItems[4].Text;
            }

            lbl_id.Text = $"ID: {index}";
        }

        private void btDelete_Click(object sender, EventArgs e)
        {

            if (index != null)
            {
                var result = MessageBox.Show($"Deseja deletar o item selecionado? ID: {index}", "Apagar item", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    crud.Delete(index);
                    btRefresh_Click(sender, e);
                    index = null;
                    lbl_id.Text = "";
                }
            }

        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            var itens = crud.listItensParam(txtBuscar.Text);

            listProducts.Items.Clear();
            index = null;
            lbl_id.Text = "";

            foreach (var item in itens)
            {
                ListViewItem litens = new ListViewItem(new string[]
                {
                    item.Id, item.Product_name, item.Supplier, item.Internal_code.ToString(), item.Ean13.ToString(), item.Include_date
                });

                listProducts.Items.Add(litens);
            }
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            txtNameItem.Clear();
            txtSupplier.Clear();
            txtCodeItem.Clear();
            txtean13.Clear();

            index = null;
            lbl_id.Text = "";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
