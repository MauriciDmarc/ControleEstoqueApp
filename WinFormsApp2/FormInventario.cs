using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp2.BD;

namespace WinFormsApp2
{
    public partial class FormInventario : Form
    {
        CRUD_Inventário crud = new CRUD_Inventário();
        public FormInventario()
        {
            InitializeComponent();
            lblData.Text = DateTime.Now.ToString("dd/MM/yy");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string code = txtCode.Text;
            lblName.Text = crud.returnName(code);

            List<int> entrada = crud.returnIn(code);
            List<int> saida = crud.returnOut(code);

            var resultentrada = entrada.Sum();
            var resultsaida = saida.Sum();

            int sistema = resultentrada - resultsaida;

            int fisico = Convert.ToInt16(txtQntd.Text);

            if (sistema > fisico)
            {
                lblCount.Text = $"-{sistema - fisico}";
            }
            if (sistema < fisico)
            {
                lblCount.Text = $"+{fisico - sistema}";
            }
            if (sistema == fisico)
            {
                lblCount.Text = "☑";
            }

        }
    }
}
