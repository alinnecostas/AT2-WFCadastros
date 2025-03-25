using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AT2_WFCadastros
{
    public partial class FormCadastrar : Form
    {
        private List<Categoria> categorias = new List<Categoria>();

        public FormCadastrar()
        {
            InitializeComponent();
        }


        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))

            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return;
            }

            else if (string.IsNullOrWhiteSpace(txtDescricao.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return;

            }

            else if (!rdbAtivo.Checked && !rdbInativo.Checked)
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return;

            }




            Categoria novaC1 = new Categoria();
            novaC1.Codigo = Categoria.ListaCategoria.Count + 1;
            novaC1.Nome = txtNome.Text;
            novaC1.Descricao = txtDescricao.Text;
            novaC1.DataCadastro = txtDataCadastro.Value;
            novaC1.Status = rdbAtivo.Checked ? "Ativo" : "Inativo";

            if (novaC1.Status == "Ativo")
            {
                rdbAtivo.Checked = true;
            }
            else
            {
                rdbInativo.Checked = true;
            }



            Categoria.ListaCategoria.Add(novaC1);



            MessageBox.Show("Categoria cadastrada com sucesso!");
            LimparCampos();


            this.Close();

            FormLista formLista = new FormLista();
            formLista.Show();


        }



        private void LimparCampos()
        {
            txtNome.Clear();
            txtDescricao.Clear();
            rdbAtivo.Checked = false;
        }
    }
    }
