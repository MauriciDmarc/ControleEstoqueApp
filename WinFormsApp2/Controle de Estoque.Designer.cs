namespace WinFormsApp2
{
    partial class FormHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            menuCadastro = new ToolStripMenuItem();
            menuInOut = new ToolStripMenuItem();
            menuInventario = new ToolStripMenuItem();
            menuRelatorios = new ToolStripMenuItem();
            menuHome = new MenuStrip();
            menuHome.SuspendLayout();
            SuspendLayout();
            // 
            // menuCadastro
            // 
            menuCadastro.AutoSize = false;
            menuCadastro.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            menuCadastro.ForeColor = Color.White;
            menuCadastro.Image = Controle_de_Estoque.Properties.Resources.Justicon_Free_Simple_Line_Box_Arrow_Email_Mail_512;
            menuCadastro.ImageScaling = ToolStripItemImageScaling.None;
            menuCadastro.Name = "menuCadastro";
            menuCadastro.Size = new Size(280, 80);
            menuCadastro.Text = "Cadastro de Itens";
            menuCadastro.Click += homeCadastro_Click;
            // 
            // menuInOut
            // 
            menuInOut.AutoSize = false;
            menuInOut.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            menuInOut.ForeColor = Color.White;
            menuInOut.Image = Controle_de_Estoque.Properties.Resources.Justicon_Free_Simple_Line_File_Exchange_Document_Arrow_512;
            menuInOut.ImageScaling = ToolStripItemImageScaling.None;
            menuInOut.Name = "menuInOut";
            menuInOut.Size = new Size(280, 80);
            menuInOut.Text = "Entrada e Saída";
            menuInOut.Click += menuInOut_Click;
            // 
            // menuInventario
            // 
            menuInventario.AutoSize = false;
            menuInventario.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            menuInventario.ForeColor = Color.White;
            menuInventario.Image = Controle_de_Estoque.Properties.Resources.Justicon_Free_Simple_Line_Building_Area_Barrier_Build_512;
            menuInventario.ImageScaling = ToolStripItemImageScaling.None;
            menuInventario.Name = "menuInventario";
            menuInventario.Size = new Size(280, 80);
            menuInventario.Text = "Inventário";
            menuInventario.Click += menuInventario_Click;
            // 
            // menuRelatorios
            // 
            menuRelatorios.AutoSize = false;
            menuRelatorios.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            menuRelatorios.ForeColor = Color.White;
            menuRelatorios.Image = Controle_de_Estoque.Properties.Resources.Justicon_Free_Simple_Line_Report_Clip_Board_Medical_Data_Business_512;
            menuRelatorios.ImageScaling = ToolStripItemImageScaling.None;
            menuRelatorios.Name = "menuRelatorios";
            menuRelatorios.Size = new Size(280, 80);
            menuRelatorios.Text = "Relatórios";
            menuRelatorios.Click += menuRelatorios_Click;
            // 
            // menuHome
            // 
            menuHome.BackColor = Color.DodgerBlue;
            menuHome.ImageScalingSize = new Size(20, 20);
            menuHome.Items.AddRange(new ToolStripItem[] { menuCadastro, menuInOut, menuInventario, menuRelatorios });
            menuHome.Location = new Point(0, 0);
            menuHome.Name = "menuHome";
            menuHome.Padding = new Padding(20, 20, 0, 5);
            menuHome.RenderMode = ToolStripRenderMode.Professional;
            menuHome.Size = new Size(1531, 105);
            menuHome.TabIndex = 0;
            menuHome.Text = "Menu Home";
            // 
            // FormHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(1531, 763);
            Controls.Add(menuHome);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = menuHome;
            MinimizeBox = false;
            Name = "FormHome";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Controle de Estoque";
            WindowState = FormWindowState.Maximized;
            FormClosing += FormHome_FormClosing;
            menuHome.ResumeLayout(false);
            menuHome.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStripMenuItem menuCadastro;
        private ToolStripMenuItem menuInOut;
        private ToolStripMenuItem menuInventario;
        private ToolStripMenuItem menuRelatorios;
        private MenuStrip menuHome;
    }
}