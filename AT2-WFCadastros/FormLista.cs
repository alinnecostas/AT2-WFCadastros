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
    public partial class FormLista : Form
    {

        public FormLista()
        {
            InitializeComponent();
        }

        private void FormLista_Load(object sender, EventArgs e)
        {
            dgvLista.DataSource = Categoria.ListaCategoria;
        }

        private void FormLista_Load_1(object sender, EventArgs e)
        {
            dgvLista.DataSource = Categoria.ListaCategoria;

        }
    }
}