using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class FormHome : Form
    {
        public bool exit = false;
        public FormHome()
        {
            InitializeComponent();
        }

        private void homeCadastro_Click(object sender, EventArgs e)
        {
            //fecha as anteriores
            foreach (Form j in this.MdiChildren)
            {
                j.Close();
            }
            //abre uma nova janela e bloqueia acesso a mais 1
            Form cadastro = new FormCadastro();
            cadastro.MdiParent = this;
            cadastro.Show();

            //atualiza menustrip
            menuCadastro.Enabled = false;
            menuInOut.Enabled = true;
            menuInventario.Enabled = true;
            menuRelatorios.Enabled = true;

        }

        private void menuInOut_Click(object sender, EventArgs e)
        {
            //fecha as anteriores
            foreach (Form j in this.MdiChildren)
            {
                j.Close();
            }
            //abre uma nova janela e bloqueia acesso a mais 1
            Form inout = new FormInOut();
            inout.MdiParent = this;
            inout.Show();

            //atualiza menustrip
            menuCadastro.Enabled = true;
            menuInOut.Enabled = false;
            menuInventario.Enabled = true;
            menuRelatorios.Enabled = true;
        }

        private void FormHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            Dispose();
        }

        private void menuInventario_Click(object sender, EventArgs e)
        {
            //fecha as anteriores
            foreach (Form j in this.MdiChildren)
            {
                j.Close();
            }
            //abre uma nova janela e bloqueia acesso a mais 1
            Form inv = new FormInventario();
            inv.MdiParent = this;
            inv.Show();
            //atualiza menustrip
            menuCadastro.Enabled = true;
            menuInOut.Enabled = true;
            menuInventario.Enabled = false;
            menuRelatorios.Enabled = true;
        }

        private void menuRelatorios_Click(object sender, EventArgs e)
        {
            //atualiza menustrip
            menuCadastro.Enabled = true;
            menuInOut.Enabled = true;
            menuInventario.Enabled = true;
            menuRelatorios.Enabled = false;
        }
    }
}
