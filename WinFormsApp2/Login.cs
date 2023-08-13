using System.Security.Cryptography.X509Certificates;

namespace WinFormsApp2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUser.Text.Equals("394330") && txtPass.Text.Equals("123"))
                {
                    this.Hide();
                    var menu = new FormHome();
                    menu.ShowDialog();
                    if (menu.IsDisposed)
                    {
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Usuário ou senha incorretos!", "Erro",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    txtUser.Text = null;
                    txtPass.Text = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            txtPass.BackColor = Color.LightYellow;
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            txtPass.BackColor = SystemColors.HighlightText;
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            txtUser.BackColor = Color.LightYellow;
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            txtUser.BackColor = SystemColors.HighlightText;
        }

        private void txtUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPass.Focus();
            }
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonLogin_Click(sender, e);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Contate-nos para redefinir a senha!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}