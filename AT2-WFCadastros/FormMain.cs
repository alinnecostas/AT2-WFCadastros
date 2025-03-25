
﻿namespace AT2_WFCadastros

{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void mnsCadastrar_Click(object sender, EventArgs e)
        {
            FormCadastrar formCadastrar = new FormCadastrar();
            formCadastrar.Show();
        }

        private void mnsListar_Click(object sender, EventArgs e)
        {
            FormLista formLista = new FormLista();
            formLista.Show();
        }
    }

}



