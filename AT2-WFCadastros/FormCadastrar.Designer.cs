namespace AT2_WFCadastros
{
    partial class FormCadastrar
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
            btnCadastrar = new Button();
            lblLista = new Label();
            cbxLista = new ComboBox();
            lblDataCadastro = new Label();
            txtDataCadastro = new DateTimePicker();
            gbxStatus = new GroupBox();
            rdbInativo = new RadioButton();
            rdbAtivo = new RadioButton();
            txtDescricao = new TextBox();
            lblDescricao = new Label();
            txtNome = new TextBox();
            lblNome = new Label();
            lblCodigo = new Label();
            txtCodigo = new TextBox();
            gbxStatus.SuspendLayout();
            SuspendLayout();
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(348, 282);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(111, 34);
            btnCadastrar.TabIndex = 23;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // lblLista
            // 
            lblLista.AutoSize = true;
            lblLista.Location = new Point(26, 266);
            lblLista.Name = "lblLista";
            lblLista.Size = new Size(31, 15);
            lblLista.TabIndex = 22;
            lblLista.Text = "Lista";
            // 
            // cbxLista
            // 
            cbxLista.FormattingEnabled = true;
            cbxLista.Location = new Point(26, 293);
            cbxLista.Name = "cbxLista";
            cbxLista.Size = new Size(200, 23);
            cbxLista.TabIndex = 21;
            // 
            // lblDataCadastro
            // 
            lblDataCadastro.AutoSize = true;
            lblDataCadastro.Location = new Point(285, 26);
            lblDataCadastro.Name = "lblDataCadastro";
            lblDataCadastro.Size = new Size(97, 15);
            lblDataCadastro.TabIndex = 20;
            lblDataCadastro.Text = "Data de Cadastro";
            // 
            // txtDataCadastro
            // 
            txtDataCadastro.Location = new Point(285, 44);
            txtDataCadastro.Name = "txtDataCadastro";
            txtDataCadastro.Size = new Size(200, 23);
            txtDataCadastro.TabIndex = 19;
            // 
            // gbxStatus
            // 
            gbxStatus.Controls.Add(rdbInativo);
            gbxStatus.Controls.Add(rdbAtivo);
            gbxStatus.Location = new Point(256, 158);
            gbxStatus.Name = "gbxStatus";
            gbxStatus.Size = new Size(203, 87);
            gbxStatus.TabIndex = 18;
            gbxStatus.TabStop = false;
            gbxStatus.Text = "Status";
            // 
            // rdbInativo
            // 
            rdbInativo.AutoSize = true;
            rdbInativo.Location = new Point(125, 41);
            rdbInativo.Name = "rdbInativo";
            rdbInativo.Size = new Size(61, 19);
            rdbInativo.TabIndex = 1;
            rdbInativo.TabStop = true;
            rdbInativo.Text = "Inativo";
            rdbInativo.UseVisualStyleBackColor = true;
            // 
            // rdbAtivo
            // 
            rdbAtivo.AutoSize = true;
            rdbAtivo.Location = new Point(11, 41);
            rdbAtivo.Name = "rdbAtivo";
            rdbAtivo.Size = new Size(53, 19);
            rdbAtivo.TabIndex = 0;
            rdbAtivo.TabStop = true;
            rdbAtivo.Text = "Ativo";
            rdbAtivo.UseVisualStyleBackColor = true;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(25, 162);
            txtDescricao.Multiline = true;
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(203, 83);
            txtDescricao.TabIndex = 17;
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Location = new Point(25, 144);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(58, 15);
            lblDescricao.TabIndex = 16;
            lblDescricao.Text = "Descrição";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(25, 104);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(463, 23);
            txtNome.TabIndex = 15;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(26, 86);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 14;
            lblNome.Text = "Nome";
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(25, 26);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(46, 15);
            lblCodigo.TabIndex = 13;
            lblCodigo.Text = "Código";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(25, 44);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(64, 23);
            txtCodigo.TabIndex = 12;
            // 
            // FormCadastrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(513, 368);
            Controls.Add(btnCadastrar);
            Controls.Add(lblLista);
            Controls.Add(cbxLista);
            Controls.Add(lblDataCadastro);
            Controls.Add(txtDataCadastro);
            Controls.Add(gbxStatus);
            Controls.Add(txtDescricao);
            Controls.Add(lblDescricao);
            Controls.Add(txtNome);
            Controls.Add(lblNome);
            Controls.Add(lblCodigo);
            Controls.Add(txtCodigo);
            Name = "FormCadastrar";
            Text = "FormCadastrar";
            gbxStatus.ResumeLayout(false);
            gbxStatus.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCadastrar;
        private Label lblLista;
        private ComboBox cbxLista;
        private Label lblDataCadastro;
        private DateTimePicker txtDataCadastro;
        private GroupBox gbxStatus;
        private RadioButton rdbInativo;
        private RadioButton rdbAtivo;
        private TextBox txtDescricao;
        private Label lblDescricao;
        private TextBox txtNome;
        private Label lblNome;
        private Label lblCodigo;
        private TextBox txtCodigo;
    }
}
