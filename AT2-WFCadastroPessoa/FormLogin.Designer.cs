namespace AT2_WFCadastroPessoa
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            txtLogin = new TextBox();
            txtSenha = new TextBox();
            btnEntrar = new Button();
            SuspendLayout();
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(140, 156);
            txtLogin.Name = "txtLogin";
            txtLogin.PlaceholderText = "Login";
            txtLogin.Size = new Size(155, 23);
            txtLogin.TabIndex = 1;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(140, 185);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.PlaceholderText = "Senha";
            txtSenha.Size = new Size(155, 23);
            txtSenha.TabIndex = 2;
            // 
            // btnEntrar
            // 
            btnEntrar.Location = new Point(170, 226);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(90, 23);
            btnEntrar.TabIndex = 4;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(413, 401);
            Controls.Add(btnEntrar);
            Controls.Add(txtSenha);
            Controls.Add(txtLogin);
            Name = "FormLogin";
            RightToLeft = RightToLeft.No;
            Text = "FormLogin";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtLogin;
        private TextBox txtSenha;
        private Button btnEntrar;
    }
}
