using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT2_WFCadastroPessoa
{

    public enum ETipoTelefone
    {
        Pessoal = 1,
        Comercial,
        Recado
    }
    internal class ListaProdutos
    {

        public int Codigo { get; set; }
        public string? Nome { get; set; }
        public string? CPF { get; set; }
        public string? Email { get; set; }
        public string? Telefone { get; set; }
        public ETipoTelefone TipoTelefone { get; set; }
        public DateTime DataVencimento { get; set; }



        public static List<ListaProdutos> Produtos = new List<ListaProdutos>();


    }
}
