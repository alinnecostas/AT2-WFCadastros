using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AT2_WFCadastroPessoa
{
    public partial class FormCadastro : Form
    {
        public FormCadastro()
        {
            InitializeComponent();
        }

        public void Erro(string mensagem)
        {
            MessageBox.Show(mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void Sucesso(string mensagem)
        {
            MessageBox.Show(mensagem, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FormCadastro_Load(object sender, EventArgs e)
        {
            ListaProdutos p = new ListaProdutos
            {
                Codigo = ListaProdutos.Produtos.Count + 1,
                Nome = "Produto 1",
                CPF = "123456789",
                Email = "alinne@gmail.com",
                TipoTelefone = ETipoTelefone.Comercial // Defina um valor padrão ou remova esta linha se não quiser definir um valor padrão
            };

            ListaProdutos.Produtos.Add(p);

            // Gera o próximo código automaticamente
            txtCodigo.Text = (ListaProdutos.Produtos.Count + 1).ToString();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNome.Text))
            {
                Erro("Campo Nome não pode estar Vazio!");
                return;
            }

            if (string.IsNullOrEmpty(mktCPF.Text))
            {
                Erro("Campo CPF não pode estar Vazio!");
                return;
            }

            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                Erro("Campo Email não pode estar Vazio!");
                return;
            }

            if (string.IsNullOrEmpty(mktTelefone.Text))
            {
                Erro("Campo Telefone não pode estar Vazio!");
                return;
            }

            ETipoTelefone tipoTelefone;
            if (!rdbComercial.Checked && !rdbPessoal.Checked && !rdbRecado.Checked)
            {
                Erro("Deve-se marcar uma opção de Tipo de Telefone!");
                return;
            }
            else
            {
                if (rdbComercial.Checked)
                    tipoTelefone = ETipoTelefone.Comercial;
                else if (rdbPessoal.Checked)
                    tipoTelefone = ETipoTelefone.Pessoal;
                else
                    tipoTelefone = ETipoTelefone.Recado;
            }

            // Remove a formatação do CPF antes de converter para int
            string cpfSemFormatacao = mktCPF.Text.Replace(".", "").Replace("-", "");

            ListaProdutos p = new ListaProdutos
            {
                Codigo = int.Parse(txtCodigo.Text),
                Nome = txtNome.Text,
                CPF = mktCPF.Text,
                Email = txtEmail.Text,
                Telefone = mktTelefone.Text,
                TipoTelefone = tipoTelefone
            };

            ListaProdutos.Produtos.Add(p);

            Sucesso("Cadastrado com Sucesso!");

            Close();

            FormListar form = new FormListar();
            form.ShowDialog();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
