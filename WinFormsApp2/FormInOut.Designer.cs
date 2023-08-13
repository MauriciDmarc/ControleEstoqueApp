namespace WinFormsApp2
{
    partial class FormInOut
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInOut));
            label1 = new Label();
            groupEntrada = new GroupBox();
            button1 = new Button();
            txtValidade = new TextBox();
            lblValidade = new Label();
            txtQntd = new TextBox();
            label3 = new Label();
            txtCodigo = new TextBox();
            label2 = new Label();
            lblData = new Label();
            groupEntradaSaida = new GroupBox();
            radioSaida = new RadioButton();
            radioEntrada = new RadioButton();
            groupMotivo = new GroupBox();
            radioOutros = new RadioButton();
            radio2 = new RadioButton();
            radio1 = new RadioButton();
            groupBox2 = new GroupBox();
            btRefresh = new Button();
            listTransacions = new ListView();
            timer1 = new System.Windows.Forms.Timer(components);
            groupEntrada.SuspendLayout();
            groupEntradaSaida.SuspendLayout();
            groupMotivo.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(491, 88);
            label1.Name = "label1";
            label1.Size = new Size(747, 106);
            label1.TabIndex = 0;
            label1.Text = "ENTRADA E SAÍDA";
            // 
            // groupEntrada
            // 
            groupEntrada.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            groupEntrada.Controls.Add(button1);
            groupEntrada.Controls.Add(txtValidade);
            groupEntrada.Controls.Add(lblValidade);
            groupEntrada.Controls.Add(txtQntd);
            groupEntrada.Controls.Add(label3);
            groupEntrada.Controls.Add(txtCodigo);
            groupEntrada.Controls.Add(label2);
            groupEntrada.Controls.Add(lblData);
            groupEntrada.Controls.Add(groupEntradaSaida);
            groupEntrada.Controls.Add(groupMotivo);
            groupEntrada.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            groupEntrada.ForeColor = Color.White;
            groupEntrada.Location = new Point(49, 232);
            groupEntrada.Name = "groupEntrada";
            groupEntrada.Size = new Size(819, 557);
            groupEntrada.TabIndex = 1;
            groupEntrada.TabStop = false;
            groupEntrada.Text = "ENTRADA E SAÍDA";
            // 
            // button1
            // 
            button1.BackColor = Color.LimeGreen;
            button1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(338, 430);
            button1.Name = "button1";
            button1.Size = new Size(464, 102);
            button1.TabIndex = 11;
            button1.Text = "SALVAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtValidade
            // 
            txtValidade.Location = new Point(550, 311);
            txtValidade.Name = "txtValidade";
            txtValidade.Size = new Size(252, 30);
            txtValidade.TabIndex = 10;
            // 
            // lblValidade
            // 
            lblValidade.AutoSize = true;
            lblValidade.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblValidade.Location = new Point(338, 307);
            lblValidade.Name = "lblValidade";
            lblValidade.Size = new Size(201, 32);
            lblValidade.TabIndex = 9;
            lblValidade.Text = "Validade(--/--/--):";
            // 
            // txtQntd
            // 
            txtQntd.Location = new Point(550, 232);
            txtQntd.Name = "txtQntd";
            txtQntd.Size = new Size(252, 30);
            txtQntd.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(338, 228);
            label3.Name = "label3";
            label3.Size = new Size(151, 32);
            label3.TabIndex = 7;
            label3.Text = "Quantidade: ";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(550, 149);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(252, 30);
            txtCodigo.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(338, 145);
            label2.Name = "label2";
            label2.Size = new Size(187, 32);
            label2.TabIndex = 5;
            label2.Text = "Código Interno: ";
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Font = new Font("Segoe UI", 20F, FontStyle.Italic, GraphicsUnit.Point);
            lblData.Location = new Point(420, 72);
            lblData.Name = "lblData";
            lblData.Size = new Size(285, 46);
            lblData.TabIndex = 3;
            lblData.Text = "00/00/00 00:00:00";
            // 
            // groupEntradaSaida
            // 
            groupEntradaSaida.Controls.Add(radioSaida);
            groupEntradaSaida.Controls.Add(radioEntrada);
            groupEntradaSaida.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            groupEntradaSaida.ForeColor = Color.White;
            groupEntradaSaida.Location = new Point(26, 72);
            groupEntradaSaida.Name = "groupEntradaSaida";
            groupEntradaSaida.Size = new Size(244, 170);
            groupEntradaSaida.TabIndex = 1;
            groupEntradaSaida.TabStop = false;
            groupEntradaSaida.Text = "Operação";
            // 
            // radioSaida
            // 
            radioSaida.AutoSize = true;
            radioSaida.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            radioSaida.Location = new Point(46, 107);
            radioSaida.Name = "radioSaida";
            radioSaida.Size = new Size(108, 36);
            radioSaida.TabIndex = 1;
            radioSaida.TabStop = true;
            radioSaida.Text = "SAÍDA";
            radioSaida.UseVisualStyleBackColor = true;
            // 
            // radioEntrada
            // 
            radioEntrada.AutoSize = true;
            radioEntrada.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            radioEntrada.Location = new Point(46, 48);
            radioEntrada.Name = "radioEntrada";
            radioEntrada.Size = new Size(165, 41);
            radioEntrada.TabIndex = 0;
            radioEntrada.TabStop = true;
            radioEntrada.Text = "ENTRADA";
            radioEntrada.UseVisualStyleBackColor = true;
            radioEntrada.CheckedChanged += radioEntrada_CheckedChanged;
            // 
            // groupMotivo
            // 
            groupMotivo.Controls.Add(radioOutros);
            groupMotivo.Controls.Add(radio2);
            groupMotivo.Controls.Add(radio1);
            groupMotivo.ForeColor = Color.White;
            groupMotivo.Location = new Point(26, 248);
            groupMotivo.Name = "groupMotivo";
            groupMotivo.Size = new Size(244, 284);
            groupMotivo.TabIndex = 2;
            groupMotivo.TabStop = false;
            groupMotivo.Text = "Motivo";
            // 
            // radioOutros
            // 
            radioOutros.AutoSize = true;
            radioOutros.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            radioOutros.Location = new Point(46, 206);
            radioOutros.Name = "radioOutros";
            radioOutros.Size = new Size(125, 41);
            radioOutros.TabIndex = 2;
            radioOutros.TabStop = true;
            radioOutros.Text = "Outros";
            radioOutros.UseVisualStyleBackColor = true;
            radioOutros.CheckedChanged += radioOutros_CheckedChanged;
            // 
            // radio2
            // 
            radio2.AutoSize = true;
            radio2.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            radio2.Location = new Point(46, 127);
            radio2.Name = "radio2";
            radio2.Size = new Size(174, 41);
            radio2.TabIndex = 1;
            radio2.TabStop = true;
            radio2.Text = "Devolução";
            radio2.UseVisualStyleBackColor = true;
            radio2.CheckedChanged += radio2_CheckedChanged;
            // 
            // radio1
            // 
            radio1.AutoSize = true;
            radio1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            radio1.Location = new Point(46, 50);
            radio1.Name = "radio1";
            radio1.Size = new Size(140, 41);
            radio1.TabIndex = 0;
            radio1.TabStop = true;
            radio1.Text = "Compra";
            radio1.UseVisualStyleBackColor = true;
            radio1.CheckedChanged += radio1_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(btRefresh);
            groupBox2.Controls.Add(listTransacions);
            groupBox2.Location = new Point(889, 232);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(814, 557);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            // 
            // btRefresh
            // 
            btRefresh.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            btRefresh.Location = new Point(19, 35);
            btRefresh.Name = "btRefresh";
            btRefresh.Size = new Size(170, 66);
            btRefresh.TabIndex = 1;
            btRefresh.Text = "REFRESH";
            btRefresh.UseVisualStyleBackColor = true;
            btRefresh.Click += btRefresh_Click;
            // 
            // listTransacions
            // 
            listTransacions.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            listTransacions.BackColor = SystemColors.ControlDarkDark;
            listTransacions.ForeColor = Color.White;
            listTransacions.Location = new Point(19, 107);
            listTransacions.Name = "listTransacions";
            listTransacions.Size = new Size(775, 429);
            listTransacions.Sorting = SortOrder.Ascending;
            listTransacions.TabIndex = 0;
            listTransacions.UseCompatibleStateImageBehavior = false;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // FormInOut
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(1753, 830);
            ControlBox = false;
            Controls.Add(groupBox2);
            Controls.Add(groupEntrada);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormInOut";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Entrada e Saída";
            WindowState = FormWindowState.Maximized;
            Load += FormInOut_Load;
            groupEntrada.ResumeLayout(false);
            groupEntrada.PerformLayout();
            groupEntradaSaida.ResumeLayout(false);
            groupEntradaSaida.PerformLayout();
            groupMotivo.ResumeLayout(false);
            groupMotivo.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupEntrada;
        private GroupBox groupMotivo;
        private GroupBox groupEntradaSaida;
        private RadioButton radioOutros;
        private RadioButton radio2;
        private RadioButton radio1;
        private RadioButton radioSaida;
        private RadioButton radioEntrada;
        private GroupBox groupBox2;
        private ListView listTransacions;
        private Label lblData;
        private Label label2;
        private TextBox txtCodigo;
        private TextBox txtQntd;
        private Label label3;
        private Button button1;
        private TextBox txtValidade;
        private Label lblValidade;
        private System.Windows.Forms.Timer timer1;
        private Button btRefresh;
    }
}