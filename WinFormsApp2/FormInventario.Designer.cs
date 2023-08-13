namespace WinFormsApp2
{
    partial class FormInventario
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            button1 = new Button();
            groupBox2 = new GroupBox();
            txtQntd = new TextBox();
            txtCode = new TextBox();
            label5 = new Label();
            label4 = new Label();
            lblName = new Label();
            lblCount = new Label();
            label3 = new Label();
            lblData = new Label();
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
            label1.Location = new Point(610, 87);
            label1.Name = "label1";
            label1.Size = new Size(528, 106);
            label1.TabIndex = 0;
            label1.Text = "INVENTÁRIO";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(lblName);
            groupBox1.Controls.Add(lblCount);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(lblData);
            groupBox1.Location = new Point(74, 208);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1607, 610);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(712, 218);
            button1.Name = "button1";
            button1.Size = new Size(218, 159);
            button1.TabIndex = 6;
            button1.Text = "CONFIRMAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtQntd);
            groupBox2.Controls.Add(txtCode);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(50, 109);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(575, 369);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Produto";
            // 
            // txtQntd
            // 
            txtQntd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtQntd.Location = new Point(240, 234);
            txtQntd.Name = "txtQntd";
            txtQntd.Size = new Size(261, 34);
            txtQntd.TabIndex = 3;
            // 
            // txtCode
            // 
            txtCode.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCode.Location = new Point(240, 113);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(261, 34);
            txtCode.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(49, 236);
            label5.Name = "label5";
            label5.Size = new Size(144, 32);
            label5.TabIndex = 1;
            label5.Text = "Quantidade:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(49, 115);
            label4.Name = "label4";
            label4.Size = new Size(96, 32);
            label4.TabIndex = 0;
            label4.Text = "Código:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblName.ForeColor = Color.White;
            lblName.Location = new Point(1138, 437);
            lblName.Name = "lblName";
            lblName.Size = new Size(358, 41);
            lblName.TabIndex = 3;
            lblName.Text = "Produto Produto Produto";
            lblName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Font = new Font("Segoe UI", 72F, FontStyle.Bold, GraphicsUnit.Point);
            lblCount.ForeColor = Color.White;
            lblCount.Location = new Point(1221, 219);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(230, 159);
            lblCount.TabIndex = 2;
            lblCount.Text = "☑";
            lblCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(1097, 109);
            label3.Name = "label3";
            label3.Size = new Size(451, 54);
            label3.TabIndex = 1;
            label3.Text = "Quantidade no Estoque:";
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Font = new Font("Segoe UI", 24F, FontStyle.Italic, GraphicsUnit.Point);
            lblData.ForeColor = Color.White;
            lblData.Location = new Point(722, 109);
            lblData.Name = "lblData";
            lblData.Size = new Size(187, 54);
            lblData.TabIndex = 0;
            lblData.Text = "00/00/00";
            // 
            // FormInventario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(1753, 830);
            ControlBox = false;
            Controls.Add(groupBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormInventario";
            Text = "Inventário";
            WindowState = FormWindowState.Maximized;
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
        private Label lblData;
        private Label lblName;
        private Label lblCount;
        private Label label3;
        private Button button1;
        private GroupBox groupBox2;
        private Label label5;
        private Label label4;
        private TextBox txtCode;
        private TextBox txtQntd;
    }
}