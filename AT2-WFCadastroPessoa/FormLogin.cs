namespace AT2_WFCadastroPessoa
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            FormPrincipal form = new FormPrincipal();
            form.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Usuario us = new Usuario();
            us.Codigo = 001;
            us.Login = "admin";
            us.Senha = "123456";
            us.DataCadastro = Convert.ToDateTime("18/03/2025");
            us.DataCadastro = DateTime.Now;

            Usuario.ListaUsuarios.Add(us);

        }
    }
    
}
