namespace WinFormsApp2
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            groupBox1 = new GroupBox();
            txtPass = new TextBox();
            label2 = new Label();
            txtUser = new TextBox();
            label1 = new Label();
            buttonLogin = new Button();
            buttonCancel = new Button();
            linkLabel1 = new LinkLabel();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtPass);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtUser);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(14, 16);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(400, 256);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Login";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // txtPass
            // 
            txtPass.CharacterCasing = CharacterCasing.Lower;
            txtPass.Location = new Point(6, 163);
            txtPass.MaxLength = 100;
            txtPass.Name = "txtPass";
            txtPass.PlaceholderText = "apenas números";
            txtPass.Size = new Size(230, 27);
            txtPass.TabIndex = 3;
            txtPass.UseSystemPasswordChar = true;
            txtPass.Enter += txtPass_Enter;
            txtPass.KeyDown += txtPass_KeyDown;
            txtPass.Leave += txtPass_Leave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(6, 132);
            label2.Name = "label2";
            label2.Size = new Size(69, 28);
            label2.TabIndex = 2;
            label2.Text = "Senha:";
            // 
            // txtUser
            // 
            txtUser.CharacterCasing = CharacterCasing.Lower;
            txtUser.Location = new Point(6, 77);
            txtUser.MaxLength = 100;
            txtUser.Name = "txtUser";
            txtUser.PlaceholderText = "matrícula";
            txtUser.Size = new Size(230, 27);
            txtUser.TabIndex = 1;
            txtUser.Enter += txtUser_Enter;
            txtUser.KeyDown += txtUser_KeyDown;
            txtUser.Leave += txtUser_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(6, 46);
            label1.Name = "label1";
            label1.Size = new Size(83, 28);
            label1.TabIndex = 0;
            label1.Text = "Usuário:";
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(14, 368);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(185, 78);
            buttonLogin.TabIndex = 1;
            buttonLogin.Text = "LOGAR";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(229, 368);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(185, 78);
            buttonCancel.TabIndex = 2;
            buttonCancel.Text = "CANCELAR";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel1.Location = new Point(139, 293);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(150, 28);
            linkLabel1.TabIndex = 3;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Esqueci a Senha";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(426, 487);
            Controls.Add(linkLabel1);
            Controls.Add(buttonCancel);
            Controls.Add(buttonLogin);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtPass;
        private Label label2;
        private TextBox txtUser;
        private Label label1;
        private Button buttonLogin;
        private Button buttonCancel;
        private LinkLabel linkLabel1;
    }
}