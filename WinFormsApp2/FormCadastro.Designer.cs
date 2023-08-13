namespace WinFormsApp2
{
    partial class FormCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastro));
            label1 = new Label();
            groupBox1 = new GroupBox();
            lbl_id = new Label();
            btLimpar = new Button();
            txtSupplier = new TextBox();
            labelFornecedor = new Label();
            btCadastrar = new Button();
            lblData = new Label();
            txtean13 = new TextBox();
            label4 = new Label();
            txtCodeItem = new TextBox();
            txtNameItem = new TextBox();
            label3 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            btDelete = new Button();
            btRefresh = new Button();
            txtBuscar = new TextBox();
            btBuscar = new Button();
            listProducts = new ListView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(479, 88);
            label1.Name = "label1";
            label1.Size = new Size(838, 106);
            label1.TabIndex = 0;
            label1.Text = "CADASTRO DE ITENS";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBox1.Controls.Add(lbl_id);
            groupBox1.Controls.Add(btLimpar);
            groupBox1.Controls.Add(txtSupplier);
            groupBox1.Controls.Add(labelFornecedor);
            groupBox1.Controls.Add(btCadastrar);
            groupBox1.Controls.Add(lblData);
            groupBox1.Controls.Add(txtean13);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtCodeItem);
            groupBox1.Controls.Add(txtNameItem);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(48, 259);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(706, 559);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cadastro";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // lbl_id
            // 
            lbl_id.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_id.AutoSize = true;
            lbl_id.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_id.Location = new Point(447, 331);
            lbl_id.Name = "lbl_id";
            lbl_id.Size = new Size(100, 41);
            lbl_id.TabIndex = 11;
            lbl_id.Text = "ID: 10";
            // 
            // btLimpar
            // 
            btLimpar.Font = new Font("Segoe UI", 14F, FontStyle.Italic, GraphicsUnit.Point);
            btLimpar.ForeColor = Color.Black;
            btLimpar.Location = new Point(36, 420);
            btLimpar.Name = "btLimpar";
            btLimpar.Size = new Size(181, 113);
            btLimpar.TabIndex = 10;
            btLimpar.Text = "Limpar";
            btLimpar.UseVisualStyleBackColor = true;
            btLimpar.Click += btLimpar_Click;
            // 
            // txtSupplier
            // 
            txtSupplier.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtSupplier.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtSupplier.Location = new Point(252, 131);
            txtSupplier.Name = "txtSupplier";
            txtSupplier.Size = new Size(369, 30);
            txtSupplier.TabIndex = 9;
            txtSupplier.TextAlign = HorizontalAlignment.Center;
            // 
            // labelFornecedor
            // 
            labelFornecedor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelFornecedor.AutoSize = true;
            labelFornecedor.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelFornecedor.Location = new Point(35, 127);
            labelFornecedor.Name = "labelFornecedor";
            labelFornecedor.Size = new Size(147, 32);
            labelFornecedor.TabIndex = 8;
            labelFornecedor.Text = "Fornecedor: ";
            // 
            // btCadastrar
            // 
            btCadastrar.BackColor = Color.LimeGreen;
            btCadastrar.FlatAppearance.BorderColor = Color.DarkSlateGray;
            btCadastrar.FlatAppearance.BorderSize = 12;
            btCadastrar.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            btCadastrar.ForeColor = Color.White;
            btCadastrar.Location = new Point(224, 420);
            btCadastrar.Name = "btCadastrar";
            btCadastrar.Size = new Size(448, 113);
            btCadastrar.TabIndex = 7;
            btCadastrar.Text = "Salvar";
            btCadastrar.UseVisualStyleBackColor = false;
            btCadastrar.Click += btCadastrar_Click;
            // 
            // lblData
            // 
            lblData.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblData.AutoSize = true;
            lblData.Font = new Font("Segoe UI", 20F, FontStyle.Italic, GraphicsUnit.Point);
            lblData.Location = new Point(118, 331);
            lblData.Name = "lblData";
            lblData.Size = new Size(277, 46);
            lblData.TabIndex = 6;
            lblData.Text = "Data: 00/00/0000";
            lblData.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtean13
            // 
            txtean13.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtean13.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtean13.Location = new Point(252, 277);
            txtean13.Name = "txtean13";
            txtean13.Size = new Size(369, 30);
            txtean13.TabIndex = 5;
            txtean13.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(35, 273);
            label4.Name = "label4";
            label4.Size = new Size(181, 32);
            label4.TabIndex = 4;
            label4.Text = "Código EAN13: ";
            // 
            // txtCodeItem
            // 
            txtCodeItem.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtCodeItem.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtCodeItem.Location = new Point(252, 204);
            txtCodeItem.Name = "txtCodeItem";
            txtCodeItem.Size = new Size(369, 30);
            txtCodeItem.TabIndex = 3;
            txtCodeItem.TextAlign = HorizontalAlignment.Center;
            // 
            // txtNameItem
            // 
            txtNameItem.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtNameItem.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtNameItem.Location = new Point(252, 55);
            txtNameItem.MaxLength = 200;
            txtNameItem.Name = "txtNameItem";
            txtNameItem.ShortcutsEnabled = false;
            txtNameItem.Size = new Size(369, 30);
            txtNameItem.TabIndex = 2;
            txtNameItem.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(35, 200);
            label3.Name = "label3";
            label3.Size = new Size(187, 32);
            label3.TabIndex = 1;
            label3.Text = "Código Interno: ";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(34, 51);
            label2.Name = "label2";
            label2.Size = new Size(182, 32);
            label2.TabIndex = 0;
            label2.Text = "Nome do Item: ";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBox2.Controls.Add(btDelete);
            groupBox2.Controls.Add(btRefresh);
            groupBox2.Controls.Add(txtBuscar);
            groupBox2.Controls.Add(btBuscar);
            groupBox2.Controls.Add(listProducts);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(774, 259);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(931, 559);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            // 
            // btDelete
            // 
            btDelete.BackColor = Color.IndianRed;
            btDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btDelete.ForeColor = SystemColors.ControlLightLight;
            btDelete.Location = new Point(232, 51);
            btDelete.Name = "btDelete";
            btDelete.Size = new Size(162, 53);
            btDelete.TabIndex = 4;
            btDelete.Text = "DELETAR";
            btDelete.UseVisualStyleBackColor = false;
            btDelete.Click += btDelete_Click;
            // 
            // btRefresh
            // 
            btRefresh.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            btRefresh.ForeColor = Color.Black;
            btRefresh.Location = new Point(64, 52);
            btRefresh.Name = "btRefresh";
            btRefresh.Size = new Size(162, 53);
            btRefresh.TabIndex = 3;
            btRefresh.Text = "REFRESH";
            btRefresh.UseVisualStyleBackColor = true;
            btRefresh.Click += btRefresh_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtBuscar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtBuscar.Location = new Point(539, 65);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(191, 30);
            txtBuscar.TabIndex = 2;
            // 
            // btBuscar
            // 
            btBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btBuscar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btBuscar.ForeColor = Color.Black;
            btBuscar.Location = new Point(747, 51);
            btBuscar.Name = "btBuscar";
            btBuscar.Size = new Size(124, 53);
            btBuscar.TabIndex = 1;
            btBuscar.Text = "Buscar";
            btBuscar.UseVisualStyleBackColor = true;
            btBuscar.Click += btBuscar_Click;
            // 
            // listProducts
            // 
            listProducts.Alignment = ListViewAlignment.SnapToGrid;
            listProducts.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            listProducts.BackColor = SystemColors.ControlDarkDark;
            listProducts.ForeColor = Color.White;
            listProducts.Location = new Point(64, 111);
            listProducts.MultiSelect = false;
            listProducts.Name = "listProducts";
            listProducts.Size = new Size(807, 442);
            listProducts.TabIndex = 0;
            listProducts.UseCompatibleStateImageBehavior = false;
            listProducts.ItemSelectionChanged += listProducts_ItemSelectionChanged;
            // 
            // FormCadastro
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoSize = true;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(1753, 830);
            ControlBox = false;
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimizeBox = false;
            Name = "FormCadastro";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cadastro";
            WindowState = FormWindowState.Maximized;
            Load += FormCadastro_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ListView listProducts;
        private TextBox txtNameItem;
        private Label label3;
        private Label label2;
        private TextBox txtCodeItem;
        private Label lblData;
        private TextBox txtean13;
        private Label label4;
        private Button btCadastrar;
        private TextBox txtSupplier;
        private Label labelFornecedor;
        private TextBox txtBuscar;
        private Button btBuscar;
        private Button btRefresh;
        private Button btDelete;
        private Button btLimpar;
        private Label lbl_id;
    }
}