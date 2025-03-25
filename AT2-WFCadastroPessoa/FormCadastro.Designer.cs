namespace AT2_WFCadastroPessoa
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
            lblCodigo = new Label();
            txtCodigo = new TextBox();
            lblCPF = new Label();
            mktCPF = new MaskedTextBox();
            lblNome = new Label();
            txtNome = new TextBox();
            txtEmail = new TextBox();
            lblEmail = new Label();
            mktTelefone = new MaskedTextBox();
            lblTelefone = new Label();
            gbxTelefone = new GroupBox();
            rdbComercial = new RadioButton();
            rdbRecado = new RadioButton();
            rdbPessoal = new RadioButton();
            cbxFilhos = new CheckBox();
            btnVoltar = new Button();
            btnSalvar = new Button();
            gbxTelefone.SuspendLayout();
            SuspendLayout();
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(28, 37);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(46, 15);
            lblCodigo.TabIndex = 3;
            lblCodigo.Text = "Código";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(28, 55);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(64, 23);
            txtCodigo.TabIndex = 2;
            // 
            // lblCPF
            // 
            lblCPF.AutoSize = true;
            lblCPF.Location = new Point(218, 37);
            lblCPF.Name = "lblCPF";
            lblCPF.Size = new Size(28, 15);
            lblCPF.TabIndex = 5;
            lblCPF.Text = "CPF";
            // 
            // mktCPF
            // 
            mktCPF.Location = new Point(218, 55);
            mktCPF.Mask = "000.000.000-00";
            mktCPF.Name = "mktCPF";
            mktCPF.Size = new Size(100, 23);
            mktCPF.TabIndex = 6;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(28, 107);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 7;
            lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(28, 125);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(290, 23);
            txtNome.TabIndex = 8;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(28, 186);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(290, 23);
            txtEmail.TabIndex = 10;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(28, 168);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 9;
            lblEmail.Text = "Email";
            // 
            // mktTelefone
            // 
            mktTelefone.Location = new Point(28, 261);
            mktTelefone.Mask = "00000-9999";
            mktTelefone.Name = "mktTelefone";
            mktTelefone.Size = new Size(100, 23);
            mktTelefone.TabIndex = 12;
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(28, 243);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(51, 15);
            lblTelefone.TabIndex = 11;
            lblTelefone.Text = "Telefone";
            // 
            // gbxTelefone
            // 
            gbxTelefone.Controls.Add(rdbComercial);
            gbxTelefone.Controls.Add(rdbRecado);
            gbxTelefone.Controls.Add(rdbPessoal);
            gbxTelefone.Location = new Point(165, 243);
            gbxTelefone.Name = "gbxTelefone";
            gbxTelefone.Size = new Size(238, 87);
            gbxTelefone.TabIndex = 13;
            gbxTelefone.TabStop = false;
            gbxTelefone.Text = "Telefone";
            // 
            // rdbComercial
            // 
            rdbComercial.AutoSize = true;
            rdbComercial.Location = new Point(88, 41);
            rdbComercial.Name = "rdbComercial";
            rdbComercial.Size = new Size(79, 19);
            rdbComercial.TabIndex = 2;
            rdbComercial.TabStop = true;
            rdbComercial.Text = "Comercial";
            rdbComercial.UseVisualStyleBackColor = true;
            // 
            // rdbRecado
            // 
            rdbRecado.AutoSize = true;
            rdbRecado.Location = new Point(171, 41);
            rdbRecado.Name = "rdbRecado";
            rdbRecado.Size = new Size(64, 19);
            rdbRecado.TabIndex = 1;
            rdbRecado.TabStop = true;
            rdbRecado.Text = "Recado";
            rdbRecado.UseVisualStyleBackColor = true;
            // 
            // rdbPessoal
            // 
            rdbPessoal.AutoSize = true;
            rdbPessoal.Location = new Point(11, 41);
            rdbPessoal.Name = "rdbPessoal";
            rdbPessoal.Size = new Size(64, 19);
            rdbPessoal.TabIndex = 0;
            rdbPessoal.TabStop = true;
            rdbPessoal.Text = "Pessoal";
            rdbPessoal.UseVisualStyleBackColor = true;
            // 
            // cbxFilhos
            // 
            cbxFilhos.AutoSize = true;
            cbxFilhos.Location = new Point(28, 307);
            cbxFilhos.Name = "cbxFilhos";
            cbxFilhos.Size = new Size(99, 19);
            cbxFilhos.TabIndex = 14;
            cbxFilhos.Text = "Possui Filhos?";
            cbxFilhos.UseVisualStyleBackColor = true;
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(217, 353);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(75, 23);
            btnVoltar.TabIndex = 15;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(325, 353);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 16;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // FormCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(415, 408);
            Controls.Add(btnSalvar);
            Controls.Add(btnVoltar);
            Controls.Add(cbxFilhos);
            Controls.Add(gbxTelefone);
            Controls.Add(mktTelefone);
            Controls.Add(lblTelefone);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtNome);
            Controls.Add(lblNome);
            Controls.Add(mktCPF);
            Controls.Add(lblCPF);
            Controls.Add(lblCodigo);
            Controls.Add(txtCodigo);
            Name = "FormCadastro";
            Text = "FormCadastro";
            Load += FormCadastro_Load;
            gbxTelefone.ResumeLayout(false);
            gbxTelefone.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCodigo;
        private TextBox txtCodigo;
        private Label lblCPF;
        private MaskedTextBox mktCPF;
        private Label lblNome;
        private TextBox txtNome;
        private TextBox txtEmail;
        private Label lblEmail;
        private MaskedTextBox mktTelefone;
        private Label lblTelefone;
        private GroupBox gbxTelefone;
        private RadioButton rdbComercial;
        private RadioButton rdbRecado;
        private RadioButton rdbPessoal;
        private CheckBox cbxFilhos;
        private Button btnVoltar;
        private Button btnSalvar;
    }
}